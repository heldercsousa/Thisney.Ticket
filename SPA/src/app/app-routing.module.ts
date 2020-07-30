import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ResourceNotFoundComponent } from './resource-not-found/resource-not-found.component';
import { EventSearchComponent } from './event/event-search/event-search.component';
import { EventDetailComponent } from './event/event-detail/event-detail.component';
import { EventTicketComponent } from './event/event-ticket/event-ticket.component';


const routes: Routes = [
  {
    path: 'not-found',
    component: ResourceNotFoundComponent
  },
  {
    path: '',
    component: EventSearchComponent
  },
  {
    path: 'event',
    component: EventSearchComponent
  },
  {
    path: 'event/:id',
    component: EventDetailComponent
  },
  {
    path: 'event/:id/ticket',
    component: EventTicketComponent
  },
  {
    path: '**',
    redirectTo: '/not-found'
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
