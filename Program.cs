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
using System.Text;
using Training._06._01_NewFunctionality;
using System.Data.Common;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

//#nullable enable

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Show chapters: 2-13");
        var chapter = Console.ReadKey();

        if (int.TryParse(chapter.KeyChar.ToString(), out int number)) { }
        else
        {
            Console.WriteLine("\nThe key pressed is not a valid number.");
        }

        if (number == 2)
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
        }
        else if (number == 3)
        {
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
        }
        else if (number == 4)
        {
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
        }
        else if (number == 5)
        {
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

            foreach (MyAnotherDelegate item in anotherDelegate.GetInvocationList())
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
        else if (number == 6)
        {


            Console.WriteLine();
            Console.WriteLine("----------------------06.01 Implicitly typed variables----------------------");

            //int explicitNumber = 10; //explicitly typed
            //var implicitNumber = 10; //implicitly typed
            //var implicitNumber = "ABC";
            //implicitNumber = 10; //Does not compile

            //StringBuilder sb = new StringBuilder();
            var sb = new StringBuilder();
            StringBuilder sb2 = new(100);

            int[] explicitList = { 1, 2, 3 };
            var implicitList = new int[3] { 1, 2, 3 };

            foreach (var item in implicitList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(OptionalCalculate(a: 10, b: 20, c: 30, d: 40));
            Console.WriteLine(OptionalCalculate(10, 20, 30));

            Console.WriteLine();
            Console.WriteLine("----------------------06.02 Nullable value types----------------------");

            //int i = null;
            //System.Nullable<int> i = null;
            int? nullableI = null;
            nullableI = nullableI + 1; //remains null
            //nullableI = nullableI.Value + 1; //Throws error

            if (nullableI.HasValue)
            {
                nullableI = nullableI.Value + 1;
            }
            ;

            //nullableI = nullableI.GetValueOrDefault(1) + 1;
            nullableI = (nullableI ?? 1) + 1;

            //StringBuilder sb3 = MakeStringBuilder("abc");
            StringBuilder sb3 = MakeStringBuilder("");
            //int lenght = sb3.Length;
            /*int lenght; 
            if(sb3 != null)
            {
                lenght = sb.Length;
            }
            else
            {
                lenght = 0;
            }*/

            int? lenght = sb3?.Length;
            Console.WriteLine(lenght ?? 0);

            string[] nullableList = null;
            Console.WriteLine(nullableList?[0]?.Length ?? 0);

            //List<int> preparelist = PrepareList(new List<int>());
            List<int> preparelist = PrepareList();


            foreach (var item in preparelist)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine();
            Console.WriteLine("----------------------06.03 Nullable reference types----------------------");

            List<string> nullableReferenceList = new List<string>();
            NullableReferenceAddItem(nullableReferenceList, "A");
            NullableReferenceAddItem(nullableReferenceList, "B");
            NullableReferenceAddItem(nullableReferenceList, null);

            foreach (string item in nullableReferenceList)
            {
                Console.WriteLine(item?.ToLower());
                string s = item!;
                Console.WriteLine(s?.ToLower());
            }

            Console.WriteLine();
            Console.WriteLine("----------------------06.04 Tuples----------------------");

            Tuple<int, string, bool> tuplesResult = TuplesGetDate();
            //Console.WriteLine((int)tuplesResult[0]);
            //Console.WriteLine((string)tuplesResult[1]);
            //Console.WriteLine((bool)tuplesResult[2]);
            Console.WriteLine(tuplesResult.Item1);
            Console.WriteLine(tuplesResult.Item2);
            Console.WriteLine(tuplesResult.Item3);

            var otherTuplesResult = OtherTuplesGetDate();
            //Console.WriteLine(otherTuplesResult.Item1);
            //Console.WriteLine(otherTuplesResult.Item2);
            //Console.WriteLine(otherTuplesResult.Item3);
            Console.WriteLine(otherTuplesResult.Id);
            Console.WriteLine(otherTuplesResult.Name);
            Console.WriteLine(otherTuplesResult.IsMember);

            Console.WriteLine();
            Console.WriteLine("----------------------06.05 Discard and deconstruct ----------------------");

            Rectangle rectangle = new Rectangle(10, 20);

            //double width;
            //double height;
            //double perimeter;
            //double area;
            //rectangle.Stats(out width, out height, out perimeter, out area);
            //rectangle.Stats(out double width, out double height, out double perimeter, out double area);
            rectangle.Stats(out _, out _, out _, out var area);
            Console.WriteLine("Area of the rectangle is " + area);

            //var stats = rectangle.GetStats();
            //double width;
            //double height;
            //double perimeter;
            //double area2;
            //(double width, double height, double perimeter, double area) stats = rectangle.GetStats();
            //(width, height, perimeter, area2) = rectangle.GetStats();
            //(double width, double height, double perimeter, double area2) = rectangle.GetStats();
            (_, _, _, var area2) = rectangle.GetStats();

            Console.WriteLine("Area of the rectangle is " + area2);

            var (width, height) = rectangle;
            Console.WriteLine($"Width: {width}, Height: {height}");

            var (_, _, _, area3) = rectangle;
            Console.WriteLine("Area of the rectangle is " + area3);

            Console.WriteLine();
            Console.WriteLine("----------------------06.06 Index and Range operator ----------------------");

            string indexText = "ABCDEFGH";
            Console.WriteLine(indexText[0]);
            //Console.WriteLine(indexText[indexText.Length - 1]);
            Console.WriteLine(indexText[^1]);

            //Index index1 = new Index(0, false);
            //Index index2 = new Index(1, false);
            //Index index3 = new Index(2, false);

            Index index1 = new Index(0, true);
            Index index2 = new Index(1, true);
            Index index3 = new Index(2, true);
            //int indexLenght = 8;
            int indexLenght = indexText.Length;
            Console.WriteLine(index1.GetOffset(indexLenght));
            Console.WriteLine(index2.GetOffset(indexLenght));
            Console.WriteLine(index3.GetOffset(indexLenght));
            Console.WriteLine(new Index(2, true).GetOffset(indexLenght));

            Console.WriteLine(indexText[index3.GetOffset(indexText.Length)]);
            Console.WriteLine(indexText[^2]);

            string operatorText = "ABCDEFGH";
            int start = 1;
            int end = 5;
            char[] subArrayList = GetSubArray(operatorText.ToCharArray(), start, end);

            foreach (var item in subArrayList)
            {
                Console.WriteLine(item);
            }

            Range range = new Range(1, 5);
            Console.WriteLine($"Start: {range.Start}");
            Console.WriteLine($"End: {range.End}");
            Console.WriteLine($"Range: {range}");

            Console.WriteLine(RuntimeHelpers.GetSubArray<char>(operatorText.ToCharArray(), range));
            Console.WriteLine(operatorText[range]);
            Console.WriteLine(operatorText[new Range(1, 5)]);
            Console.WriteLine(operatorText[1..5]);
            Console.WriteLine(operatorText[0..^5]);
            Console.WriteLine(operatorText[^2..^0]);

            Console.WriteLine();
            Console.WriteLine("----------------------06.07 Extension methods----------------------");

            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"The original sentence is: {sentence}");

            //sentence = sentence[0].ToString().ToUpper() + sentence.Substring(1);
            //if (sentence[^1] != '.')
            //{
            //    sentence += ".";
            //}
            //sentence = ToSentence(sentence);
            //var extendedString = new ExtendedString();
            //sentence = extendedString.ToSentence(sentence);
            //sentence = null;
            //sentence = sentence.ToSentence();
            sentence = sentence.ToSentence(false);

            Console.WriteLine($"The changed sentence is: {sentence}");

            ExtensionEmployee extensionEmployee = new ExtensionEmployee(1, "Karel", "Novak");
            Console.WriteLine(extensionEmployee.ToString());
            Console.WriteLine(extensionEmployee.ToString(false));

            Console.WriteLine();
            Console.WriteLine("----------------------06.08 Object initializers----------------------");

            //ObjectEmployee objectEmployee = new ObjectEmployee();
            //objectEmployee.FirstName = "Karel";
            //objectEmployee.LastName = "Novak";

            //var objectEmployee = new ObjectEmployee
            //{
            //    FirstName = "Karel",
            //    LastName = "Novak"
            //};

            var objectEmployee = new ObjectEmployee(1)
            {
                FirstName = "Karel",
                LastName = "Novak",
                Department = new ObjectDepartment
                {
                    Name = "IT"
                }
            };
            Console.WriteLine(objectEmployee.ToString());

            int[] initializerList = new int[4] { 10, 20, 30, 40 };
            int[] initializerList2 = { 10, 20, 30, 40 };
            List<int> initializerList3 = new List<int> { 10, 20, 30, 40 };
            //List<int> initializerList4 =  { 10, 20, 30, 40 }; Does not work

            List<ObjectEmployee> initilializerList4 = new List<ObjectEmployee>
            {
                new ObjectEmployee(1)
                {
                    FirstName = "Karel",
                    LastName = "Novak"
                }
            };

            System.Collections.Generic.Stack<string> intializerStack = new System.Collections.Generic.Stack<string> { "A", "B", "C", "D" };
            System.Collections.Generic.Stack<int> intializerStack2 = new System.Collections.Generic.Stack<int> { 1, 2, 3 };

            string[] initializerLetters = new string[] { "A", "B", "C", "D" };
            Console.WriteLine(string.Join(",", initializerLetters));

            //List<string> initializerList6 = new List<string>(initializerLetters);
            List<string> initializerList6 = new List<string>(initializerLetters)
            {
                [1] = "b",
                [3] = "d"
            };

            Console.WriteLine(string.Join(",", initializerList6));

            Dictionary<string, string> initializerDictionary = new Dictionary<string, string>
            {
                ["CZ"] = "Czech republic",
                ["FR"] = "France"
            };

            Console.WriteLine(string.Join(",", initializerDictionary));

            InitDeveloper initDeveloper = new InitDeveloper
            {
                FirstName = "Joe",
                LastName = "Doe"
            };

            //initDeveloper.LastName = "Parker";
            //InitDeveloper initDeveloper2 = new InitDeveloper("Joe", "Doe");
            var initDeveloper3 = new InitDeveloper();
            Console.WriteLine($"{initDeveloper3.FirstName ?? "null"}" + $"{initDeveloper3.LastName ?? "null"}");
        }

        Console.WriteLine();
        Console.WriteLine("----------------------07.01 Anonymous types----------------------");

        var anonymousEmployee = new { FirstName = "Karel", LastName = "Novak" };
        Console.WriteLine("{0} {1}", anonymousEmployee.FirstName, anonymousEmployee.LastName);

        //anonymousEmployee.FirstName = "Martin"; Anonymous types are immutable

        //var anonymousEmployee2 = new { FirstName = "Karel", LastName = "Novak" };
        var anonymousEmployee2 = new { LastName = "Novak", FirstName = "Karel" };


        Console.WriteLine(anonymousEmployee.Equals(anonymousEmployee2));
        Console.WriteLine(anonymousEmployee.GetHashCode());

        Console.WriteLine(anonymousEmployee.GetType().ToString());
        Console.WriteLine(anonymousEmployee2.GetType().ToString());

        Console.WriteLine(anonymousEmployee.GetType().BaseType.ToString());
        Console.WriteLine(anonymousEmployee2.GetType().BaseType.ToString());

        ShowEmployeeUsingReflection(anonymousEmployee);
        ShowEmployeeUsingDynamicType(anonymousEmployee);
        ShowEmployeeUsingGenerics(anonymousEmployee);
        ShowEmployeeUsingTuple(new Tuple<string, string>(anonymousEmployee.FirstName, anonymousEmployee.LastName));
        ShowEmployeeUsingTuple(Tuple.Create(anonymousEmployee.FirstName, anonymousEmployee.LastName));
        ShowEmployeeUsingValueTuple((anonymousEmployee.FirstName, anonymousEmployee.LastName));

        //var anonymousList = new[] { new { FirstName = "ListName", LastName = "ListSurname" } };
        var anonymousList = new[] { new { FirstName = "", LastName = "" } }.ToList();
        anonymousList.Clear();

        anonymousList.Add(new { FirstName = "Karel", LastName = "Novak" });
        anonymousList.Add(new { FirstName = "Martin", LastName = "Novak" });

        foreach (var item in anonymousList)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }

        Console.WriteLine();
        Console.WriteLine("----------------------07.02 Anonymous methods and Lambda expressions----------------------");

        int[] anonymousArray = { 10, 20, 30, 40 };
        AnonymousListArray(anonymousArray);

        AnonymousListArrayDelegate anonymousDelegate = new AnonymousListArrayDelegate(AnonymousListArray);

        anonymousDelegate(new int[] { 10, 20, 30, 40 });

        AnonymousListArrayDelegate anonymousDelegate2;

        anonymousDelegate2 = delegate (int[] list) 
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        };

        anonymousDelegate2(new int[] { 10, 20, 30, 40 });

        Array.ForEach<int>(anonymousArray, delegate(int item) { Console.WriteLine(item); });

        int[] funcList = Array.FindAll<int>(anonymousArray, delegate(int item) { return item > 20; });

        Array.ForEach<int>(funcList, delegate (int item) { Console.WriteLine(item); });


    }

    delegate void AnonymousListArrayDelegate(int[] list);

    static void AnonymousListArray(int[] list)
    {
        foreach(int item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void ShowEmployeeUsingReflection(object o)
    {
        //Console.WriteLine(o.FirstName);
        Console.WriteLine(o.GetType().GetProperty("FirstName").GetValue(o, null));
    }

    static void ShowEmployeeUsingDynamicType(dynamic employee)
    {
        Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
    }

    static void ShowEmployeeUsingGenerics(object o)
    {
        var employee = new { FirstName = "Karel", LastName = "Novak" };

        var e = Cast(employee, o);
        Console.WriteLine("{0} {1}", e.FirstName, e.LastName);
    }

    static void ShowEmployeeUsingTuple(Tuple<string, string> e)
    {
        Console.WriteLine("{0} {1}", e.Item1, e.Item2);
    }

    static void ShowEmployeeUsingValueTuple((string firstName, string lastName) e)
    {
        Console.WriteLine("{0} {1}", e.firstName, e.lastName);
    }

    static T Cast<T>(T type, object o)
    {
        return (T)o;
    }

    //var anonymousEmployee3 = new { FirstName = "Karel", LastName = "Novak" };

    static char[] GetSubArray(char[] text, int start, int end)
    {
        char[] newArray = new char[end - start];

        for(int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = text[i + start];
        }

        return newArray;
    }
    static Tuple<int, string, bool> TuplesGetDate()
    {
        int id = 10;
        string name = "Joe";
        bool isMember = true;

        return new Tuple<int, string, bool> ( id, name, isMember );
    }

    static (int Id, string Name, bool IsMember) OtherTuplesGetDate()
    {
        return (10, "Hello", true);
    }

    static void NullableReferenceAddItem(List<string> list, string newValue)
    {
        list.Add(newValue);
    }

    static List<int> PrepareList(List<int> list = null)
    {
        /*if(list == null)
        {
            list = new List<int>();
        }*/

        list ??= new List<int>();

        list?.Add(10);
        list?.Add(20);
        list?.Add(30);
        return list;
    }

    static StringBuilder MakeStringBuilder(string s)
    {
        if (!string.IsNullOrEmpty(s))
        {
            return new StringBuilder(s);
        }

        return null;
    }

    static int OptionalCalculate(int a, int b, int c, int d = 0)
    {
        return a + b - c - d;
    }

    static int OptionalCalculate(int a, int b, int c)
    {
        return a + b - c;
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

