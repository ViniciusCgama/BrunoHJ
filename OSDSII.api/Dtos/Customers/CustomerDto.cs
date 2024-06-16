using OsDsII.api.Dtos.ServiceOrders;

namespace OsDsII.api.Dtos.Customers
{
    public record CustomerDto(int Id, string Name, string Email, string Phone, List<ServiceOrderDto>? ServiceOrders)
    {
        public CustomerDto() : this(0, "", "", "", null) { }
    }
}