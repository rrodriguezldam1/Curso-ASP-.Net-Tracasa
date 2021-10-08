import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-if-else',
  templateUrl: './if-else.component.html',
  styleUrls: ['./if-else.component.css']
})
export class IfElseComponent implements OnInit {

  static contadorEstatico: number = 0;
  contadorComp = 0;

  constructor() {
      this.contadorComp = 1;
   }

  ngOnInit(): void {
    IfElseComponent.contadorEstatico ++;
  }

  alPulsarBoton() : void {
    this.contadorComp ++;
  }
}
