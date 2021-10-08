import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WeatherForecast } from './weather-forecast';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicioEjemploService {

  private activo : boolean;
  private arrayClima: Array<WeatherForecast> = [];
  private url: string = "http://localhost:47594/WeatherForecast";

  constructor(private clienteHTTP: HttpClient) { 
    this.activo = false;
    let Observ: Observable<Array<WeatherForecast>>;
    Observ = this.clienteHTTP.get<Array<WeatherForecast>>(this.url);
    Observ.subscribe( (datos: Array<WeatherForecast>) => {this.arrayClima = datos});
  }

  public activar(activo: boolean) : void {
    this.activo = activo;
  }

  public siActivado() : boolean {
    return this.activo;
  }

  public climaArray() {
    return this.arrayClima;
  }
}
