import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/Services/product.service';
// import { IProduct } from 'src/app/iproduct';
// import { productList } from 'src/app/productlist';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
  router:Router;
  activatedRoute:ActivatedRoute;
  productId:any;
  product:any;
  // products = productList;
  // product:IProduct={
  //   id: 0,
  //   productName: '',
  //   Price: 0,
  //   quantity: 0
  // };


constructor(r:Router,ar:ActivatedRoute,private service:ProductService){
  this.router=r;
  this.activatedRoute=ar;
}
  ngOnInit(): void {
   this.productId = this.activatedRoute.snapshot.paramMap.get('id');
   this.service.getProductById(this.productId).subscribe({
    next:(respone) => {
      this.product = respone;
    },
    error:(e) =>{
      console.log(e);
    }
  });
  }
 
}
