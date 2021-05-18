import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CartService {

constructor() { }

cartContent: Array<any> = [];


addToCart(product: any){
  this.cartContent.push(product)
}

printCart(){
  console.log(this.cartContent)
}
getItems(){
  return this.cartContent;
}
}
