import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/Models/login';

@Component({
  selector: 'app-assign',
  templateUrl: './assign.component.html',
  styleUrls: ['./assign.component.css']
})
export class AssignComponent implements OnInit {
  item:Login
  constructor() { 
    this.item=new Login();
    console.log(this.item);

  }

  ngOnInit() {
  }
public onclick()
{
  if(this.item.uname=="admin"&& this.item.pwd=='12345')
  {
     console.log("Login Success");
  }
  else
  {
    console.log("Login Failed");
  }
  console.log(this.item);
}
}
