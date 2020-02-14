import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'my-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {
firstname:string="Raj";
lastname:string="T";
Email:string="raj@cts.com";
Age:number=21;
getStyle():string{
  let styles="{font-style:italic,color:brown}";
  return styles;
}
onClick()
{
  console.log("You clicked");
}
}
