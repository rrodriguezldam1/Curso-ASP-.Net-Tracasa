import { Component, OnInit } from '@angular/core';
import { ServicioEjemploService } from '../servicio-ejemplo.service';

@Component({
  selector: 'app-uso-servicio',
  templateUrl: './uso-servicio.component.html',
  styleUrls: ['./uso-servicio.component.css']
})
export class UsoServicioComponent implements OnInit {

  constructor(public srvEj: ServicioEjemploService) { }

  ngOnInit(): void {
  }

  activarPorSrv (): void {
    this.srvEj.activar(true);
  }
}
