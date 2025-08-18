// See https://aka.ms/new-console-template for more information
using _02._01_Overriding.Exercise6;
using _02._01_Overriding.Exercise7;
using _02._02_AutomaticProperties;
using Training._02._03_VirtualMethods;
using Training._02._04_AbstractClass;
using Training._02._05_Using_Interface;
using Stream = Training._02._04_AbstractClass.Stream;

//Exercise 6
Console.WriteLine("02.01_Overriding");

Console.WriteLine("Exercise 5-6 - Overriding methods");
Fish fish = new Fish();
Cat cat = new Cat();
PersianCat persianCat = new PersianCat();

Console.WriteLine(fish.MakeSound());
Console.WriteLine(cat.MakeSound());
Console.WriteLine(persianCat.MakeSound());

Console.WriteLine();

//Exercise 7
Console.WriteLine("Exercise 7 - Overriding ToString()");

Employee e1 = new Employee("Joe", "Doe");
Console.WriteLine($"ToString:  {e1.ToString()}");

Console.WriteLine();


//Exercise 8-9

Console.WriteLine("Exercise 8-9 - Overriding Equals + GetHashCode");

Employee e2 = e1;
Console.WriteLine($"ReferenceEquals: {object.ReferenceEquals(e1, e2)}");
Console.WriteLine($"== : {e1 == e2}");

e2 = new Employee("Joe", "Doe");
Console.WriteLine($"ReferenceEquals: {object.ReferenceEquals(e1, e2)}");
Console.WriteLine($"== : {e1 == e2}");
Console.WriteLine($" Equals: {e1.Equals(e2)}");
Console.WriteLine();

//Exercise 10- 12
Console.WriteLine("02.02_AutomaticProperties");
Console.WriteLine("Exercise 10 - 12 - Auto-implement properties + Overriding properties");


Console.WriteLine(e1.GetHashCode());
Console.WriteLine(e2.GetHashCode());

//Person p = new Person();
EmployeePerson p = new EmployeePerson();

//p.FirstName = "Karel";
p.LastName = "Novak";

Console.WriteLine("{0} {1}", p.FirstName, p.LastName);

//Exercise 13
Console.WriteLine();
Console.WriteLine("Exercise 13-14 - Indexer + Indexer Overloading");


WeekDayNames weekDays = new WeekDayNames();

//weekDays.CurrenctWeekDayName = "Sunday";

/*weekDays.CurrenctWeekDayIndex = 1;
Console.WriteLine(weekDays.CurrenctWeekDayName);
weekDays.CurrenctWeekDayIndex = 2;
Console.WriteLine(weekDays.CurrenctWeekDayName);
weekDays.CurrenctWeekDayIndex = 3;
Console.WriteLine(weekDays.CurrenctWeekDayName);*/

/*Console.WriteLine(weekDays[1]);
Console.WriteLine(weekDays[2]);
Console.WriteLine(weekDays[3]);*/

Console.WriteLine(weekDays["Mo"]);
Console.WriteLine(weekDays["Tu"]);
Console.WriteLine(weekDays["We"]);

Console.WriteLine();
Console.WriteLine("02.03_VirtualMethods");

Training._02._03_VirtualMethods.Animal[] animals = { new VirtualDog(), new VirtualCat(), new VirtualDog(), new VirtualCat() };

foreach(Training._02._03_VirtualMethods.VirtualAnimal item in animals)
{
    Console.WriteLine(item.Sound());

    /*if(item is VirtualCat)
    {
        Console.WriteLine(((VirtualCat)item).Sound());
    }
    else if (item is VirtualDog)
    {
        Console.WriteLine(((VirtualDog)item).Sound());
    }*/
}

Console.WriteLine();
Console.WriteLine("02.04_Abstract class");

//Stream stream = new Stream();
Training._02._04_AbstractClass.FileStream stream = new Training._02._04_AbstractClass.FileStream();
stream.Open();
stream.Close();

Stream[] streams = new Stream[2];
streams[0] = new Training._02._04_AbstractClass.FileStream();
streams[1] = new Training._02._04_AbstractClass.MemoryStream();

OpenStreams(streams);
CloseStreams(streams);

static void OpenStreams(Stream[] streams)
{
    foreach(Stream item in streams)
    {
        item.Open();
    }
}

static void CloseStreams(Stream[] streams)
{
    foreach (Stream item in streams)
    {
        item.Close();
    }
}

Console.WriteLine();
Console.WriteLine("02.05_Using interface");

//CardPayment cardPayment = new CardPayment();
//cardPayment.ProcessPayment();
//IPayment payment = cardPayment;
//payment.ProcessPayment();

//BankTransferPayment bankTransferPayment = new BankTransferPayment();
//payment = bankTransferPayment;
//payment.ProcessPayment();
//bankTransferPayment.ProcessPayment();

var paymentManager = new PaymentManager();

var cardPayment = new CardPayment();
var bankTransferPayment = new BankTransferPayment();

paymentManager.ProcessPayments(cardPayment);
paymentManager.ProcessPayments(bankTransferPayment);
paymentManager.ProcessPayments(new MobilePayment());


paymentManager.ShowPaymentHistory();

