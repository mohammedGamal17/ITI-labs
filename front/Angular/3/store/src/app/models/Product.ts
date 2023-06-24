import { IProduct } from './IProduct';
export class Product implements IProduct {
  //#region Fields
  id: number;
  name: string;
  description: string;
  imageURL: string;
  price: number;
  quantity: number;

  //#endregion

  //#region Constructor
  /**
   * Product Constructor
   */
  constructor(
    _id: number,
    _name: string,
    _description: string,
    _imageURL: string,
    _price: number,
    _quantity: number
  ) {
    this.id = _id;
    this.name = _name;
    this.description = _description;
    this.imageURL = _imageURL;
    this.price = _price;
    this.quantity = _quantity;
  }
  //#endregion
}

export let productList: Product[] = [
  {
    id: 1,
    name: 'Mac',
    description: 'Macintosh',
    imageURL:
      'https://www.hardsoftcomputers.co.uk/wp-content/uploads/2023/03/mac.png',
    price: 1000,
    quantity: 2,
  },
  {
    id: 2,
    name: 'Samsung',
    description: 'Samsung Phone',
    imageURL:
      'https://img.global.news.samsung.com/in/wp-content/uploads/2022/03/SM-A536_Galaxy-A53-5G_Awesome-Peach_Front.jpg',
    price: 500,
    quantity: 3,
  },
  {
    id: 3,
    name: 'IPhone',
    description: 'Apple Mobile',
    imageURL:
      'https://m.media-amazon.com/images/I/71yzJoE7WlL._AC_UF1000,1000_QL80_.jpg',
    price: 500,
    quantity: 0,
  },
  {
    id: 4,
    name: 'TV',
    description: 'Television',
    imageURL:
      'https://cdn.webshopapp.com/shops/256009/files/374440369/xiaomi-xiaomi-mi-tv-p1-32-inch.jpg',
    price: 15000,
    quantity: 1,
  },
  {
    id: 5,
    name: 'PS5',
    description: 'Playstation Five',
    imageURL:
      'https://jawalplus.com/wp-content/uploads/2020/11/sony-ps5-digital-edition.jpg',
    price: 2500,
    quantity: 6,
  },
  {
    id: 6,
    name: 'Camera',
    description: 'Canon Camera',
    imageURL:
      'https://petapixel.com/assets/uploads/2022/09/canon-5d-mark-iv-dslr.jpg',
    price: 6000,
    quantity: 4,
  },
  {
    id: 7,
    name: 'Mac',
    description: 'Macintosh',
    imageURL:
      'https://www.hardsoftcomputers.co.uk/wp-content/uploads/2023/03/mac.png',
    price: 8080,
    quantity: 3,
  },
];
