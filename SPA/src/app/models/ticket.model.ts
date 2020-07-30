import { CostumerModel } from './costumer.model';
import { EventModel } from './event.model';

export class TicketModel {
  id: number;
  eventId: number;
  shippingDate: Date;
  saleDate: Date;
  costumerId: number;
  costumer: CostumerModel;
  event: EventModel;
}
