import { TicketModel } from './ticket.model';

export class CostumerModel {
  id: number;
  cpf: string;
  name: string;
  ticket: TicketModel[];
}
