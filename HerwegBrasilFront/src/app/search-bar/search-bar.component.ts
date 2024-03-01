import { Component } from '@angular/core';
import { Observable, catchError, debounceTime, distinctUntilChanged, of, switchMap } from 'rxjs';
import { AddressSearchService } from '../Services/AddressSearchService';

@Component({
  selector: 'app-search-bar',
  standalone: true,
  imports: [],
  templateUrl: './search-bar.component.html',
  styleUrl: './search-bar.component.css'
})
export class SearchBarComponent {
  endereco$: Observable<any>;
  //private searchTerms = new Subject<string>();

  constructor(private addressSearchService: AddressSearchService) { }
/*
  search(term: string): void {
    this.searchTerms.next(term);
  }*/

  ngOnInit(): void {
    this.endereco$ = this.endereco$.pipe(
      debounceTime(300),
      distinctUntilChanged(),
      switchMap((term: string) => term ? this.addressSearchService.searchAddresses(term) : of([])),
      catchError(error => {
        console.error(error);
        return of([]);
      })
    );
  }
}

