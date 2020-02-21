import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-seller',
  templateUrl: './seller.component.html',
  styleUrls: ['./seller.component.css']
})
export class SellerComponent implements OnInit {

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
