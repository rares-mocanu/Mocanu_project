import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StyleListComponent } from './style-list/style-list.component';
import{MatFormFieldModule} from '@angular/material/form-field';
import {MatTableModule} from '@angular/material/table';
import{MatInputModule} from '@angular/material/input';
import { StylesRoutingModule } from './styles.routing.module';


@NgModule({
  declarations: [
    StyleListComponent
  ],
  imports: [
    CommonModule,
    MatFormFieldModule,
    MatTableModule,
    MatInputModule,
    StylesRoutingModule
  ]
})
export class StylesModule { }
