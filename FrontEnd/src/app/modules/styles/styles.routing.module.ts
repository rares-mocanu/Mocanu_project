import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { StyleListComponent } from './style-list/style-list.component';


const routes: Routes = [
  {
      path: '',
      component: StyleListComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StylesRoutingModule { }
