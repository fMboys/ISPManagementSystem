import { NgClass } from '@angular/common';
import { Component, ElementRef, inject, Input, OnInit, Self, ViewChild } from '@angular/core';
import { ControlValueAccessor, NgControl, Validators } from '@angular/forms';
import { required } from '@angular/forms/signals';

@Component({
  selector: 'app-text-input',
  imports: [NgClass],
  templateUrl: './text-input.html',
  styleUrl: './text-input.css',
})
export class TextInput implements OnInit, ControlValueAccessor {
  @ViewChild('input', {static: true}) input!: ElementRef;
  @Input() type = 'text';
  @Input()
  label!: string;

  controlDir = inject(NgControl, {self: true}) // this 

  // constructor(@Self() public controlDir: NgControl) {// and this both or valid approaches but i'm using injectable bcz its newer...
  constructor(){
    this.controlDir.valueAccessor = this;
  }

  ngOnInit(): void {
    const control = this.controlDir.control;
    const validators = this.controlDir.validator ? [this.controlDir.validator] : []; // todo debug
    const asyncValidators = this.controlDir.asyncValidator ? [this.controlDir.asyncValidator] : []; // This is for API validators to check after request

    control?.setValidators([Validators.required]);
    control?.setAsyncValidators(asyncValidators);
    control?.updateValueAndValidity();
  }

  onChange(event : any): void {}
  onTouched() {}

  writeValue(obj: any): void {
    this.input.nativeElement.value = obj || '';
  }
  registerOnChange(fn: any): void {
    this.onChange = fn;
  }
  registerOnTouched(fn: any): void {
    this.onTouched = fn;
  }
}
