import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo5',
  templateUrl: './demo5.component.html',
  styleUrls: ['./demo5.component.css']
})
export class Demo5Component implements OnInit {
items:any[]=[
  {name:'one',val:1},
  {name:'Two',val:2},
  {name:'Three',val:3}
];
selectedvalue:string="one";
  constructor() { }

  ngOnInit() {
  }

}
