using Exercicis.Contracts.Domain.Orders;
using Exercicis.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Services
{
    public interface IOrderService
    {
        IEnumerable<AComanda> GetComandes(string refNumber, DateTime? quan);
        AComanda GetComanda(int id);
    }

    public class OrderService
    {
        private readonly OrderQuery _oq;

        public OrderService() { _oq = new OrderQuery(); }

        public IEnumerable<AComanda> GetComandes(string refNumber, DateTime? quan)
        {
            // TODO
            return null;
        }

        public AComanda GetComanda(int id)
        {
            return _oq.getComandaById(id);
        }
    }
}
