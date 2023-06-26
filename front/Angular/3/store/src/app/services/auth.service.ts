import { Injectable } from '@angular/core';
import { IUser } from '../models/IUser';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  currentUser: IUser | undefined;
  constructor() {}

  login(_username: string, _password: string) {
    this.currentUser = {
      username: _username,
      password: _password,
    };
  }

  get isLogin(): boolean {
    if (this.currentUser?.username && this.currentUser?.password) {
      return true;
    } else {
      return false;
    }
  }
}
