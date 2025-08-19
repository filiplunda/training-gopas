// See https://aka.ms/new-console-template for more information
using _02._01_Overriding.Exercise6;
using _02._01_Overriding.Exercise7;
using _02._02_AutomaticProperties;
using Training._02._03_VirtualMethods;
using Training._02._05_Using_Interface;
using Training._03._01_GenericTypes;
using Training._03._02_ArrayAndCollections;
using Stream = Training._02._04_AbstractClass.Stream;
using InventoryString = Training._03._03_AdvancedGenerics.Inventory<string>;
using InventoryDict= Training._03._03_AdvancedGenerics.Inventory<string, long>;
using Training._04._01_OperatorOverloading;
using static Training._05._01_UsingDelegates.UsingDelegates;
using Training._05._02_DelegateCallBack;
using Training._05._04_UsingEvents;
using Training._05._05_EventAccessor;


internal class Program
{
    private static void Main(string[] args)
    {
        //Exercise 6
        Console.WriteLine("----------------------02.01_Overriding----------------------");

        Fish fish = new Fish();
        Cat cat = new Cat();
        PersianCat persianCat = new PersianCat();

        Console.WriteLine(fish.MakeSound());
        Console.WriteLine(cat.MakeSound());
        Console.WriteLine(persianCat.MakeSound());

        Console.WriteLine();

        Employee e1 = new Employee("Joe", "Doe");
        Console.WriteLine($"ToString:  {e1.ToString()}");

        Console.WriteLine();

        Employee e2 = e1;
        Console.WriteLine($"ReferenceEquals: {ReferenceEquals(e1, e2)}");
        Console.WriteLine($"== : {e1 == e2}");

        e2 = new Employee("Joe", "Doe");
        Console.WriteLine($"ReferenceEquals: {ReferenceEquals(e1, e2)}");
        Console.WriteLine($"== : {e1 == e2}");
        Console.WriteLine($" Equals: {e1.Equals(e2)}");
        Console.WriteLine();

        //Exercise 10- 12
        Console.WriteLine("----------------------02.02_AutomaticProperties----------------------");

        Console.WriteLine(e1.GetHashCode());
        Console.WriteLine(e2.GetHashCode());

        //Person p = new Person();
        EmployeePerson p = new EmployeePerson();

        //p.FirstName = "Karel";
        p.LastName = "Novak";

        Console.WriteLine("{0} {1}", p.FirstName, p.LastName);

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
        Console.WriteLine("----------------------02.03_VirtualMethods----------------------");

        Training._02._03_VirtualMethods.Animal[] animals = { new VirtualDog(), new VirtualCat(), new VirtualDog(), new VirtualCat() };

        foreach (VirtualAnimal item in animals)
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
        Console.WriteLine("----------------------02.04_Abstract class----------------------");

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
            foreach (Stream item in streams)
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
        Console.WriteLine("----------------------02.05_Using interface----------------------");

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

        Console.WriteLine();
        Console.WriteLine("----------------------03.01_Generic types----------------------");

        //Stack stack = new Stack();
        Training._03._01_GenericTypes.Stack<int> stack = new Training._03._01_GenericTypes.Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        /*Console.WriteLine((int)stack.Pop());
        Console.WriteLine((int)stack.Pop());
        Console.WriteLine((int)stack.Pop());

        stack.Push(1);
        stack.Push("2");
        stack.Push(new int[] {1,2,3});

        Console.WriteLine((int[])stack.Pop());
        Console.WriteLine((string)stack.Pop());
        Console.WriteLine((int)stack.Pop());*/

        Training._03._01_GenericTypes.Stack<string> stringStack = new Training._03._01_GenericTypes.Stack<string>();

        stringStack.Push("A");
        stringStack.Push("B");
        stringStack.Push("C");

        Console.WriteLine(stringStack.Pop());
        Console.WriteLine(stringStack.Pop());
        Console.WriteLine(stringStack.Pop());

        GenericClass<int> mc = new GenericClass<int>();
        Console.WriteLine(mc.GetValue());

        GenericClass<string> sc = new GenericClass<string>();
        Console.WriteLine(sc.GetValue());

        Console.WriteLine();
        Console.WriteLine("----------------------03.02_Array and Collecctions----------------------");

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("Working...");
        sw.Start();

        //int[] list = new int[1];
        //ArrayList list = new ArrayList();
        List<int> list = new List<int>();

        for (int i = 0; i < 1000000; i++)
        {
            //Array.Resize<int>(ref list, list.Length + 1);
            list.Add(0);
        }
        ;

        sw.Stop();
        Console.WriteLine("Done");
        Console.WriteLine(sw.ElapsedMilliseconds + "ms");

        Console.WriteLine();
        Console.WriteLine("----------------------03.02_Queue----------------------");
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Enqueue("D");
        queue.Enqueue("E");

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());

        Console.WriteLine(queue.Peek());

        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("----------------------03.02_Stack----------------------");
        System.Collections.Generic.Stack<string> genericStack = new System.Collections.Generic.Stack<string>();

        genericStack.Push("A");
        genericStack.Push("B");
        genericStack.Push("C");
        genericStack.Push("D");
        genericStack.Push("E");

        Console.WriteLine(genericStack.Pop());
        Console.WriteLine(genericStack.Pop());
        Console.WriteLine(genericStack.Peek());

        foreach (string item in genericStack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("----------------------03.02_Dictionary----------------------");

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("do", "do");
        dictionary.Add("go", "go");
        dictionary.Add("wait", "wait");
        dictionary.Add("stand", "stand");

        Console.WriteLine(dictionary["go"]);

        foreach (KeyValuePair<string, string> keyValuePair in dictionary)
        {
            Console.WriteLine(keyValuePair.Key + ": " + keyValuePair.Value);
        }

        Dictionary<TrainingId, string> trainingList = new Dictionary<TrainingId, string>();

        trainingList.Add(new TrainingId("GOC", 2124), "C# Language - Programming I");
        trainingList.Add(new TrainingId("GOC", 2125), "C# Language - Programming II");
        trainingList.Add(new TrainingId("GOC", 211), "ADO.NET");

        Console.WriteLine(trainingList[new TrainingId("GOC", 2125)]);

        Console.WriteLine();
        Console.WriteLine("----------------------03.03_Advanced generics----------------------");

        InventoryString simpleInventory = new InventoryString();
        simpleInventory.AddItem("Apple", 3);
        simpleInventory.AddItem("Banana");

        InventoryDict keyedInventory = new InventoryDict();

        keyedInventory.AddItem(1, "Laptop");
        keyedInventory.AddItem(2, "Monitor");

        string[] genericList = { "Prague", "Brno", "Ostrava", "Pilsen" };

        foreach (string item in genericList)
        {
            Console.WriteLine(item);
        }

        //Array.Sort<string>(genericList);
        Array.Sort(genericList);

        foreach (string item in genericList)
        {
            Console.WriteLine(item);
        }

        //Console.WriteLine(Array.IndexOf<string>(genericList, "Prague"));
        Console.WriteLine(Array.IndexOf(genericList, "Prague"));

        Console.WriteLine();
        Console.WriteLine("----------------------04.01_Operator Overloading----------------------");

        OverloadingDate d1 = new OverloadingDate(1, 1, 2014);
        Console.WriteLine($"d1: {d1}");

        d1.AddDays(14);
        Console.WriteLine($"d1: {d1}");

        OverloadingDate d2 = d1 + 14;
        Console.WriteLine($"d2: {d2}");

        Console.WriteLine($"d1: {d1}");

        d1 += 1;
        Console.WriteLine($"d1: {d1}");

        d1++;
        Console.WriteLine($"d1: {d1}");

        Console.WriteLine(d1++.Day);
        Console.WriteLine((++d1).Day);

        OverloadingDate orderDate = new OverloadingDate(8, 8, 2025);
        OverloadingDate shippedDate = new OverloadingDate(8, 8, 2025);
        Console.WriteLine(orderDate == shippedDate);

        string s = d1;
        //string s = d1.ToString();
        //string s = (string)d1;

        Console.WriteLine(s);

        Console.WriteLine();
        Console.WriteLine("----------------------05.01_Delegate and invocation list----------------------");

        //int sum = Sum(10, 20);
        MyDelegate sumDelegate = new MyDelegate(Sum);
        int sum = sumDelegate(30, 40);

        Console.WriteLine($"Sum: {sum}");

        MyDelegate maxDelegate = Max;
        Console.WriteLine(maxDelegate(10, 20));

        MyAnotherDelegate anotherDelegate = new MyAnotherDelegate(DoSomething);
        anotherDelegate();

        anotherDelegate = DoSomething;
        anotherDelegate += DoSomethingElse;

        anotherDelegate();

        foreach(MyAnotherDelegate item in anotherDelegate.GetInvocationList())
        {
            item();
        }

        Console.WriteLine();
        Console.WriteLine("----------------------05.02_Delegates and Callbacks----------------------");

        DelegateHelper.CallBack += CallBackFunction;
        DelegateHelper.DoWork();

        Console.WriteLine();
        Console.WriteLine("----------------------05.02_Download demo----------------------");

        DelegateHelper.DowloadCompletedCallBack = CallBackFunction;
        DelegateHelper.DownloadFile("fileUrl");

        Console.WriteLine();
        Console.WriteLine("----------------------05.03_CallBackToEvent----------------------");

        //Helper.CallBack += CallBackFunction;
        DelegateHelper.CallBack += CallBackFunction2;
        DelegateHelper.DoWork();
        DelegateHelper.DoWork();
        DelegateHelper.DoWork();

        Console.WriteLine();
        Console.WriteLine("----------------------05.04_UsingEvents----------------------");

        //IntListWithChangedEvent intEventList = new IntListWithChangedEvent();
        ListWithChangedEvent<int> intEventList = new ListWithChangedEvent<int>();
        intEventList.Changed += EventListener;
        intEventList.Changed += EventList_Changed;

        intEventList.Add(1);
        intEventList.Add(2);
        intEventList.Add(3);

        intEventList[0] = 10;

        //foreach(int item in intEventList)
        //{
        //    Console.WriteLine(item);
        //}

        intEventList.Clear();

        Console.WriteLine();
        Console.WriteLine("----------------------05.05_EventAccessor----------------------");

        Worker worker = new Worker();
        worker.WorkDone += Worker_WorkDone;
        worker.WorkDone -= Worker_WorkDone;
        worker.WorkDone += Worker_WorkDone;
        worker.DoWork();

        ExtendedWorker extendedWorker = new ExtendedWorker();
        extendedWorker.WorkDone += Worker_WorkDone;
        extendedWorker.DoWork();
    }

    private static void EventList_Changed(object? sender, ChangedEventArgs e)
    {
        //Console.WriteLine("Changed");
        Console.WriteLine(e.ChagedState);
    }

    private static int Sum(int a, int b)
    {
        return a + b;
    }

    private static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    private static void DoSomething()
    {
        Console.WriteLine("Doing something");
    }

    private static void DoSomethingElse()
    {
        Console.WriteLine("Doing something else");
    }

    private static void CallBackFunction(string result)
    {
        Console.WriteLine(result);
    }

    private static void CallBackFunction2(string result)
    {
        Console.WriteLine("CallBackFunction2:" + result);
    }

    static void EventListener(object sender, EventArgs e)
    {
        if (sender is not ListWithChangedEvent<int> list) return;

        Console.WriteLine("----------------------");
        Console.WriteLine("List has been changed. Current items are: ");
        foreach(int item in list)
        {
            Console.WriteLine("\t" + item);
        }

        if(list.Count == 0)
        {
            Console.WriteLine("\tNo items");
        }

        Console.WriteLine();
    }

    static void Worker_WorkDone(object sender, EventArgs e)
    {
        Console.WriteLine("Done");
    }
}

