using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public interface ICustomerService
    {
        public abstract Task AddCustomerAsync(Customer customer);

        public void UpdateCustomer(Customer customer);

        public abstract Task DeleteCustomerAsync(Customer customer);

        public abstract Task<List<Customer>> GetAllCustomersAsync(Customer customer);

        public abstract Task<Customer> GetCustomerAsync(int customerId);
    }
}
