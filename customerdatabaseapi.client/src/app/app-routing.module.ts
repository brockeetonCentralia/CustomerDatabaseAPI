import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerFormComponent } from './CustomerInfo/customer-form/customer-form.component';
import { AppComponent } from './app.component';
import { CustomerInfoComponent } from './CustomerInfo/customer-info/customer-info.component';


export const routes: Routes = [
  { path: '', component: AppComponent },
  { path: 'customer/list', component: CustomerInfoComponent },
  { path: 'customer/new', component: CustomerFormComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
