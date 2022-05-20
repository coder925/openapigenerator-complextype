import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BASE_PATH, PersonApiModule } from './person-api';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    PersonApiModule,

  ],
  providers: [ { provide: BASE_PATH, useValue: 'https://localhost:7114' } ],
  bootstrap: [AppComponent]
})
export class AppModule { }
