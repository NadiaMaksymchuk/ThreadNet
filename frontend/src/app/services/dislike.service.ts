import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { PostService } from './post.service';
import { User } from '../models/user';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DislikeService {

  constructor(private authService: AuthenticationService, private postService: PostService) { }

  public dislikePost(post: Post, currentUser: User) {
    const innerPost = post;

    const reaction: NewReaction = {
        entityId: innerPost.id,
        isDislike: true,
        isLike: false,
        userId: currentUser.id
    };

    let hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);
        innerPost.reactions = hasReaction
            ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            : innerPost.reactions.concat({ isDislike: true, isLike: false, user: currentUser });
        hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

    return this.postService.dislikePost(reaction).pipe(
      map(() => innerPost),
      catchError(() => {
          // revert current array changes in case of any error
          innerPost.reactions = hasReaction
              ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
              : innerPost.reactions.concat({ isLike: false, isDislike: true, user: currentUser });

          return of(innerPost);
      })
    );
  }
}
