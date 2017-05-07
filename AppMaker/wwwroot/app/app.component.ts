import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { Http, Response, Headers } from '@angular/http';
declare var $: any;

@Component({
    selector: 'am-app',
    templateUrl: 'partial/appComponent'
})

export class AppComponent {

    public constructor(private router: Router, private titleService: Title, private http: Http) { }

    ngOnInit()
    {
        $.getScript('/lib/admin-lte/dist/js/app.js');
    }

    // wrapper to the Angular title service.
    public setTitle(newTitle: string) {
        this.titleService.setTitle(newTitle);
    }

    
}
