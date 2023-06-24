import { Component, Input } from '@angular/core';
import { Product, productList } from 'src/app/models/Product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {
  products: Product[] = [];
  @Input() admin?: boolean;

  /**
   * Products Component Constructor
   */
  constructor() {
    this.products = productList
  }
}
