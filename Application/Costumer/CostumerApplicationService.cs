using System.Collections.Generic;
using System.Threading.Tasks;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.DataBase.Infra;
using Thisney.Ticket.Domain;
using Thisney.Ticket.Mapping;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Application.Costumer
{
    public class CostumerApplicationService : ICostumerApplicationService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IRepository<CostumerEntity> _costumerRepository;

        public CostumerApplicationService(IUnityOfWork unityOfWork,
            IRepository<CostumerEntity> costumerRepository)
        {
            _unityOfWork = unityOfWork;
            _costumerRepository = costumerRepository;
        }

        public async Task<CostumerModel> GetByIdAsync(int id)
        {
            var costumerEntity = await _costumerRepository.GetByIdAsync(id);
            CostumerModel costumerModel = costumerEntity?.Project<CostumerEntity,CostumerModel>();
            return costumerModel;
        }

        public async Task<IEnumerable<CostumerModel>> GetAllAsync()
        {
            var costumerEntities = await _costumerRepository.GetAllAsync();
            IEnumerable<CostumerModel> costumerModels = costumerEntities?.Project<CostumerEntity,CostumerModel>();
            return costumerModels;
        }

    }
}
