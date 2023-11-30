using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public interface IOrderService
    {
        public Order GetOrder(int id);

        public List<Order> GetAllOrders();

        public void UpsertOrder(Order order);

        public decimal GetOrderPrice();

        public void DeleteOrder(int id);

        public bool OrderTableHasItems();
    }
}
