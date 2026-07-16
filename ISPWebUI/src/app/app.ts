import { Component, effect, inject, OnInit, signal, Signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavBar } from "./core/nav-bar/nav-bar";
import { Customer } from "./features/customer";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavBar, Customer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  protected readonly title = signal('ISPWebUI');

  constructor() {}

  ngOnInit(): void {}
  
}
