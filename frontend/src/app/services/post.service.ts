import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { NewPost } from '../models/post/new-post';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class PostService {
    public routePrefix = '/api/posts';

    constructor(private httpService: HttpInternalService) {}

    public getPosts() {
        return this.httpService.getFullRequest<Post[]>(`${this.routePrefix}`);
    }

    public createPost(post: NewPost) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}`, post);
    }

    public likePost(reaction: NewReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/like`, reaction);
    }

    public dislikePost(reaction: NewReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/dislike`, reaction);
    }

    public getUsersThatLikesPost(id: number) {
        return this.httpService.getFullRequest<User[]>(`${this.routePrefix}/likedThePost/${id}`);
    }

    public getUsersThatDislikesPost(id: number) {
        return this.httpService.getFullRequest<User[]>(`${this.routePrefix}/dislikedThePost/${id}`);
    }
}
