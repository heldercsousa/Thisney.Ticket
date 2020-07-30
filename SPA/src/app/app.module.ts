import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { BlockUIModule } from "ng-block-ui";
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { EventSearchComponent } from './event/event-search/event-search.component';
import { EventDetailComponent } from './event/event-detail/event-detail.component';
import { EventTicketComponent } from './event/event-ticket/event-ticket.component';
import { ResourceNotFoundComponent } from './resource-not-found/resource-not-found.component';

@NgModule({
  declarations: [
    AppComponent,
    EventSearchComponent,
    EventDetailComponent,
    EventTicketComponent,
    ResourceNotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BlockUIModule.forRoot({
      delayStart: 500,
      delayStop: 500,
      message: "Aguarde..."
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
