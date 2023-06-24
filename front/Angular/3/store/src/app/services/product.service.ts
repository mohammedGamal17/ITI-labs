import { Injectable } from '@angular/core';
import { productList, Product } from '../models/Product';
import { IProduct } from '../models/IProduct';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor() {}

  public getAllProducts(): IProduct[] {
    return productList;
  }

  public getProductById(id: number): Product {
    return this.getAllProducts().filter((p) => Number(p.id) === Number(id))[0];
  }
}
