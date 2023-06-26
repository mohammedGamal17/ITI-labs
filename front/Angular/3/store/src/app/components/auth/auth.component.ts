import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css'],
})
export class AuthComponent {
  username: string = '';
  password: string = '';

  /**
   * Authentication Component Constructor
   */
  constructor(private auth: AuthService, private router: Router) {}

  Login() {
    console.log(this.username, this.password);
    this.auth.login(this.username, this.password);
    this.router.navigate(['/products']);
  }
}
