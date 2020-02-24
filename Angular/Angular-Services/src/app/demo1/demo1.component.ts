import { Component, OnInit } from '@angular/core';
import { ItemService } from '../services/item.service';
import { Item } from '../item';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
list:Item[]=[];
  constructor(private item:ItemService) { }

  ngOnInit() {
    this.item.GetAll().subscribe(res=>
      {
      this.list=res;
      console.log(this.list);
    },err=>{
      console.log(err);
    }
    )
  }

}
