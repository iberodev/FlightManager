interface FlightNew {
    reference: string;
    departureAirportCode: string;
    arrivalAirportCode: string;
}

interface Flight {
    reference: string;
    departureAirportCode: string;
    arrivalAirportCode: string;
    distanceMetres: number;
    estimatedFuelConsumptionLitres: number;
}