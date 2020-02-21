import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/Models/customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {
   item:Customer
   url:"www.google.com"
  constructor() { 
    this.item=new Customer();
    this.item.Cname="Chandu";
    this.item.City="Chennai";
    this.item.Address="Perungudi";
    this.item.Email="chandini@gmail.com";
    this.item.Mobile=9848022338;
  }

  ngOnInit() {
  }

}
