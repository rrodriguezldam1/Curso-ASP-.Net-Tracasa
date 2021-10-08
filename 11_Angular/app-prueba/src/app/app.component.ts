import { Component } from '@angular/core';
import { ServicioEjemploService } from './servicio-ejemplo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{
  
  title = 'Prueba Angular';
  
  constructor(public srvEj: ServicioEjemploService) {
    this.title += " funcionando";
  }
}

