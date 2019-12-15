import { AlertifyService } from './../_services/alertify.service';
import { AuthService } from './../_services/auth.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(
    private router: Router,
    public authService: AuthService,
    private alterify: AlertifyService
  ) {}

  ngOnInit() {}

  login() {
    this.authService.login(this.model).subscribe(
      next => {
        this.model = {};
        this.alterify.success('Logged in successfull');
        this.router.navigate(['/members']);
      },
      error => {
        this.model = {};
        this.alterify.error('Failed to loggin');
      }
    );
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  loggedOut() {
    this.model = {};
    this.authService.loggedOut();
    this.alterify.message('Logout successfully');
    this.router.navigate(['/home']);
  }
}
