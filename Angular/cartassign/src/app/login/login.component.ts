import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
errmsg:string;
uname:string;
pwd:string;
  constructor(private route:Router) { 

  }

  ngOnInit() {
  }
public Validate()
{
  if(this.uname=="chandu"&&this.pwd=="12345")
  {
    //set value in session
    sessionStorage.setItem("un",this.uname)
    this.route.navigateByUrl('buyer')
    
  }
  else if(this.uname=="chandus"&&this.pwd=="123456")
  {
    sessionStorage.setItem("un",this.uname)
    this.route.navigateByUrl('seller')
  }
  else if(this.uname=="chanduss"&&this.pwd=="1234567")
  {
    sessionStorage.setItem("un",this.uname)
    this.route.navigateByUrl('admin')
  }
  else{
    this.errmsg="Invalid Login Details";
  }
}
}
