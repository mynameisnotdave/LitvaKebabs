using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public class OrderService
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