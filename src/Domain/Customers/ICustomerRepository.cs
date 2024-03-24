using ErrorOr;

namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
    Task<List<Customer>> GetAll();
    void Add(Customer customer);
    void Delete(Customer customer);
    Task<Boolean> ExistsAsync(CustomerId id);
    void Update(Customer customer);
}