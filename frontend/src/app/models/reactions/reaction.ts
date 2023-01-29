import { User } from '../user';

export interface Reaction {
    isLike: boolean;
    isDislike: boolean;
    user: User;
}
