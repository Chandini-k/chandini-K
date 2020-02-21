import { Component, OnInit } from '@angular/core';
import {FormBuilder,FormGroup,Validators} from '@angular/forms';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
productform:FormGroup;
submitted=false;
  constructor(private frombuilder:FormBuilder) { 

  }

  ngOnInit() {
    this.productform=this.frombuilder.group({
      productid:['',Validators.required],
      productname:['',Validators.required],
      price:['',Validators.required],
      stock:['',Validators.required]
    })
  }
  onSubmit()
  {
   this.submitted=true;
   if(this.productform.invalid)
   {
     return;
   }
   else{
     alert("Form is Validated");
   //console.log(this.loginForm.value["uname"])
    //console.log(this.loginForm.value["pwd"])
  
   }
  }
  //convenience getter for easy access to form fields
  get f(){return this.productform.controls;}
  onReset()
  {
    this.submitted=false;
    this.productform.reset();
  }
}
