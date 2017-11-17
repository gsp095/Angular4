import { Component } from '@angular/core';
import { Product } from "./products";

@Component({
    selector: 'product-form',
    templateUrl: './product-form.component.html'
})

export class ProductFormComponent {

   productmodel = new Product(1, 'iPhone x');
    onClickMe() {
        this.productmodel.productname = "Test Click";
    }
}