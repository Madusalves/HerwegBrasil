import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EnderecoComponent } from './pages/endereco/endereco.component';


const routes: Routes = [
  { path: 'endereco', component: EnderecoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
