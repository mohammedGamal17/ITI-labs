import { Component, Input, OnInit } from '@angular/core';
import { Product, productList } from 'src/app/models/Product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];
  @Input() admin?: boolean;

  /**
   * Products Component Constructor
   */
  constructor(private productService: ProductService) {}
  ngOnInit(): void {
    this.products = this.productService.getAllProducts();
  }
}
