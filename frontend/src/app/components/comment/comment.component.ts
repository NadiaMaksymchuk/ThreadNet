import { Component, Input } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { catchError, empty, Observable, Subject, switchMap, takeUntil } from 'rxjs';
import { UpdateComment } from 'src/app/models/comment/update-comment';
import { Reaction } from 'src/app/models/reactions/reaction';
import { User } from 'src/app/models/user';
import { AuthenticationService } from 'src/app/services/auth.service';
import { CommentService } from 'src/app/services/comment.service';
import { DislikeService } from 'src/app/services/dislike.service';
import { LikeService } from 'src/app/services/like.service';
import { SnackBarService } from 'src/app/services/snack-bar.service';
import { Comment } from '../../models/comment/comment';
import { PostComponent } from '../post/post.component';
import { ShowReactionsDialogComponent } from '../show-reactions-dialog/show-reactions-dialog.component';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent {
    @Input() public comment: Comment;
    @Input() public currentUser: User;
    @Input() public comments: Comment[];

    public updateComment = {} as UpdateComment;
    public update = false;

    private unsubscribe$ = new Subject<void>();

    public constructor(
        private commentService: CommentService,
        private snackBarService: SnackBarService,
        private authService: AuthenticationService,
        private postComponent: PostComponent,
        private likeService: LikeService,
        public dislikeService: DislikeService,
        public dialog: MatDialog
    ) { }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public deleteComment() {
        this.commentService
        .deleteComment(this.comment.id)
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe(() => {
            this.comment = null;
        },
        (error) => this.snackBarService.showErrorMessage(error));
    }

    public updateThisComment() {
        this.updateComment.body = this.comment.body;
        this.update = !this.update;
    }

    public putPost() {
        this.updateComment.commentId = this.comment.id;
        this.commentService
        .updateComment(this.updateComment)
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe(
            (respComment) => {
                let index = this.comments.indexOf(this.comments.find(x => x.id === this.updateComment.commentId));
                this.comments[index] = respComment.body;
                this.comment.body = undefined;
                this.update = !this.update;
            }
            ,
            (error) => this.snackBarService.showErrorMessage(error)
        );
    }

    public GetLikeCount() {
        return this.comment.reactions.filter(x => x.isLike === true).length;
    }

    public GetDislikeCount() {
        return this.comment.reactions.filter(x => x.isDislike === true).length;
    }

    public likeComment() {
        if (!this.currentUser) {
            this.postComponent.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (
                    this.comment = comment
            ));

            return;
        }

        this.likeService
            .likeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => ( this.comment = comment));
    }

    public dislikeComment() {
        if (!this.currentUser) {
            this.postComponent.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.dislikeService.dislikeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (
                    this.comment = comment
            ));
            return;
        }

        this.dislikeService
            .dislikeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => (this.comment = comment));
    }

    openDialog(route: string): void {
        let reactions: Reaction[] = [];

        if(route == 'like') {
            reactions = this.comment.reactions.filter(x => x.isLike === true);
        }
        
        if(route == 'dislike') {
            reactions = this.comment.reactions.filter(x => x.isDislike === true);
        }

        const dialogConfig = new MatDialogConfig();

        dialogConfig.autoFocus = false;
        dialogConfig.maxHeight = '90vh';

        dialogConfig.data = reactions;

        this.dialog.open(ShowReactionsDialogComponent, dialogConfig);
      }
}
