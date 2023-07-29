import { Component } from '@angular/core';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm!:FormGroup;
   
  constructor(private fb:FormBuilder,
    private authService: AuthService) {
    this.loginForm = this.fb.group({
      'username': ['', [Validators.required]],
      'password': ['', [Validators.required]]
    })
  }

  login() {
    this.authService.login(this.loginForm.value)
      .subscribe(data => {
        this.authService.saveToken(data['token']);
      })
  }

  get username() {
    console.log(this.loginForm.get('username'))
    return this.loginForm.get('username')
  }

  get password() {
    console.log(this.loginForm.get('password'))
    return this.loginForm.get('password')
  }
}