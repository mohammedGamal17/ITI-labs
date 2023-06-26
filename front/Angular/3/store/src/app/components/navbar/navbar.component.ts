import { Component, Input, OnInit, OnChanges } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent {
  @Input() admin?: boolean;

  /**
   * Authentication Component Constructor
   */
  constructor(private auth: AuthService) {}
  ngOnInit(): void {}

  get getUsername() {
    return this.auth.currentUser?.username;
  }
  get isLogin() {
    return this.auth.isLogin;
  }
  get logout() {
    return (this.auth.currentUser = undefined);
  }
}
