import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs';

@Component({
    selector: 'report',
    templateUrl: './report.component.html'
})
export class ReportComponent {

    public flights: Flight[];

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        debugger;
        http.get(baseUrl + 'api/flights').subscribe(result => {
            this.flights = result.json() as Flight[];
        }, error => console.error(error));
    }
}