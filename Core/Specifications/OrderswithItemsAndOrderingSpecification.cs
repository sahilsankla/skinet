
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderswithItemsAndOrderingSpecification: BaseSpecification<Order>
    {
        public OrderswithItemsAndOrderingSpecification(string email) : base(o=> o.BuyerEmail ==
        email)
        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.DeliveryMethod);
            AddOrderByDescending(o=> o.OrderDate);

        }
        public OrderswithItemsAndOrderingSpecification(int id, string email)
        : base(o => o.Id == id && o.BuyerEmail == email)
        {
         AddInclude(o => o.OrderItems);
         AddInclude(o => o.DeliveryMethod);   
        }
    }
}