import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { inject } from '@angular/core/testing';
import { RouterOutlet } from '@angular/router';
import { Endereco } from './Models/Endereco';
import { Observable } from 'rxjs/internal/Observable';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  ngOnInit(): void {
      
  }
  title = 'HerwegBrasilFront';
  http = Inject(HttpClient);
  urlApi = 'https://localhost:7246/';
  enderecos: Endereco[] = [];

  obterEndereco(cep: string): Observable<Endereco> {
 
    return this.http.get<Endereco>(`${this.urlApi}/api/cep/v1/${cep}`);
  }




}
