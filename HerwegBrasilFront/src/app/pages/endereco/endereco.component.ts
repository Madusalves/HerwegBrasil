import { Component, Inject } from '@angular/core';
import { Endereco } from '../../Models/Endereco';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-endereco',
  standalone: true,
  imports: [],
  templateUrl: './endereco.component.html',
  styleUrl: './endereco.component.css'
})
export class EnderecoComponent {
  constructor(@Inject(HttpClient) private http: HttpClient) { }

  title = 'HerwegBrasilFront';

  urlApi = 'https://localhost:7246';
  enderecos: Observable<Endereco[]> = new Observable<Endereco[]>();
  cep: string = '';
  ngOnInit(): void {
    this.pesquisarEndereco();
  }
    
  pesquisarEndereco() {
    if (this.cep) {
      this.enderecos = this.http.get<Endereco[]>(`${this.urlApi}/api/cep/v1/${this.cep}`);
    }
  }

}

export { Endereco };
