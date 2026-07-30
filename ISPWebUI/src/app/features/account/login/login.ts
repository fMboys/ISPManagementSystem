import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule, FormGroup, Validators, ɵInternalFormsSharedModule } from '@angular/forms';
import { JsonPipe } from '@angular/common';
import { TextInput } from "../../../shared/text-input/text-input";

@Component({
  selector: 'app-login',
  imports: [ɵInternalFormsSharedModule, ReactiveFormsModule, JsonPipe, TextInput],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  loginForm!: FormGroup;
  

  ngOnInit(): void {
    this.createLoginForm();
  }
  createLoginForm(): void {
    this.loginForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]), // using simple email validator but if need more specific use validators.pattern(regex expression)
      password: new FormControl('', Validators.required)
    });
  }

  onSubmit(): void {
    console.log(this.loginForm.value)
  }
}
