﻿import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch'; 
import { IProduct } from "./products";

@Injectable()
export class ProductService {
    private _producturl = './product/GetProducts';
    constructor(private _http: Http) { }

    getproducts(): Observable<IProduct[]> {
        return this._http.get(this._producturl)
            .map((response: Response) => <IProduct[]>response.json())
            .catch(this.handleError); ;
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error());
    } 
}