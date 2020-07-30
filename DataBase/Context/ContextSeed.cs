using Microsoft.EntityFrameworkCore;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.Database.Context
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostumerEntity>(x =>
            {
                x.HasData(
                    new CostumerEntity { Id = 1, Name = "Helder Carvalho de Sousa", CPF = "70535892187" },
                    new CostumerEntity { Id = 2, Name = "Glauber Carvalho de Sousa", CPF = "01234567890" }
                );
            });

            modelBuilder.Entity<EventEntity>(x =>
            {
                x.HasData(
                    new EventEntity { Id = 1, Title = "Megashow Pink Floyd", MaxPeopleCapacity = 35 },
                    new EventEntity { Id = 2, Title = "Circo du Solei", MaxPeopleCapacity = 3 },
                    new EventEntity { Id = 3, Title = "Show Sandy Junior", MaxPeopleCapacity = 9 },
                    new EventEntity { Id = 4, Title = "Show Jorge Mateus", MaxPeopleCapacity = 10 },
                    new EventEntity { Id = 5, Title = "Show Capital Inicial", MaxPeopleCapacity = 8 },
                    new EventEntity { Id = 6, Title = "Show Paralamas Sucesso", MaxPeopleCapacity = 6 },
                    new EventEntity { Id = 7, Title = "Show Carlinhos Brown", MaxPeopleCapacity = 7 },
                    new EventEntity { Id = 8, Title = "Megashow Madonna", MaxPeopleCapacity = 30 },
                    new EventEntity { Id = 9, Title = "Turnê Chitãozinho e Xororó", MaxPeopleCapacity = 11 },
                    new EventEntity { Id = 10, Title = "Harmozia do Samba", MaxPeopleCapacity = 5 }
                );
            });
        }
    }
}
