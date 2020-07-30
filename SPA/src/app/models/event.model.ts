import { TicketModel } from './ticket.model';

export class EventModel {
  id: number;
  title: string;
  ticket: TicketModel[];
}
