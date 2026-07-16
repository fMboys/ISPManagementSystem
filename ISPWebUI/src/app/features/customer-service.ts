import { HttpClient } from '@angular/common/http';
import { inject, Service } from '@angular/core';
import { ICustomerDto } from '../shared/models/customerDto';

@Service()
export class CustomerService {
    private httpClient = inject(HttpClient);
    baseUrl = 'https://localhost:7091/api/';
    getCustomers() {
        return this.httpClient.get<ICustomerDto>(this.baseUrl + 'Customers');
    }
}
