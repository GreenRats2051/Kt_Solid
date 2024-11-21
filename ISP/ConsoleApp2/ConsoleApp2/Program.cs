using ConsoleApp2;

Animal myCat = new Cat("Мурка");
Animal myDog = new Dog("Шарик");
Animal myHorse = new Horse("Буревестник");

Console.WriteLine($"{myCat.Name} говорит: {myCat.MakeSound()}");
Console.WriteLine($"{myDog.Name} говорит: {myDog.MakeSound()}");
Console.WriteLine($"{myHorse.Name} говорит: {myHorse.MakeSound()}");