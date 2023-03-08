
#region Classes and objects

using SEDC.Class5.OOP.Classes;

Person person = new Person("John",25);

//person.Name = "John";
//person.Age = 25;

person.Talk("Hello There");

Console.WriteLine($"{person.Name} is {person.Age} years old");

Person person1 = new Person("Jim", 30);
//{
//    Name = "Jim",
//    Age = 25
//};

Person person3 = new Person();
person3.Talk( "i am still unnamed");

Console.WriteLine(person3.Balance);

Person person4 = new Person("Jane", 34, 1500);

person4.CheckBalance();


Product sneakers = new Product("Nike",200);
Product phone = new Product("iPhone", 500);
Product tShirt = new Product("Addidas T-shirt", 100);

person1.BuyProduct(tShirt);
person4.BuyProduct(tShirt);




#endregion

#region Array of objects

//Array of specific objects
Person[] personArray = new Person[] { person, person1, person3, person4 };
Product[] productArray = new Product[] { sneakers, phone, tShirt };

foreach (Person p in personArray)
{
    Console.WriteLine(p.Name);
}



#endregion

#region Anonymous object

//Cannot add methods
var annonymousObj = new
{
    FirstName = "Jill",
    LastName = "Smith"
};

//Cannot modify existing properties
//annonymousObj.FirstName = "mike"

Console.WriteLine($"Annonymous object: {annonymousObj.FirstName} {annonymousObj.LastName}");





#endregion


#region Static Classes


//Math.Round(100.1);

ConsoleHelper.Separator();

#endregion