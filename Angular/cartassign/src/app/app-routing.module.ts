import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { BuyerComponent } from './buyer/buyer.component';
import { SellerComponent } from './seller/seller.component';
import { AdminComponent } from './admin/admin.component';
import { AdditemComponent } from './seller/additem/additem.component';
import { ViewitemComponent } from './seller/viewitem/viewitem.component';
import { BuyitemComponent } from './buyer/buyitem/buyitem.component';
import { ViewcartComponent } from './buyer/viewcart/viewcart.component';
import { PaymentComponent } from './buyer/payment/payment.component';
import { AddCategoryComponent } from './admin/add-category/add-category.component';
import { AddRemoveBuyerComponent } from './admin/add-remove-buyer/add-remove-buyer.component';
import { AddRemoveSellerComponent } from './admin/add-remove-seller/add-remove-seller.component';


const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'buyer',component:BuyerComponent,children:[{path:'buyitem',component:BuyitemComponent},
{path:'viewcart',component:ViewcartComponent},{path:'payment',component:PaymentComponent}]},
  {path:'seller',component:SellerComponent,children:[{path:'additem',component:AdditemComponent},
{path:'viewitem',component:ViewitemComponent}]},
  {path:'admin',component:AdminComponent,children:[{path:'add-category',component:AddCategoryComponent},
{path:'add-remove-buyer',component:AddRemoveBuyerComponent},{path:'add-remove-seller',component:AddRemoveSellerComponent}]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
