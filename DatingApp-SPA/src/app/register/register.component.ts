import { AlertifyService } from './../_services/alertify.service';
import { AuthService } from './../_services/auth.service';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() values: any;
  @Output() cancelRegistration = new EventEmitter();
  model: any = {};

  constructor(
    private authService: AuthService,
    private alterify: AlertifyService
  ) {}

  ngOnInit() {}

  register() {
    console.log(this.model);
    this.authService.register(this.model).subscribe(
      () => {
        this.alterify.success('Register Successfully');
      },
      error => {
        this.alterify.error('Registration failed ' + error);
      }
    );
  }
  cancel() {
    this.cancelRegistration.emit(false);
  }
}
