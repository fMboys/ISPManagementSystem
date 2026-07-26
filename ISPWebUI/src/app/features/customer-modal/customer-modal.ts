import { Component, input, output } from '@angular/core';
import { ICustomerDto } from '../../shared/models/customerDto';
import { FormsModule } from '@angular/forms';

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
  onUpdate(form : any){

  }
}
