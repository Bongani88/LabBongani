
//author: Bongani Magwa
using LabAppBongani;

public class Pizza
{
    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }

    private PizzaSize size;
    private int toppingQuantity;

    public Pizza(PizzaSize size, int toppingQuantity)
    {
        this.size = size;
        this.toppingQuantity = toppingQuantity;
    }

    public decimal CalculateCost()
    {
        decimal baseCost = 0;
        decimal toppingCost = 0;

        switch (size)
        {
            case PizzaSize.Small:
                baseCost = 50;
                toppingCost = 7 * toppingQuantity;
                break;
            case PizzaSize.Medium:
                baseCost = 70;
                toppingCost = 9 * toppingQuantity;
                break;
            case PizzaSize.Large:
                baseCost = 90;
                toppingCost = 11 * toppingQuantity;
                break;
        }

        return baseCost + toppingCost;
    }

    public string getDescription()
    {
        return $"Pizza Size: {size}, Topping Quantity: {toppingQuantity}";
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n*******************Welcome to the pizza ordering system!*********************");

        Console.WriteLine("Please choose a pizza size:");
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Large");
        Console.Write("Enter your choice (1/2/3): ");

        if (int.TryParse(Console.ReadLine(), out int choice) && (choice >= 1 && choice <= 3))
        {
            Pizza.PizzaSize pizzaSize = (Pizza.PizzaSize)(choice - 1);

            Console.Write("Enter number quantities: ");
            if (int.TryParse(Console.ReadLine(), out int toppingQuantity))
            {
                Pizza pizza = new Pizza(pizzaSize, toppingQuantity);

                Console.Write($"Pizza Cost: R{pizza.CalculateCost()},  ");
                Console.WriteLine(pizza.getDescription());

            }
            else
            {
                Console.WriteLine("Invalid topping quantity entered.");
            }
        }
        else
        {
            Console.WriteLine("Invalid pizza size choice. Please choose 1, 2, or 3.");
        }
        Console.WriteLine("\n\n*********************ANSWER OF QUESTION TWO**********************");
        BlueWhale objBlueWhale = new BlueWhale();

        objBlueWhale.DisplayMammalInfo();
        objBlueWhale.DisplayMarineAnimalInfo();
        objBlueWhale.DisplayCombinedInfo();
        Console.ReadKey();
    }
}
