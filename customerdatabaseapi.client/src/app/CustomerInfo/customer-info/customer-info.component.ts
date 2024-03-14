import { HttpClient } from '@angular/common/http';
import { Component, OnInit, Input } from '@angular/core';
import { CustomerInfoService } from '../../customer-info.service';
import { Customer } from '../../Customer';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-customer-info',
  templateUrl: './customer-info.component.html',
  styleUrl: './customer-info.component.css'
})
export class CustomerInfoComponent {
  @Input() customer: Customer = {
    customerId: 0,
    firstName: '',
    lastName: '',
    phoneNumber: '',
    address: '',
    email: ''
  }

  constructor(private data: CustomerInfoService) {

  }

  

}
