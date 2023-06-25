import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup,Validators} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/Services/product.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {
  productId:any;
  product:any;
  constructor(private ar:ActivatedRoute, private service:ProductService, private r:Router){}
  ngOnInit(): void {
     this.productId = this.ar.snapshot.paramMap.get('id');
     if (this.productId != 0) {
      this.service.getProductById(this.productId).subscribe({
        next:(response) =>{

          this.product=response;
          this.getProductName.setValue(this.product.ProductName);
          this.getPrice.setValue(this.product.Price);
          this.getQuantity.setValue(this.product.Quantity);
          this.productForm.controls['ImgUrl'].setValue(this.product.ImgUrl);
        }
      })      
     }

  }
  productForm = new FormGroup({
    ProductName : new FormControl('',[Validators.required,Validators.minLength(3)]),
    Price : new FormControl('',[Validators.required]),
    Quantity : new FormControl('',[Validators.required]),
    ImgUrl : new FormControl("/assets/images/def.png")
  });

  get getProductName(){
    return this.productForm.controls['ProductName'];
  }
  get getPrice(){
    return this.productForm.controls['Price'];
  }
  get getQuantity(){
    return this.productForm.controls['Quantity'];
  }
  addProduct(e:any){
    e.preventDefault();
    if (this.productForm.status==='VALID') {
      if (this.productId == 0) {
        this.service.addProduct(this.productForm.value).subscribe();
        
      } else {
        console.log(this.product);
        console.log(this.productId);
        this.service.editProduct(this.productId,this.productForm.value).subscribe();
      }
      this.r.navigate(['/products'])
    } 
  }

}
