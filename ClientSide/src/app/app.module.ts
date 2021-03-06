import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavbarComponent } from './main-content/navbar/navbar.component';
import { RegisterComponent } from './main-content/register/register.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
