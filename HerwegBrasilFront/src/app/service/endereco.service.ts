import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Endereco } from '../Models/Endereco';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EnderecoService {
  

  constructor(private http: HttpClient) { }
  urlApi = 'https://localhost:7246';
  //Api: GET /endereco
  pesquisarEndereco(cep: string): Observable<Endereco> {
    const url = `${this.urlApi}/api/cep/v1/${cep}`;

    return this.http.get<Endereco>(url);
  }
   
}
