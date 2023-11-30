using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public class OrderService : IOrderService
    {
        private ILiteCollection<Order> _orderTable;

        public OrderService()
        {
            using LiteDatabase database = new(@"Filename=./mydatabase1; Connection=shared");
            _orderTable = database.GetCollection<Order>("Orders");
        }

        public Order GetOrder(int id)
        {
            return _orderTable.Query().Where(x => x.Id == id).First();
        }

        public List<Order> GetAllOrders()
        {
            return _orderTable.Query().ToList();
        }

        public void UpsertOrder(Order order)
        {
            _orderTable.Upsert(order);
        }

        public decimal GetOrderPrice()
        {
            var price = _orderTable.Query()
                .Select(x => x.OrderPrice)
                .ToList();
            foreach (var item in price)
            {
                return item;
            }
            return 0;
        }

        public void DeleteOrder(int id)
        {
            _orderTable.Delete(id);
        }

        public bool OrderTableHasItems()
        {
            if (_orderTable.Count() == 0)
            {
                return false;
            }
            return true;
        }
    }
}