import { Component } from '@angular/core';
import { IProduct } from "./products";
import { ProductService } from './products.service';
import 'rxjs/add/operator/map';

@Component({
    selector: 'Product',
    templateUrl: './product.html',
    providers: [ProductService]
})

export class AppProduct {
    iproducts: IProduct[];
    constructor(private _product: ProductService) {
    }

    ngOnInit(): void {
        this._product.getproducts()
            .subscribe(iproducts => this.iproducts = iproducts);
    }
}