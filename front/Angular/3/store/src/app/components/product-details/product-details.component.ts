import { Component, OnChanges, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product, productList } from '../../models/Product';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css'],
})
export class ProductDetailsComponent implements OnInit {
  productID?: number;
  product?: Product;
  constructor(private route: ActivatedRoute) {
    this.route.params.subscribe((params) => {
      this.productID = params['id'];
    });
  }
  ngOnInit(): void {
    this.product = getProduct(this.productID!);
  }
}

function getProduct(id: number): Product {
  return productList.filter((p) => Number(p.id) === Number(id))[0];
}
