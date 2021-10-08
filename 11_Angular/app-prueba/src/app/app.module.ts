import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BindingsComponent } from './bindings/bindings.component';
import { FormsModule } from '@angular/forms';
import { DirectivasStructComponent } from './directivas-struct/directivas-struct.component';
import { IfElseComponent } from './if-else/if-else.component';
import { PropiedadesInputComponent } from './propiedades-input/propiedades-input.component';
import { UsoServicioComponent } from './uso-servicio/uso-servicio.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    BindingsComponent,
    DirectivasStructComponent,
    IfElseComponent,
    PropiedadesInputComponent,
    UsoServicioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
