import { Component, inject, signal } from '@angular/core';
import { CustomerService } from './customer-service';
import { ICustomerDto } from '../shared/models/customerDto';
import { httpResource } from '@angular/common/http';
import { CustomerModal } from './customer-modal/customer-modal';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-customer',
  imports: [CustomerModal],
  templateUrl: './customer.html',
  styleUrl: './customer.css',
})
export class Customer {
  private customerService = inject(CustomerService);
  private toastr = inject(ToastrService);
  // customers: ICustomerDto[] | null = null;
  customers = httpResource<ICustomerDto[]>(() => this.customerService.baseUrl + 'Customers');
  // customers = this.customerService.getCustomers();

  selectedCustomer = signal<ICustomerDto | null>(null);
  modalMode = signal<'view' | 'edit'>('view');

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

  viewCustomer(customer: ICustomerDto){
    this.selectedCustomer.set(customer);
    this.modalMode.set('view');
  }

  editCustomer(customer: ICustomerDto){
    this.selectedCustomer.set(customer);
    this.modalMode.set('edit');
  }

  closeModal(){
    this.selectedCustomer.set(null);
  }

  updateCustomer(customer: ICustomerDto){
    this.customerService.updateCustomer(customer.customerID, customer).subscribe({
      next: (response) => {
        this.toastr.success('Customer updated successfully!');
        this.customers; // refresh the table
        this.selectedCustomer.set(null); // close the modal
      },
      error:(error) => {
        this.toastr.error('Failed to update customer!');
        console.error(error);
      }
    });

    //     this.customerService.update(updated.id, updated).subscribe({
    //   next: () => {
    //     this.customers.reload();
    //     this.closeModal();
    //   },
    //   error: (err) => console.error(err),
    // });

  }

}
