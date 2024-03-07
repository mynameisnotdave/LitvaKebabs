
using LitvaKebabs.Models;
using Microsoft.EntityFrameworkCore;

namespace LitvaKebabs.Services
{
    public class CustomerService : ICustomerService
    {
        private LitvaKebabsContext _dbcontext;

        public CustomerService(LitvaKebabsContext dbcontext) 
        {
            _dbcontext = dbcontext;
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await _dbcontext.Customer.AddAsync(customer);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(Customer customer)
        {
            _dbcontext.Customer.Remove(customer);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllCustomersAsync(Customer customer)
        {
            List<Customer> customerList = await _dbcontext.Customer.ToListAsync();
            return customerList;
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            Customer customer = await _dbcontext.Customer.FindAsync(customerId) ?? new Customer();
            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            _dbcontext.Customer.Update(customer);
            _dbcontext.SaveChanges();
        }
    }
}
