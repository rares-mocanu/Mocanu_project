import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',   
        loadChildren: () => import('src/app/modules/landing/landing.module').then(m => m.LandingModule),
  },
  {
    path: 'clubs',
    loadChildren: () => import('src/app/modules/clubs/clubs.module').then(m => m.ClubsModule),
  },
  {
    path: 'styles',
    loadChildren: () => import('src/app/modules/styles/styles.module').then(m => m.StylesModule),
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
