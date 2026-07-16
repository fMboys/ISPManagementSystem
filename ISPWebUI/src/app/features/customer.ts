import { Component, inject } from '@angular/core';
import { CustomerService } from './customer-service';
import { ICustomerDto } from '../shared/models/customerDto';
import { httpResource } from '@angular/common/http';

@Component({
  selector: 'app-customer',
  imports: [],
  templateUrl: './customer.html',
  styleUrl: './customer.css',
})
export class Customer {
  private customerService = inject(CustomerService);
  // customers: ICustomerDto[] | null = null;
  customers = httpResource<ICustomerDto[]>(() => this.customerService.baseUrl + 'Customers');

  ngOnInit() {

    // this.customerService.getCustomers().subscribe((response: ICustomerDto[]) => {
    //   console.log('API Response:', response);
    //   this.customers = response;
    // });

    //   deleteCustomer(id: number) {
    // this.customerService.delete(id).subscribe({
    //   next: () => this.customers.reload(),
    //   error: (err) => console.error(err)
    // });

  }
}
