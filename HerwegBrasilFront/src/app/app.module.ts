import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from './App-routing.module';
import { EnderecoComponent } from './pages/endereco/endereco.component';




@NgModule({
  declarations: [
    AppComponent,
    EnderecoComponent,
    

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    CommonModule,
    AppRoutingModule,
    EnderecoComponent,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
