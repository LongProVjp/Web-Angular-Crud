import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ProvinceComponent}from 'src/app/province/province.component';
import {DistrictComponent}from 'src/app/district/district.component';

const routes: Routes = [
  {path:'province',component:ProvinceComponent},
  {path:'district',component:DistrictComponent},
  // { path: '', pathMatch: 'full', redirectTo: '/welcome' },
  // { path: 'welcome', loadChildren: () => import('./pages/welcome/welcome.module').then(m => m.WelcomeModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
