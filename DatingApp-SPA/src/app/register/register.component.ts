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

  constructor(private authService: AuthService) {}

  ngOnInit() {}

  register() {
    console.log(this.model);
    this.authService.register(this.model).subscribe(
      () => {
        console.log('Register Successfully');
      },
      error => {
        console.log('Register failed');
      }
    );
  }
  cancel() {
    this.cancelRegistration.emit(false);
  }
}
