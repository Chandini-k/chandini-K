import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
    item:Student
    url:"www.google.com"
  constructor() { 
   this.item=new Student();
   this.item.Sid=1;
   this.item.Sname="Chandu";
   this.item.Standard="II";
   this.item.Age=21;
   this.item.DOB=new Date(1998,4,22);  
  }

  ngOnInit() {
  }

}
