import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { PostService } from './post.service';
import { User } from '../models/user';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';
import { Comment } from '../models/comment/comment'
import { CommentService } from './comment.service';

@Injectable({
  providedIn: 'root'
})
export class DislikeService {

  constructor(
    private authService: AuthenticationService, 
    private postService: PostService,
    private commentService: CommentService
    ) { }

  public dislikePost(post: Post, currentUser: User) {
    const innerPost = post;

    const reaction: NewReaction = {
        entityId: innerPost.id,
        isDislike: true,
        isLike: false,
        userId: currentUser.id
    };

    let hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);
    if(innerPost.reactions.some((x) => x.user.id === currentUser.id && x.isLike == false && x.isDislike == true)) {
      innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id).concat({ isLike: false, isDislike: false, user: currentUser });
    }
    else {
      innerPost.reactions = hasReaction
      ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id).concat({ isDislike: true, isLike: false, user: currentUser })
      : innerPost.reactions.concat({ isDislike: true, isLike: false, user: currentUser });
    }
       
    hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

    return this.postService.dislikePost(reaction).pipe(
      map(() => innerPost),
      catchError(() => {
          // revert current array changes in case of any error
          innerPost.reactions = hasReaction
              ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
              : innerPost.reactions.concat({ isDislike: true, isLike: false,  user: currentUser });

          return of(innerPost);
      })
    );
  }

  public dislikeComment(comment: Comment, currentUser: User) {
    const innerComment = comment;

    const reaction: NewReaction = {
        entityId: innerComment.id,
        isDislike: true,
        isLike: false,
        userId: currentUser.id
    };

    let hasReaction = innerComment.reactions.some((x) => x.user.id === currentUser.id);
    if(innerComment.reactions.some((x) => x.user.id === currentUser.id && x.isLike == false && x.isDislike == true)) {
      innerComment.reactions = innerComment.reactions.filter((x) => x.user.id !== currentUser.id).concat({ isLike: false, isDislike: false, user: currentUser });
    }
    else {
      innerComment.reactions = hasReaction
      ? innerComment.reactions.filter((x) => x.user.id !== currentUser.id).concat({ isDislike: true, isLike: false, user: currentUser })
      : innerComment.reactions.concat({ isDislike: true, isLike: false, user: currentUser });
    }
       
    hasReaction = innerComment.reactions.some((x) => x.user.id === currentUser.id);

    return this.commentService.dislikeComment(reaction).pipe(
      map(() => innerComment),
      catchError(() => {
          // revert current array changes in case of any error
          innerComment.reactions = hasReaction
              ? innerComment.reactions.filter((x) => x.user.id !== currentUser.id)
              : innerComment.reactions.concat({ isDislike: true, isLike: false,  user: currentUser });

          return of(innerComment);
      })
    );
  }
}
