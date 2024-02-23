import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CustomerInfoService } from '../../customer-info.service';
import { Customer } from '../../Customer';

@Component({
  selector: 'app-customer-info',
  templateUrl: './customer-info.component.html',
  styleUrl: './customer-info.component.css'
})
export class CustomerInfoComponent implements OnInit {

  customerList: Customer[] = [];
  constructor(private http: HttpClient, private service: CustomerInfoService) { }

  ngOnInit() {
    this.customerList.getAllCustomers().subscribe(data => {
      this.customerList = data;
    });
  }
}
