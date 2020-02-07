import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FirstPageComponent } from './myDemo/first-page.component';
import { SecondPageComponent } from './myDemo/second-page.component';
import { AppComponent } from './app.component';

const appRoutes:Routes=[
  {path:"secondpage",component:SecondPageComponent},
  {path:"firstpage",component:FirstPageComponent},
  {path:" ",redirectTo:"/firstpage",pathMatch:'full'}
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
})
export class AppRoutingModule { }
