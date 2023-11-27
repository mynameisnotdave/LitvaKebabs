using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public class OrderService
    {
        private ILiteCollection<Order> _orderTable;

        public OrderService()
        {
            LiteDatabase database = new LiteDatabase(@"./mydatabase1");
            _orderTable = database.GetCollection<Order>("Orders");
        }

        public Order GetOrder(int id)
        {
            return _orderTable.Query().Where(x => x.Id == id).First();
        }

        public void UpdateOrder(Order order)
        {
            _orderTable.Update(order);
        }

        public void DeleteOrder(int id)
        {
            _orderTable.Delete(id);
        }
    }
}