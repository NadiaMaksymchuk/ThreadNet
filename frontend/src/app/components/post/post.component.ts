import { Component, ComponentFactoryResolver, Input, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { Post } from '../../models/post/post';
import { AuthenticationService } from '../../services/auth.service';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { empty, Observable, Subject } from 'rxjs';
import { DialogType } from '../../models/common/auth-dialog-type';
import { LikeService } from '../../services/like.service';
import { NewComment } from '../../models/comment/new-comment';
import { CommentService } from '../../services/comment.service';
import { User } from '../../models/user';
import { Comment } from '../../models/comment/comment';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { DislikeService } from 'src/app/services/dislike.service';
import { ChangeDetectionStrategy } from "@angular/core";
import { PostService } from 'src/app/services/post.service';
import { UpdatePost } from 'src/app/models/post/update-post';
import { MainThreadComponent } from '../main-thread/main-thread.component';
import { GyazoService } from 'src/app/services/gyazo.service';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { ShowReactionsDialogComponent } from '../show-reactions-dialog/show-reactions-dialog.component';
import { Reaction } from 'src/app/models/reactions/reaction';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnDestroy, OnInit {
    @Input() public post: Post;
    @Input() public currentUser: User;
    @Input() public imageUpdateURL: string;
    
    public updatePost= {} as UpdatePost;
    public update = false;
    public showComments = false;
    public newComment = {} as NewComment;
    public mainThreadComponent = this.mainThread;

    private unsubscribe$ = new Subject<void>();

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private dislikeService: DislikeService,
        private commentService: CommentService,
        private snackBarService: SnackBarService,
        private postService: PostService,
        private mainThread: MainThreadComponent,
        private gyazoService: GyazoService,
        public dialog: MatDialog
    ) { }

    ngOnInit() {
        
    }

    public GetLikeCount() {
        return this.post.reactions.filter(x => x.isLike === true).length;
    }

    public GetDislikeCount() {
        return this.post.reactions.filter(x => x.isDislike === true).length;
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public toggleComments() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((user) => {
                    if (user) {
                        this.currentUser = user;
                        this.showComments = !this.showComments;
                    }
                });
            return;
        }

        this.showComments = !this.showComments;
    }

    openDialog(route: string): void {
        let reactions: Reaction[] = [];

        if(route == 'like') {
            reactions = this.post.reactions.filter(x => x.isLike === true);
        }
        
        if(route == 'dislike') {
            reactions = this.post.reactions.filter(x => x.isDislike === true);
        }

        const dialogConfig = new MatDialogConfig();

        dialogConfig.autoFocus = false;
        dialogConfig.maxHeight = '90vh';

        dialogConfig.data = reactions;

        this.dialog.open(ShowReactionsDialogComponent, dialogConfig);
      }

    public likePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (
                    this.post = post
            ));

            return;
        }

        this.likeService
            .likePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => ( this.post = post));
    }

    public dislikePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.dislikeService.dislikePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (
                    this.post = post
            ));
            return;
        }

        this.dislikeService
            .dislikePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => (this.post = post));
    }

    public putPost() {
        this.updatePost.postId = this.post.id;
        this.updatePost.previewImage = this.imageUpdateURL;
        
        const postSubscription = !this.imageUpdateURL
            ? this.postService.updatePost(this.updatePost)
            : this.gyazoService.uploadImage(this.mainThreadComponent.imageFile).pipe(
                switchMap((imageData) => {
                    this.updatePost.previewImage = imageData.url;
                    return this.postService.updatePost(this.updatePost);
                })
            );

            this.update = !this.update;

        postSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
            (respPost) => {
                let index = this.mainThreadComponent.posts.indexOf(this.mainThreadComponent.posts.find(x => x.id === this.updatePost.postId));
                this.mainThreadComponent.posts[index] = respPost.body;
                this.mainThreadComponent.removeImage();
                this.post.body = undefined;
                this.post.previewImage = undefined;
            },
            (error) => this.snackBarService.showErrorMessage(error)
        );
    }

    public removeImage() {
        this.imageUpdateURL = undefined;
        this.mainThreadComponent.imageFile = undefined;
    }

    public updateThisPost() {
        this.imageUpdateURL = this.post.previewImage;
        this.updatePost.body = this.post.body;
        this.updatePost.previewImage = this.post.previewImage;
        this.update = !this.update;
    }

    public removePost() {
        this.postService
        .deletePost(this.post.id)
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe(() => {
            this.post = null;
        },
        (error) => this.snackBarService.showErrorMessage(error));
    }

    public sendComment() {
        this.newComment.authorId = this.currentUser.id;
        this.newComment.postId = this.post.id;

        this.commentService
            .createComment(this.newComment)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if (resp) {
                        this.post.comments = this.sortCommentArray(this.post.comments.concat(resp.body));
                        this.newComment.body = undefined;
                    }
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
    }

    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    private catchErrorWrapper(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();
                return empty();
            })
        );
    }

    private sortCommentArray(array: Comment[]): Comment[] {
        return array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
    }
}
