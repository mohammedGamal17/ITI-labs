import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/Services/product.service';
// import { productList } from 'src/app/productlist';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit{
products:any = [];

constructor(private service:ProductService){}
  ngOnInit(): void {
    this.service.getAllProducts().subscribe({
      next:(response) => {
        this.products=response;
      }
    });
  }
  deleteProduct(PId:any){
    if (confirm(`Are you sure to delete product`)) {
      this.service.deleteProduct(PId).subscribe(() => {
        this.products=this.products.filter((p:any) => p.id != PId);
      });
      console.log('deleted');
    }
  }

}
