import { Component, effect, inject, OnInit, signal, Signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavBar } from "./core/nav-bar/nav-bar";
import { NgxSpinnerComponent } from 'ngx-spinner';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavBar, NgxSpinnerComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {

  constructor() {}

  ngOnInit(): void {}
  
}
