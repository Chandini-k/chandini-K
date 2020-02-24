import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../services/calculate.service';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {

  constructor(private service:CalculateService) { }

  ngOnInit() {
  }
  f()
  {
    console.log('Sub:'+this.service.Sub(12,2));
    console.log('Div:'+this.service.Div(12,2));
    console.log(+this.service.Greet('Sachin'));
  }
}
