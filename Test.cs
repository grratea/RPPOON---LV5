using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public static class Test
    {
        public static void Run1and2()
        {
            Console.WriteLine("ZADATAK 1 i 2: ");
            Box box = new Box("moving box");
            IShippable socks = new Product("Adidas", 3.99, 0.5);
            IShippable tv = new Product("Samsung", 199.99, 5);
            IShippable book = new Product("LoTR", 10.49, 1);
            box.Add(socks);
            box.Add(tv);
            box.Add(book);

            Console.WriteLine(box.Description());

            Console.WriteLine("Price: " + box.Price);

            Console.WriteLine("Weight: " + box.Weight);

            Console.WriteLine();

            ShippingService service = new ShippingService(3.99);
            Console.WriteLine("Shipping for box: " + service.CalculateShippingPrice(box));
            Console.WriteLine("Shipping for TV: " + service.CalculateShippingPrice(tv));
            Console.WriteLine();
        }

        public static void Run5()
        {
            Console.WriteLine("ZADATAK 5: ");
            ITheme theme = new LightTheme();
            Note note = new ReminderNote("oki doki smoki", theme);
            note.Show();

            theme = new JokerTheme();
            note.Theme = theme;
            note.Show();
        }

        public static void Run6()
        {
            Console.WriteLine("ZADATAK 6:");
            GroupNote first = new GroupNote("oki doki smoki", new JokerTheme());
            first.AddName("Osoba 1");
            first.AddName("Osoba 2");
            GroupNote second = new GroupNote("helloouuu", new LightTheme());
            second.AddName("Osoba 3");

            first.Show();
            Console.WriteLine();
            second.Show();

        }

        public static void Run7() 
        {
            Console.WriteLine("ZADATAK 7: ");
            Notebook notebook = new Notebook(new LightTheme());
            ReminderNote first = new ReminderNote("first heloouu", new LightTheme());

            notebook.AddNote(first);
            notebook.Display();

            Console.WriteLine("********************************");
            ReminderNote second = new ReminderNote("second heloouu", new JokerTheme());

            notebook.AddNote(second);
            notebook.ChangeTheme(new JokerTheme());
            notebook.AddNote(new ReminderNote("third heyyyy", new LightTheme()));
            notebook.Display();
        }

        public static void Run3()
        {
            DataConsolePrinter printer = new DataConsolePrinter();
            IDataset dataset = new Dataset("C:\\Users\\student\\source\\repos\\RPPOON - LV5\\CSV.txt");
            printer.Print(dataset);

            Console.WriteLine();

            IDataset proxy = new VirtualProxyDataset("C:\\Users\\student\\source\\repos\\RPPOON - LV5\\CSV.txt");;
            printer.Print(proxy);

            User user1 = User.GenerateUser("Osoba 1");
            User user2 = User.GenerateUser("Osoba 2");

            Console.WriteLine();

            proxy = new ProtectionProxyDataset(user1);
            printer.Print(proxy);

            Console.WriteLine();
            proxy = new ProtectionProxyDataset(user2);
            printer.Print(proxy);
        }

        public static void Run4() 
        {
            LoggingProxyDataset proxy = new LoggingProxyDataset("C:\\Users\\student\\source\\repos\\RPPOON - LV5\\CSV.txt");
            
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(proxy);
            proxy.LogMessage("trenutak stvaranja");
        }

    }
    
}
