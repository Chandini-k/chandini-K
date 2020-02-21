import { Component, OnInit } from '@angular/core';
import {FormBuilder,FormGroup,Validators} from '@angular/forms';
import { Emp } from '../emp';
@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  list:Emp[]=[];
employeeForm:FormGroup;
submitted=false;
item:Emp;
  constructor(private frombuilder:FormBuilder) {
  }

  ngOnInit() {
    this.employeeForm=this.frombuilder.group({
      ID:['',[Validators.required,Validators.pattern("^[E][0-9]{4}$")]],
      Name:['',[Validators.required,Validators.pattern("^[A-Z]{0,}$")]],
      JoinDate:['',Validators.required],
      Designation:['',Validators.required],
      Mobile:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
      EmailId:['',Validators.required],
      Password:['',[Validators.required,Validators.pattern("^[A-Za-z]{7}[!@#$%^&*]")]]
    });
  }
 
onSubmit(){
  this.submitted=true;
  if(this.employeeForm.invalid){
   return;
  }
    else{
      this.item=new Emp();
    this.item.ID=this.employeeForm.value["ID"];
    this.item.Name=this.employeeForm.value["Name"];
    this.item.JoinDate=new Date(this.employeeForm.value["JoinDate"]);
    this.item.Designation=this.employeeForm.value["Designation"];
    this.item.Mobile=this.employeeForm.value["Mobile"];
    this.item.EmailId=this.employeeForm.value["EmailId"];
    this.item.Password=this.employeeForm.value["Password"];
    this.list.push(this.item)
    }
  }
  get f(){return this.employeeForm.controls;}
  onReset()
  {
    this.submitted=false;
    this.employeeForm.reset();
  }
}


