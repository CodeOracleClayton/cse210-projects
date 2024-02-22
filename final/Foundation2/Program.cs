//Clayton Zulu - Foundation 02 Final Project

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("15 Maple St", "Santa Rosa Beach", "FL", "32459", "USA");
        Customer customer = new Customer("Nick McGravey", address);
        Order order = new Order(customer);

        Product product1 = new Product("IPhone", 15.99m, 2, 1);
        Product product2 = new Product("Samsung Galaxy", 21.99m, 1, 2);

        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total cost: {order.GetTotalPrice():C}");
    }
}