import { Component, OnInit } from '@angular/core';
import { NumberSymbol } from '@angular/common';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
no1:number;
no2:number;
result:number;
result1:number;
  constructor() { }

  ngOnInit() {
  }
public Add(val:number,val1:number)
{
 this.no1=val;
 this.no2=val1;
 this.result=Number(val)+Number(val1);
}
public Sub(val:number,val1:number)
{
 this.no1=val;
 this.no2=val1;
 this.result1=Number(val)-Number(val1);
}
}
