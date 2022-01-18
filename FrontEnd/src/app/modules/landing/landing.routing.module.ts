import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { SelectComponent } from './select/select.component';


const routes: Routes = [
    {
      path: 'landing',
      component: SelectComponent,
    },
    {
        path: '',
        component: LoginComponent
    }
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class LandingRoutingModule { }
  