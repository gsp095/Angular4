import { Component } from '@angular/core';

@Component({
    selector: 'test',
    templateUrl: './UlLi.html'
})

export class TestUlLi {
    appTitle: string = '*NgFor test';
    appList: any[] = [{
            "ID": "1",
            "Name": "One"
        },

        {
            "ID": "2",
            "Name": "Two"
        }];

    appImgList: any[] = [{
            "ID": "1",
            "url": "../images/img.jpg"
        },

        {
            "ID": "2",
            "url": "../images/img.jpg"
        }, {
            "ID": "2",
            "url": "../images/img.jpg"
        }, {
            "ID": "2",
            "url": "../images/img.jpg"
        }
        , {
            "ID": "2",
            "url": "../images/img.jpg"
        }
        , {
            "ID": "2",
            "url": "../images/img.jpg"
        }
        , {
            "ID": "2",
            "url": "../images/img.jpg"
        }
        , {
            "ID": "2",
            "url": "../images/img.jpg"
        }];
}