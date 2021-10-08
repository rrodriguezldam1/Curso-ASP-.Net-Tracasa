import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bindings',
  template: 
    `
      <p>¡trozo-web funciona!</p>
      <p>Mostrando valor propiedad con interpolación (variable interpolada)</p>
      {{ (10 + 5) + propiedadClase}}
    `
})
export class BindingsComponent implements OnInit {

  propiedadClase: string;

  constructor() { 
    this.propiedadClase = "...";
  }

  ngOnInit(): void {}
}
