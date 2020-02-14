import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component implements OnInit {
list:Student[]=[];
sid:number;
sname:string;
age:number;
std:string;
item:Student;
stds:string[]=["I","II","III","IV"];
val:boolean=true;
  constructor() {
    this.list=[
      {sid:1,sname:'Chandu',std:'II',age:21},
      {sid:2,sname:'Yash',std:'III',age:22},
      {sid:3,sname:'Sanj',std:'IV',age:25},
      {sid:4,sname:'Bhagya',std:'I',age:21},
      {sid:5,sname:'Karan',std:'II',age:10},
    ]
   }

  ngOnInit() {
  }
public Add()
{
  this.item=new Student();
  this.item.sid=this.sid;
  this.item.sname=this.sname;
  this.item.std=this.std;
  this.item.age=this.age;
  this.list.push(this.item);//add item to array
  console.log(this.list);
}
public Setval()
{
  this.val=!this.val;
}
}
