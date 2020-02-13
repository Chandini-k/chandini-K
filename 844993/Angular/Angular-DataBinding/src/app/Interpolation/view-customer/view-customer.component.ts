import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/Models/customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {
  obj:Customer
  constructor() { 
    this.obj={Cname:'Chandu',Email:'chandini@gmail.com',Mobile:984242452,City:'Chennai',Address:'Perungudi'}
  }

  ngOnInit() {
  }

}
