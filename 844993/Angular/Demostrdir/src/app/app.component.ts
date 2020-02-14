import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Demostrdir';
  Customer:any[]=[{"name":'Raj',"country":'India',"Age":21},
  {"name":'Ram',"country":'Canada',"Age":22},
  {"name":'Ravi',"country":'India',"Age":23}];
  StudentCountry:any[]=[{"country":"India","student":[{"name":"Jay","age":23},{"name":"Rani","age":21}]},
  {"country":"Canada","student":[{"name":"chandu","age":21},{"name":"sd","age":21}]}]
}
