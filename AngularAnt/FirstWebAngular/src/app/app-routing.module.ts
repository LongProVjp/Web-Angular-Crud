import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ShowProvinceComponent } from 'src/app/show-province/show-province.component'

const routes: Routes = [
  {path:'',component:ShowProvinceComponent}
  // { path: '', pathMatch: 'full', redirectTo: '/welcome' },
  // { path: 'welcome', loadChildren: () => import('./pages/welcome/welcome.module').then(m => m.WelcomeModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
