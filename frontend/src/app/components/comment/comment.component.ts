import { Component, Input } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { UpdateComment } from 'src/app/models/comment/update-comment';
import { User } from 'src/app/models/user';
import { CommentService } from 'src/app/services/comment.service';
import { SnackBarService } from 'src/app/services/snack-bar.service';
import { Comment } from '../../models/comment/comment';

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
}
