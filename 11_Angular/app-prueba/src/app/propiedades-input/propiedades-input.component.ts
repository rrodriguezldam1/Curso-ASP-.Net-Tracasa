import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-propiedades-input',
  templateUrl: './propiedades-input.component.html',
  styleUrls: ['./propiedades-input.component.css']
})
export class PropiedadesInputComponent implements OnInit {

  @Input()
  valorX: string = "0";
  @Input()
  valorY: string = "0";

  valorZ: string = "0";

  @Input()
  servicioActivado = "false";

  constructor() { }

  ngOnInit(): void {
  }

}
