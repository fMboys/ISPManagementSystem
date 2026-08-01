import { Component, input, output } from '@angular/core';
import { ICustomerDto } from '../../shared/models/customerDto';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-customer-modal',
  imports: [FormsModule],
  templateUrl: './customer-modal.html',
  styleUrl: './customer-modal.css',
})
export class CustomerModal {
  customer = input.required<ICustomerDto>();
  mode = input<'view' | 'edit'>('view');
  close = output<void>();
  save = output<ICustomerDto>();  

  //TODO: Implement Save/update functionality funtion
  onSave(form : NgForm){
    if (form.invalid) {
      Object.values(form.controls).forEach(control => control.markAsUntouched());
      return; // did not emit if the form is not valid
    }

    const updatedCustomer: ICustomerDto = {
      ...this.customer(),
      ...form.value,
    };

    this.save.emit(updatedCustomer);
  }
}
