import { Component, OnInit } from "@angular/core";
import { OrderServiceService } from "../_services/OrderService.service";
import { MatGridListModule } from '@angular/material/grid-list';
import { AccountServiceService } from "../_services/AccountService.service";
import { delay } from "rxjs/operators";


@Component({
    selector: 'currentOrders',
    templateUrl: './currentOrders.component.html',
    styleUrls: ['./currentOrders.component.scss']
  })
  export class currentOrdersComponent implements OnInit {
    orders : any 
  totalPages: string;
  completed: string = "false";

    constructor(
      public accountService : AccountServiceService,
        private orderService : OrderServiceService
    ) {}
    
    async ngOnInit() {
      await this.getOrders();
      // /this.orders = this.orderService.orderList;
      //console.log(this.orders);
    }

    async getOrders() {
     this.orderService.getOrders(this.completed).subscribe(response => {

      
      this.orders = response.body;
      console.log(this.orders)
      var pag = JSON.parse(response.headers.get("Pagination"))
      this.totalPages = String(pag["TotalItems"])
      console.log(this.orders);
      return this.orders;

    }, error => {
      console.log(error.error);
    })
      
      

    }

    refreshOrders(){
      this.orderService.getOrders("true").subscribe(response => {

      
        this.orders = response.body;
        console.log(this.orders)
        var pag = JSON.parse(response.headers.get("Pagination"))
        this.totalPages = String(pag["TotalItems"])
        console.log(this.orders);
        return this.orders;
  
      }, error => {
        console.log(error.error);
      });
      //this.getOrders();
    }

    changeOrders() {
      console.log("AAAAAAAA")
      if(this.completed == "false"){
        this.completed = "true"
      }
      else if(this.completed == "true"){
        this.completed = "false"
      }
      console.log(this.completed)
      this.ngOnInit()
    }

  }