import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerInfoComponent } from './CustomerInfo/customer-info/customer-info.component';
import { CustomerInfoService } from './customer-info.service';
import { CustomerFormComponent } from './CustomerInfo/customer-form/customer-form.component';

@NgModule({
  declarations: [
    AppComponent,
    CustomerInfoComponent,
    CustomerFormComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [
    CustomerInfoService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
