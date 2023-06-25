import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private httpClient:HttpClient) { }
  baseURl:string = "http://localhost:3005/products";
  getAllProducts(){
    return this.httpClient.get(this.baseURl);
  }
  getProductById(productId:any){
    return this.httpClient.get(`${this.baseURl}/${productId}`);
  }
  addProduct(product:any){
    return this.httpClient.post(this.baseURl,product);
  }
  editProduct(productId:any,product:any){
    return this.httpClient.put(`${this.baseURl}/${productId}`,product);
  }
  deleteProduct(productId:any){
    return this.httpClient.delete(`${this.baseURl}/${productId}`);
  }

}
