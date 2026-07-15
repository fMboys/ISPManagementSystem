import { Component, effect, inject, OnInit, signal, Signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavBar } from "./nav-bar/nav-bar";
import { HttpClient } from '@angular/common/http';
import { toSignal } from '@angular/core/rxjs-interop';
import { ICustomer } from './models/customer';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavBar],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  protected readonly title = signal('ISPWebUI');
  private http = inject(HttpClient);

  //customer is a Signal<CustomerResponse>
  customers = toSignal<ICustomer[]>(this.http.get<ICustomer[]>('https://localhost:7091/api/Customers'), {
    initialValue: null
  });
  constructor() {
    effect(() => {
    console.log('customers signal:', this.customers());
  });
  }

  ngOnInit(): void {
    // this.http.get('https://localhost:7091/api/Customers').subscribe((response: any) => {
    //   this.customers = response;
    //   console.log('API Response:', this.customers);
    // })
  }
  
}
