import { Component, Input } from '@angular/core';
import { Product, productList } from '../../models/Product';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent {
  products: Product[] = [];
  @Input() admin?: boolean;

  /**
   * Slider Component Constructor
   */
  constructor() {
    this.products = productList;

  }
}
