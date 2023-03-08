
namespace SEDC.Class5.OOP.Classes
{
    //Access Modifiers
    //public - you can access the Object from anywhere
    //private - you can only access the private Object inside the root class
    //Internal - you can only access the internal object inside the same project
    //protected - you can only access the objects that are only derived from this class
    public class Person
    {
        public Person()
        {
            PersonalNumber = GeneratePersonalNumber();
        }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Balance = 10;
            PersonalNumber = GeneratePersonalNumber();
        }

        public Person(string name, int age, double balance)
        {
            Name = name;
            Age = age;
            Balance = balance;
            PersonalNumber = GeneratePersonalNumber();
            
        }


        public string Name { get; set; } = "Unnammed";
        public int Age { get; set; } = 1;
        public double Balance { get; set; }

        private long PersonalNumber { get; set; }


        public void Talk (string message)
        {
            Console.WriteLine ($"[{PersonalNumber}] {Name} ({Age}) is saying: {message}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"[{PersonalNumber}] {Name}'s Balance: {string.Format("{0:C}", Balance)}");
        }

        public void BuyProduct (Product product)
        {
            CheckBalance();
            if(Balance >= product.Price)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{Name} just bought {product.Name} for  {string.Format("{0:C}", product.Price)}");
                Balance -= product.Price;
                Console.ResetColor();
                CheckBalance();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"You need {string.Format("{0:C}", product.Price - Balance)} to buy {product.Name}");
                Console.ResetColor();
            }
            
        }

        private long GeneratePersonalNumber()
        {
            return new Random().Next(100000, 999999);
        }

        
    }
}
