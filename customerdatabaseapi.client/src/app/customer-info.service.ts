import { Injectable } from '@angular/core';
import { Customer } from './Customer';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, ReplaySubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerInfoService {

  customersAll: BehaviorSubject<Customer[]> = new BehaviorSubject<Customer[]>([]);
  customersOne: BehaviorSubject<Customer | null> = new BehaviorSubject<Customer | null>(null);

  constructor(private http: HttpClient) { }

  createCustomer(newCustomer: Customer) {
    this.http.post<Customer>("/api/CustomerInfo", newCustomer).subscribe(data => {
      let list = this.customersAll.getValue();
      list.push(data);
      this.customersAll.next(list);
    });
  }

  getAllCustomers() {
    this.http.get<Customer[]>("/api/CustomerInfo").subscribe(data => {
      this.customersAll.next(data);
    });
  }

  getCustomerById(id: number) {
    this.http.get<Customer>("/api/CustomerInfo/" + id).subscribe(data => {
      this.customersOne.next(data);
    });
  }

  updateCustomer(id: number, newCustomer: Customer) {

  }

  deleteCustomer(id: number) {
    this.http.delete("/api/CustomerInfo/" + id).subscribe(data => {
      console.log("deleting", id, data);
      this.getAllCustomers();
    });
  }
}
