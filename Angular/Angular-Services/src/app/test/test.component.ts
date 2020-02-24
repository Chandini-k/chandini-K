import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../services/calculate.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor(private service:CalculateService) { }

  ngOnInit() {
    console.log('Addition:'+this.service.Add(12,24));
    console.log('Mul:'+this.service.Mul(12,2));
    console.log(this.service.Greet('chandu'));
    console.log('Sub:'+this.service.Sub(12,2));
    console.log('Div:'+this.service.Div(12,2));
  }
  f()
  {
    console.log(+this.service.Greet('Sachin'));
  }

}
