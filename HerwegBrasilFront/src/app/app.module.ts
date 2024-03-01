import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchBarComponent } from './search-bar/search-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    SearchBarComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    CommonModule,
    SearchBarComponent,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
