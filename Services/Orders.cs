using Repositories;

namespace Services
{
    public class Orders
    {
        public void getAllOrders()
        {
            var wwiContext = new WideWorldImportersContext();
            var orders = wwiContext.PurchaseOrders;

        }
        

    }
}