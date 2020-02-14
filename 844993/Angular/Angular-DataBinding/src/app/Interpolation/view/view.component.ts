import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
  obj:Student
  constructor() { 
    this.obj={Sid:1,Sname:'Chandu',DOB:new Date(1998,4,22),Standard:'II',Age:21};
  }

  ngOnInit() {
  }

}
