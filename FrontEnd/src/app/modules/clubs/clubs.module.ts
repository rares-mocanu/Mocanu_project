import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClubsRoutingModule } from './clubs.routing.module';
import {MatTableModule} from '@angular/material/table';
import{MatInputModule} from '@angular/material/input';
import { ListComponent } from './list/list.component';
import{MatFormFieldModule} from '@angular/material/form-field';
import { AddComponent } from './add/add.component';
import {ReactiveFormsModule } from '@angular/forms';
import { ClubComponent } from './club/club.component';
import{MatSelectModule} from '@angular/material/select';
@NgModule({
  declarations: [
    ListComponent,
    AddComponent,
    ClubComponent
  ],
  imports: [
    CommonModule,
    ClubsRoutingModule,
    MatTableModule,
    MatInputModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatSelectModule
  ]
})
export class ClubsModule { }
