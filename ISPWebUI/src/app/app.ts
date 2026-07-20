import { Component, effect, inject, OnInit, signal, Signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavBar } from "./core/nav-bar/nav-bar";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavBar],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  protected readonly title = signal('ISP Management System');

  constructor() {}

  ngOnInit(): void {}
  
}
