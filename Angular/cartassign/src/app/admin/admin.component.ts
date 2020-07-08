import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  constructor(private route:Router) { }

  ngOnInit() {
  }
  public Logout()
  {
    //clear session storage
    sessionStorage.clear();
    this.route.navigate(['login']);
    this.route.navigateByUrl('login');
  }
}