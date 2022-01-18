import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { AddComponent } from './add/add.component';
import { AuthGuard } from 'src/app/auth.guard';
import { ClubComponent } from './club/club.component';
import { ClubService } from 'src/app/services/club.service';

const routes: Routes = [
    {
      path: '',
      component: ListComponent,
    },
    {
      path:'add',
      canActivate:[AuthGuard],
      component:AddComponent
    },
    {
      path:'club/:id',
      component:ClubComponent
    }
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class ClubsRoutingModule { }
  