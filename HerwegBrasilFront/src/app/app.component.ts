import { HttpClient } from '@angular/common/http';
import { CUSTOM_ELEMENTS_SCHEMA, Component, Inject, OnInit } from '@angular/core';
import { inject } from '@angular/core/testing';
import { RouterOutlet } from '@angular/router';
import { Endereco } from './Models/Endereco';
import { Observable } from 'rxjs/internal/Observable';
import { CommonModule } from '@angular/common';
import { EnderecoComponent } from './pages/endereco/endereco.component';
import { EnderecoService } from './service/endereco.service';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppComponent implements OnInit {

  
  constructor(@Inject(HttpClient) private http: HttpClient) { }

  title = 'HerwegBrasilFront';
  
  
  ngOnInit(): void {
    
  }

  pesquisarEndereco() {
    
  }

  
}







function ok() {
    throw new Error('Function not implemented.');
}
