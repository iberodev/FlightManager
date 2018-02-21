import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    public airports: Airport[];
    public flightNew: FlightNew;

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        this.flightNew = this.getDefaultFlight();
        http.get(baseUrl + 'api/airports').subscribe(result => {
            this.airports = result.json() as Airport[];
        }, error => console.error(error));
    }
    
    private getDefaultFlight(): FlightNew {
        let flightNew: FlightNew = {
            reference: '',
            departureAirportCode: '',
            arrivalAirportCode: '',
        };
        return flightNew;
    }

    public onSubmit(): void {
        this.http.post(this.baseUrl + 'api/flights', this.flightNew).subscribe(result => {
            this.flightNew = this.getDefaultFlight();
            alert('Flight with reference ' + this.flightNew.reference + ' added successfully');
        }, error => console.error(error));
    }
}

