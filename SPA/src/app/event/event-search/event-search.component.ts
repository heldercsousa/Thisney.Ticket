import { Component, OnInit } from '@angular/core';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { EventService } from 'src/app/services/event.service';
import { EventModel } from 'src/app/models/event.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-event-search',
  templateUrl: './event-search.component.html',
  styleUrls: ['./event-search.component.css']
})
export class EventSearchComponent implements OnInit {
  @BlockUI() blockUI: NgBlockUI;
  constructor(private eventService: EventService,
    private router: Router,) { }

  public eventList: EventModel[] = [];
  public hover: boolean = false;
  title = 'Thisney Tickets';

  ngOnInit() {
    this.blockUI.start();
    this.eventService.getAll().subscribe(eventList => {
      this.blockUI.stop();
      this.eventList = [...eventList];
    }, err => {
      this.blockUI.stop();
    });
  }

  eventSelected(event: EventModel) {
    const id = event.id;
    this.router.navigate(['event', id]);
  }

}
