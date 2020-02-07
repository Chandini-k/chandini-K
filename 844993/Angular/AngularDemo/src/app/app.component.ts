import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = '';
  num:number=20;
  imagepath:string='assets/images/Dora.jpg';
  name:string='Ram';
  lname:string='R';
  isdisabled:boolean=false;
  mystyle:string="boldclass italicclass";
  applyStyle:boolean=true;
  getname():string
  {
    this.name=this.name.toUpperCase();
    return this.name+" "+this.lname;
  }

}
