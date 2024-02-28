import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { inject } from '@angular/core/testing';
import { RouterOutlet } from '@angular/router';
import { Endereco } from './Models/Endereco';
import { Observable } from 'rxjs/internal/Observable';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  
  constructor(@Inject(HttpClient) private http: HttpClient) { }

  title = 'HerwegBrasilFront';
  
  urlApi = 'https://localhost:7246';
  enderecos$: Observable<Endereco[]> = new Observable<Endereco[]>();

  ngOnInit(): void {
    this.obterEndereco("37940000");
  }


  obterEndereco(cep: string) {
    this.enderecos$ = this.http.get<Endereco[]>(`${this.urlApi}/api/cep/v1/${cep}`);
  }
}






