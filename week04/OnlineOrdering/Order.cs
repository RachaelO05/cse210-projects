using System.ComponentModel.Design.Serialization;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.totalCost();
        }
        if (_customer.inUSA())
        {
            total += 5;
        }
        else if (!_customer.inUSA())
        {
            total += 35;
        }
        return total;
    }

    public string GetPackagingLabel()
    {
        string packaginglbl = "";

        foreach (Product product in _products)
        {
            packaginglbl += $"{product.GetName()} - {product.GetID()}\n";
        }
        return packaginglbl;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}