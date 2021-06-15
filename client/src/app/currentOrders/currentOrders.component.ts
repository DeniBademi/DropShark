import { Component, OnInit } from "@angular/core";
import { OrderServiceService } from "../_services/OrderService.service";
import { MatGridListModule } from '@angular/material/grid-list';


@Component({
    selector: 'currentOrders',
    templateUrl: './currentOrders.component.html',
    styleUrls: ['./currentOrders.component.scss']
  })
  export class currentOrdersComponent implements OnInit {
    orders : any 

    constructor(
        private orderService : OrderServiceService
    ) {}
    
    ngOnInit(): void {
      this.orders = this.orderService.getOrders();
      console.log(this.orders);
    }

  }