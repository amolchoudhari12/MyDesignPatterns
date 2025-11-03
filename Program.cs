using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDesignPatterns.VisitorPattern;
using MyDesignPatterns.AbstractFactory;
using MyDesignPatterns.StrategyPattern.TranslateContext;
using MyDesignPatterns.StrategyPattern;
using MyDesignPatterns.StatePattern;
using MyDesignPatterns.ObserverPattern.Subject;
using MyDesignPatterns.ObserverPattern.Observer;
using MyDesignPatterns.MementoPattern;
using MyDesignPatterns.MediatorPattern.Mediator;
using MyDesignPatterns.IteratorPattern;
using MyDesignPatterns.ChainOfResponsibility.Hanlders;
using MyDesignPatterns.ChainOfResponsibility;
using MyDesignPatterns.CommandPattern;
using MyDesignPatterns.BuilderPattern;
using MyDesignPatterns.BuilderPattern.Builder;
using MyDesignPatterns.FactoryPattern;
using MyDesignPatterns.PrototypePattern;
using MyDesignPatterns.TemplatePattern;
using MyDesignPatterns.AdapterPattern;
using MyDesignPatterns.BridgePattern;
using MyDesignPatterns.CompositePattern;


namespace MyDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowCompositePattern();
            //ShowBridgePattern();
            //ShowAdapterPattern();
            //ShowTemplatePattern();
            //ShowSingletonPattern();
            ShowPrototypePattern();
           // ShowFactoryPattern();
            //ShowBuilderPattern();
            //ShowCommandPattern();
            //ShowChainOfResponsibilityPattern();
            // ShowIteratorPattern();
            //ShowMediatorPattern();
            // ShowMementoPattern();
            //ShowObserverPattern();
            //ShowStatePattern();
            //ShowStrategyPattern();
            // ShowAbtractFactoryPattern();
             //ShowVisiterPattern();

            Console.ReadKey();
        }

        private static void ShowCompositePattern()
        {
            CompositeXMLNode node = new CompositeXMLNode(1, "Specification");
            node.Add(new LeafXMLNode(1, "Structure"));
            node.Add(new LeafXMLNode(2, "Window"));
            node.Add(new LeafXMLNode(3, "Doors"));
            node.Add(new LeafXMLNode(4, "Walls"));


            CompositeXMLNode root = new CompositeXMLNode(1, "Property Specifications :");
            root.Add(node);

            root.Display(0);

        }

        private static void ShowBridgePattern()
        {
            OSType osType = OSType.MAC; // can assign Windows or Linux here
            IImageProcessor imageProcessor = new ImageProcessor(osType);
            imageProcessor.IImageImplementer.Save();
            imageProcessor.IImageImplementer.Compress();
            imageProcessor.IImageImplementer.Draw();
            imageProcessor.IImageImplementer.Show();
            imageProcessor.Show();


        }

        private static void ShowAdapterPattern()
        {
            ReadPropertiesRequest client = new ReadPropertiesRequest();
            client.SendRequest(new BACnetObjectIdentifierDTO() { InstanceNumber = 9, ObjectType = "Device" });
        }

        private static void ShowTemplatePattern()
        {
            LanguageConversion hindiConverter = new HindiConverter();
            hindiConverter.Run();

            LanguageConversion marathiConverter = new MarathiConverter();
            marathiConverter.Run();


        }

        private static void ShowSingletonPattern()
        {
            Singleton.Singleton s1 = Singleton.Singleton.GetInstance();
            Singleton.Singleton s2 = Singleton.Singleton.GetInstance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

        }

        private static void ShowPrototypePattern()
        {
            Console.WriteLine("{0}", System.DateTime.Now);
            ClonePrototype ddlItems = new LocationDropDowns();

            Console.WriteLine("Loading Time : {0}", System.DateTime.Now);

            ClonePrototype newDDLItems = ddlItems.Clone();

            Console.WriteLine("Loading Time : {0}", System.DateTime.Now);


        }

        private static void ShowFactoryPattern()
        {
            FoodFactory factory = new OraganicFoods();
            List<Food> foods = factory.CreateFood();

            Console.WriteLine("{0}", factory.GetType().Name);
            foreach (var item in foods)
            {
                item.ShowProtineContents();
            }

            factory = new FastFoods();
            foods = factory.CreateFood();

            Console.WriteLine("\n");
            Console.WriteLine("{0}", factory.GetType().Name);
            foreach (var item in foods)
            {
                item.ShowProtineContents();
            }


        }

        private static void ShowBuilderPattern()
        {
            Developer developer = new Developer("Pankaj builder");


            List<House> houses = new List<House>();

            houses.Add(developer.Construct(new BunglowBuilder(new House("Pankaj"))));
            houses.Add(developer.Construct(new PentHouseBuilder(new House("Pankaj Pent House"))));
            houses.Add(developer.Construct(new RowHouseBuilder(new House("Pankaj Tranquility"))));
            houses.Add(developer.Construct(new ApartmentBuilder(new House("Pankaj Avenue"))));

            foreach (var item in houses)
            {
                item.ShowHouse();
                Console.WriteLine("\n");
            }

        }

        private static void ShowCommandPattern()
        {
            Waiter waiter = new Waiter();
            CookCommand chiniseRise = new CookCommand(new ChiniesCook("chiniseRise"));
            CookCommand biryaniRice = new CookCommand(new IndianCook("biryaniRice"));
            CookCommand pizaa = new CookCommand(new ItalianCook("pizaa"));

            List<CookCommand> orderItems = new List<CookCommand>() { pizaa, chiniseRise, biryaniRice };
            waiter.SetPlaceOrder(orderItems);
            waiter.PlaceOrder();

        }

        private static void ShowChainOfResponsibilityPattern()
        {
            FirstLineSupport supportEntry = new FirstLineSupport();
            SupportRequest request = new SupportRequest() { ID = 1, Name = "Saving not working", Status = RequestStatusEnum.Initiated, complexity = 9 };
            supportEntry.HandleRequest(request);
            Console.WriteLine("Final Status of request [{0}] is {1} ", request.Name, request.Status.ToString());
        }



        static void supportEntry_RequestCompleted()
        {
            Console.WriteLine();
        }

        private static void ShowIteratorPattern()
        {
            ConcreateAggregate collection = new ConcreateAggregate();
            collection[0] = "Item 0";
            collection[1] = "Item 1";
            collection[2] = "Item 2";
            collection[3] = "Item 3";
            collection[4] = "Item 4";
            collection[5] = "Item 5";
            collection[6] = "Item 6";
            collection[7] = "Item 7";
            collection[8] = "Item 8";
            collection[9] = "Item 9";

            Iterator iterator = collection.CreateIterator();

            for (object item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
            {
                Console.WriteLine("{0}", item);
            }

        }

        private static void ShowMediatorPattern()
        {
            ShivajiTerminalAirport terminal = new ShivajiTerminalAirport();
            terminal.NotifyArrived(new ChartredAirCraft("CRAFT_CHART_1", "Amol Choudhari", 3000));
            terminal.NotifyArrived(new ChartredAirCraft("CRAFT_PASSENG_1", "Sahara Airlines", 5000));
            terminal.NotifyArrived(new ChartredAirCraft("CRAFT_LUGAGE_1", "UPS Airlines", 8000));
            terminal.NotifyArrived(new ChartredAirCraft("CRAFT_CHART_2", "Pramod Choudhari", 3000));
            terminal.NotifyArrived(new ChartredAirCraft("CRAFT_PASSENG_2", "Indian Airlines", 5000));

            terminal.NotifyGreenSignal(terminal.GetNextAirCraft());
        }

        private static void ShowMementoPattern()
        {
            GridRow row = new GridRow();
            row.PropertyName = "Present Value";
            row.PropertyValue = "0.0";
            row.ReadOnly = true;

            RowMemory mem = new RowMemory();
            mem.RowMemento = row.CreateRow();

            try
            {
                //Validation return true
                if (row.ValidateValues())
                {
                    row.PropertyValue = "9999";
                    row.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                //Restore row to original state
                row.SetRow(mem.RowMemento);

            }
            finally
            {
                Console.WriteLine("The Grid row is\n");
                Console.WriteLine("PropertyName PropertyValue  ReadOnly\n");
                Console.WriteLine("{0}          {1}          {2}     ", row.PropertyName, row.PropertyValue, row.ReadOnly);
            }

        }

        private static void ShowObserverPattern()
        {
            PropertiesInPune puneProperties = new PropertiesInPune();
            puneProperties.Attach(new PropertySeeker("Amol"));
            puneProperties.Attach(new PropertySeeker("Pramod"));

            PropertiesInBanglore bangloreProperties = new PropertiesInBanglore();
            bangloreProperties.Attach(new PropertySeeker("Aziz"));
            bangloreProperties.Attach(new PropertySeeker("Anil"));

            //Adding properties
            puneProperties.AddProperty(2, 20030);
            bangloreProperties.AddProperty(3, 9000000);
        }

        private static void ShowStatePattern()
        {
            Car myCar = new Car("BMW");
            myCar.IncreaseSpeed(30);
            myCar.IncreaseSpeed(30);
            myCar.IncreaseSpeed(50);
            myCar.IncreaseSpeed(50);
            myCar.DecreaseSpeed(50);
            myCar.DecreaseSpeed(10);
            myCar.DecreaseSpeed(60);
            myCar.DecreaseSpeed(60);
            myCar.DecreaseSpeed(60);
        }

        private static void ShowStrategyPattern()
        {
            TranslatorContext context = new TranslatorContext(new HindiTranslator());
            context.Add("ProjectName", "Amol");
            context.Add("PropertyName", "Device");
            Dictionary<string, string> output = context.Translate();

            foreach (var item in output)
            {
                Console.WriteLine("{0}", item.Value);
            }
        }

        private static void ShowAbtractFactoryPattern()
        {
            BuildHouseFactory factory1 = new CheapHouseDetails();
            RealEstateClient client1 = new RealEstateClient(factory1);
            client1.ConstructHouses();

            BuildHouseFactory factory2 = new ExpensiveHouseDetails();
            RealEstateClient client2 = new RealEstateClient(factory2);
            client2.ConstructHouses();

        }

        private static void ShowVisiterPattern()
        {
            HouseHoldAgent agent = new HouseHoldAgent();
            FraudCustomer FraudCustomer = new FraudCustomer();
            agent.Attach(new EliteCustomer());
            agent.Attach(new MediumCustomer());
            agent.Attach(FraudCustomer);

            agent.StartWork(new DishWasher());
            Console.WriteLine("\n");
            agent.StartWork(new ClothWasher());


        }
    }
}
