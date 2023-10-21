using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 Local area
        addresses[0] = new Address("123 Main Street", "New York State", "NY", "USA  \n That included the taxes and product shipping ");
        customers[0] =  new Customer("Mr. Salvy Manrtel",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Mini chainsaw","A045",90.99f,1));
        productsLists[0].Add(new Product("steel nails","AC50",50.99f,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 OUt of the country
        addresses[1] = new Address("4855 Rue la vene Monset", "Paris", "Paris", "France \n That included the taxes and product shipping");
        customers[1] =  new Customer("Jaris Connard A.",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Fine point pencils", "AT777",5.00f,4));
        productsLists[1].Add(new Product("Hardcover book","AZZ1",70.45f,1));
        productsLists[1].Add(new Product("Night reading lamp","A569",25.99f,1));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            // The order of the productos and labels.
            Console.WriteLine($"\n*****CUSTOMER N°{i+1} ******");
            Console.WriteLine($"LABEL:\n{orders[i].GetPacking()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShipping()}");
            Console.WriteLine($"TOTAL COST OF PRODUCTS: ${orders[i].GetTotalCosOfProducts()}");
        }
    }
}