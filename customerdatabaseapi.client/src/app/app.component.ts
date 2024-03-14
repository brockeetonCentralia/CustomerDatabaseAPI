import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Customer } from './Customer';
import { CustomerInfoService } from './customer-info.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  constructor(private http: HttpClient, private service: CustomerInfoService) { }



  title = 'customerdatabaseapi.client';
}
