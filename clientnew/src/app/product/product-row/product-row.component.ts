import { Component, HostBinding, Input, OnInit } from '@angular/core';
import { Product } from 'src/app/_models/Product';

@Component({
  selector: 'app-product-row',
  templateUrl: './product-row.component.html',
  styleUrls: ['./product-row.component.scss']
})
export class ProductRowComponent implements OnInit {
  @Input() product: Product
  @HostBinding('attr.class') cssCLass = 'item'
  constructor() { }

  ngOnInit() {
    console.log('a')
  }

}
