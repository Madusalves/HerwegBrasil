import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AddressSearchService {
  constructor(private http: HttpClient) { }

  searchAddresses(query: string): Observable<any> {
    return this.http.get('/api/addresses', { params: { query } });
  }
}
