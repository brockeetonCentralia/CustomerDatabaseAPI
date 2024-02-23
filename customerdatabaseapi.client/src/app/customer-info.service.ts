import { Injectable } from '@angular/core';
import { Customer } from './Customer';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerInfoService {

  constructor(private http: HttpClient) { }

  createCustomer(newCustomer: Customer) {

  }

  getAllCustomers(): Observable<Customer[]> {
    return this.http.get<Customer[]>("api/CustomerInfo");
  }

  getCustomerById(id: number) {

  }

  updateCustomer(id: number, newCustomer: Customer) {

  }

  deleteCustomer(id: number) {

  }
}
