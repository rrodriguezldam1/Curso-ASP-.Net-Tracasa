import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directivas-struct',
  templateUrl: './directivas-struct.component.html',
  styleUrls: ['./directivas-struct.component.css']
})
export class DirectivasStructComponent implements OnInit {

  arrayDeTextos: Array<string>;
  
  constructor() {
      this.arrayDeTextos = ["relleno", "cuajada", "tarta de cuajada", "bacalao ajoarriero"];
   }

  ngOnInit(): void {
  }

}
