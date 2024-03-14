import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Customer } from './Customer';
import { CustomerInfoService } from './customer-info.service';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {

  customerList: Customer[] = [];

  customers: Subject<Customer[]> = this.customer.customersAll;
  constructor(private customer: CustomerInfoService) { }

  ngOnInit() {
    this.customer.getAllCustomers();
  }

}
