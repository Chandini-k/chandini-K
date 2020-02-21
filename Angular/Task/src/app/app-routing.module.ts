import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddtaskComponent } from './addtask/addtask.component';
import { ViewTaskComponent } from './view-task/view-task.component';


const routes: Routes = [
  {path:'addtask',component:AddtaskComponent},
  {path:'viewtask',component:ViewTaskComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
