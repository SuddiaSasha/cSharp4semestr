namespace lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product("Moloko", 200.4m, 3);

            //product1.Name = "Moloko 2";
            //Console.WriteLine(product1.Name);
            //product1.Price = 228.005m;
            //Console.WriteLine(product1.Price);

            //product1.Restock(3);
            //Console.WriteLine(product1.Quantity);


            Product apple = new Product("Яблуко", 5, 100);
            Console.WriteLine(apple.GetInfo());
            // Виведе: Товар: Яблуко, Ціна: 5 грн, Кількість: 100, Загальна вартість: 500 грн

            apple.Sell(20);
            Console.WriteLine(apple.GetInfo());
            // Виведе: Товар: Яблуко, Ціна: 5 грн, Кількість: 80, Загальна вартість: 400 грн

            apple.Restock(50);
            Console.WriteLine(apple.GetInfo());
            // Виведе: Товар: Яблуко, Ціна: 5 грн, Кількість: 130, Загальна вартість: 650 грн

            apple.Price = 7; // Зміна ціни товару
            Console.WriteLine(apple.GetInfo());
            // Виведе: Товар: Яблуко, Ціна: 7 грн, Кількість: 130, Загальна вартість: 910 грн

            apple.Name = "Зелене яблуко"; // Перейменування товару
            Console.WriteLine(apple.GetInfo());
            // Виведе: Товар: Зелене яблуко, Ціна: 7 грн, Кількість: 130, Загальна вартість: 910 грн

            apple.Price = -10; // Повинно викликати помилку
            apple.Name = "";    // Повинно викликати помилку
            apple.Sell(200);    // Повинно вивести: "Недостатньо товару на складі!"


        }
    }
}
