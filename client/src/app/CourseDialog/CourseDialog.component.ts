import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog/';
import { CartService } from '../_services/Cart.service';
import {MAT_DIALOG_DATA} from "@angular/material/dialog";
@Component({
  selector: 'app-CourseDialog',
  templateUrl: './CourseDialog.component.html',
  styleUrls: ['./CourseDialog.component.css']
})
export class CourseDialogComponent implements OnInit {

  constructor(private cartService: CartService,
    private dialogRef: MatDialogRef<CourseDialogComponent>,
    ) { }

  cart: any;
  ngOnInit() {
    this.cart=this.cartService.getItems()
  }

  save() {
    //this.dialogRef.close(this.form.value);
}

close() {
    this.dialogRef.close();
}
}
