import { Component, inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators, ɵInternalFormsSharedModule } from '@angular/forms';
import { TextInput } from "../../../shared/text-input/text-input";

@Component({
  selector: 'app-signup',
  imports: [TextInput, ɵInternalFormsSharedModule, ReactiveFormsModule, FormsModule],
  templateUrl: './signup.html',
  styleUrl: './signup.css',
})
export class Signup implements OnInit {
  private formBuilder =  inject(FormBuilder);
  signupForm!: FormGroup;

  ngOnInit(): void {
    this.createSignupForm();
  }

  createSignupForm() {
    this.signupForm = this.formBuilder.group({
      name: [null, [Validators.required]],
      email: [null, [Validators.email, Validators.required]], // /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/
      password: [null, [Validators.required]]
    });
  }

  onSubmit() {
    console.log(this.signupForm.value); // This should be replaced with API call.
  }
}
