import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SelectComponent } from './select/select.component';
import { LandingRoutingModule } from './landing.routing.module';
import { LoginComponent } from './login/login.component';



@NgModule({
  declarations: [
    SelectComponent,
    LoginComponent
  ],
  imports: [
    CommonModule,
    LandingRoutingModule
  ]
})
export class LandingModule { }
