import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Customer } from '../../Customer';
import { CustomerInfoService } from '../../customer-info.service';


@Component({
  selector: 'app-customer-form',
  templateUrl: './customer-form.component.html',
  styleUrl: './customer-form.component.css'
})
export class CustomerFormComponent implements OnInit {

  customerForm: FormGroup = this.fb.group({
    customerId: [0],
    firstName: [''],
    lastName: [''],
    phoneNumber: [''],
    address: [''],
    email: [''],

  });

  constructor(private fb: FormBuilder, private data: CustomerInfoService) {

  }

  ngOnInit(): void {

  }

  onSubmit() {
    console.log(this.customerForm.value);

    let customer: Customer = {
      customerId: 0,
      firstName: this.customerForm.get('firstName')?.value,
      lastName: this.customerForm.get('lastName')?.value,
      phoneNumber: this.customerForm.get('phoneNumber')?.value,
      address: this.customerForm.get('address')?.value,
      email: this.customerForm.get('email')?.value,

    }
    this.data.createCustomer(customer);
    this.customerForm.reset();
  }

}
