import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, Input } from '@angular/core';
import { map } from 'rxjs/operators';
import { Order } from '../_models/Order';

@Injectable({
    providedIn: 'root'
  })
  
export class OrderServiceService {
    baseUrl = "https://localhost:5001/";
    brands: any
    types: any
    filters: any = {};
    sizes: any;
    pageSize: any = "12";
    totalPages: any = "100";
    currentPage: any = "1";
    typesLoaded: boolean;
    @Input() orderList: Order[];

  constructor(private http: HttpClient) { }

    getOrders() {
        this.http.get(this.baseUrl+'order/getAll', 
    {
      observe: 'response',
      params: new HttpParams()/*.set("pageNumber", this.currentPage)
                              .set("pageSize", this.pageSize)
                              .set("orderBy", this.filters.orderBy)
                              .set("filters", JSON.stringify(this.filters))
                              .set("direction", this.direction=="arrow_downward" ? "asc" : "desc")*/
    }).pipe(
      map((response: any) => {
        const types = response;
        return types;
      })
    ).subscribe(response => {

      this.typesLoaded=true;
      this.orderList = response.body;
      var pag = JSON.parse(response.headers.get("Pagination"))
      this.totalPages = String(pag["TotalItems"])
    }, error => {
      console.log(error.error);
    })
    }

}