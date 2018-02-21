import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    public airportsDeparture: Airport[];
    public airportsArrival: Airport[];

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        http.get(baseUrl + 'api/airports').subscribe(result => {
            debugger;
            this.airportsDeparture = result.json() as Airport[];
            this.airportsArrival = result.json() as Airport[];
        }, error => console.error(error));
    }
}

