using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_project
{
    public class ClassMain
    {
        public static async void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person person = new Person("Erik");
            person.BirthdayYear = 2000;
            person.ShowAge();

            Employee employee = new Employee();
            employee.Name = "Dasha";
            employee.Wages = 3000;
            float salary = employee.Income(employee.Wages);
            Console.WriteLine(employee.Name + "receives " + salary);
            Senior senior = new Senior();
            senior.Name = "Melissa";
            senior.Experience = 10;
            float pension = senior.Income(1000);
            Console.WriteLine(senior.Name + "receives " + pension);


            //Display the multiplication table !!!ne dodelano!!!
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++) 
                {
                    int multiply = i * j;

                }
            }

            //Ask the user for 4 numbers and output the largest four-digit number made from them.!!!ne dodelano!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            int[] numbers4 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"The {i + 1} number is: ");
                numbers4[i] = Convert.ToInt32(Console.ReadLine());
                int maxNumber = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) continue;
                    for (int k = 0; k < 4; k++)
                    {
                        if (i == k || j == k) continue;
                        for (int l = 0; l < 4; l++)
                        {
                            if (l == i || l == j || l == k) continue;
                            int formedNumber = numbers4[i] * 1000 + numbers4[j] * 100 + numbers4[k] * 10 + numbers4[l];
                            if (formedNumber > maxNumber)
                            {
                                maxNumber = formedNumber;
                            }
                        }
                    }
                    Console.WriteLine($"The largest four-digit number is {maxNumber}");
                }
            }




            //What number did the computer come up with? Use at least 5 trials to find out.
            Random random = new Random();
            int computerComeUpWith = random.Next(1, 15);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the number that the computer come up with: ");
                int trial = Convert.ToInt32(Console.ReadLine());
                if (trial == computerComeUpWith)
                {
                    Console.WriteLine($"You find out! The number was {computerComeUpWith}");
                    break;
                }
            }


            //Randomly generate the numbers N and M and put the numbers N to M in the array.
            //Print the number squares on the screen. The numbers of N and M are in the range (-100,100).
            int N = random.Next(-100, 100);
            int M = random.Next(-100, 100);
            Console.WriteLine("N={0}, M={1}", N, M);
            if (N > M)
            {
                int help;
                help = N;
                N = M;
                M = help;
            }
            Console.WriteLine("N={0}, M={1}", N, M);
            int[] twoNumbers = new int[M - N + 1];
            for (int i = 0; i < twoNumbers.Length; i++)
            {
                twoNumbers[i] = N;
                Console.Write("{0} ", Math.Pow(twoNumbers[i], 2));
                N++;
            }
            Console.ReadLine();
            Console.Clear();

            //Ask the user for five numbers, store them in an array, and output their sum, arithmetic mean, and product.
            int[] numbers = new int[5]; // creating an array for 5 numbers
            int sum = 0;
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Input a number {i + 1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                // reading the number from console and saving it to the array

                sum += numbers[i];
                product *= numbers[i];

            }
            double mean = sum / (double)numbers.Length;
            Console.WriteLine($"The sum: {sum}");
            Console.WriteLine($"Arithmetic mean: {mean}");
            Console.WriteLine($"Product: {product}");

            Console.ReadLine();
            Console.Clear();

            //Play to Elephant!
            string buyTheElephant = "Buy the elephant!!! ";
            string userInput;
            do
            {
                Console.WriteLine(buyTheElephant);
                userInput = Console.ReadLine();
            } while (userInput.ToLower() != "elephant");

            Console.ReadLine();
            Console.Clear();

            //
            int r = random.Next(5, 10);
            double ra = random.NextDouble() * 10;

            double[,] determ = new double[r, r];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    determ[i, j] = Math.Round(ra, 2);
                    Console.Write(" " + determ[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();

            //
            string[] letters = new string[5] { "A", "E", "U", "I", "O" };
            int num = 0;
            while (num < 5)
            {
                Console.WriteLine("1.{0}. Letter is {1}", num, letters[num]);
                num++;
            }
            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("2.{0}. Letter is {1}", n, letters[n]);
            }
            int y = 0;
            foreach (string l in letters)
            {
                Console.WriteLine("3.{0}. Letter is {1}", y, l);
                y++;
            }
            int d = 0;
            do
            {
                Console.WriteLine("4.{0}. Letter is {1}", d, letters[d]);
                d++;
            } while (d < 5);
            Console.ReadLine();
            Console.Clear();


            ConsolekeyInfo key = new ConsolekeyInfo();
            do
            {
                Console.WriteLine("Press Backspase button!");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.BackSpace);

            int a = 0;
            while(a < 10)
            {
                Console.WriteLine(a);
                a++;
            }

            Person female = new Person();
            female.Name = "Leah";
            female.Age = 18;
            Person male = new Person("Tyrion");
            male.Age = 100;
            List<Person> people = new List<Person>();
            people.Add(female);
            people.Add(male);
            people.Add(new Person() { Name = "Deniss", Age = 32 });
            foreach (Person pers in people)
            {
                Console.WriteLine(pers.Name + ", your age is " + pers.Age + " years old");
            }

            Dictionary<int, Person> students = new Dictionary<int, Person>();
            students.Add(1, female);
            students.Add(2, male);
            students.Add(3, new Person() { Name = "Deniss", Age = 32 });
            foreach (Person student in students)
            {
                Console.WriteLine(student.Name);
            }
            foreach (KeyValue<int, Person> student in students)
            {
                Console.WriteLine(students.Key + ": " + student.Value.Name + "(" + student.Value.Age + ")");
            }

            List<string> months = new List<string>();
            try
            {
                foreach (string row in File.ReadAllLines(@"months.txt"))
                { 
                    months.Add(row);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error with the file!");
            }
            foreach (string row in months)
            {
                Console.WriteLine(row);
            }
            months.Remove("June");
            months[0] = "...............";
            Console.WriteLine("Deleting the month June");

            ArrayList arrayList = new ArrayList();
            arrayList.Add("First");
            arrayList.Add("Second");
            arrayList.Add("Third");
            console.WriteLine("What to find?");
            string value = console.ReadLine();
            if (value !=null)
            {
                if (arrayList.contains(value))
                {
                    console.writeline("Total: " + arrayList.Count);
                    console.WriteLine("There is the word,\nThe " + arrayList.IndexOf(value) + "is in here!");
                }
            }
            else
            {
                    console.writeline("You needed to search for something...");
            }
            arrayList.Insert(3, "Fourth");
            arrayList.removeat(0);
            arrayList.remove(value);
            for (int i = 0; i < arrayList.count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }





            Console.WriteLine("Hello, World!");

            string nimi = "Python";
            Funktisioonid.Tervitus(nimi);


            int a = 0;
            string tekst = "Tere";
            char taht= 'A';
            double arv = 3.55555;
            float arv1 = 2;
            int korrutis = Funktisioonid.Korruta((int)arv, (int)arv1);
            Console.WriteLine(korrutis);

            Console.WriteLine(tekst);
            Console.WriteLine(taht);
            Console.Write("Sisesta uus parameeter a: ");
            a=int.Parse(Console.ReadLine());

            Console.Write("Tehe: ");
            taht=char.Parse(Console.ReadLine());
            if (taht=='+') // && - and, || - or, ! - not
            {
                Console.WriteLine("Arvude {0}, {1} ja {2} summa={3}",a,arv,arv1,arv+arv1+a);
            }
            else if (taht == '*')
            {
                Console.WriteLine("Arvude {0}, {1} ja {2} korrutis={3}", a, arv, arv1, arv * arv1 * a);
            }
            else
            {
                Console.WriteLine("Kirjuta ise!");
            }
            /*
             nimi: Juku-ga lähame kinno! 
             vanus: Kui vana Juku on. 
             pilet: Tasuta,Laste,Täis,Soodus. Viga! kui <0, >123
            /
            Console.WriteLine("Tere!\nMis on sinu nimi?");
            nimi = Console.ReadLine();
            Console.WriteLine("Tere " + nimi);
            if (nimi.ToUpper() == "JUKU")
            {
                Console.WriteLine("Lähme kinno!");
                try
                {
                    Console.WriteLine("{0},\nKui vana sa oled?", nimi);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 123)
                    {Console.WriteLine("Viga!");}
                    else if (vanus > 0 && vanus <= 6)
                    {Console.WriteLine("Tasuta pilet!");}
                    else if (vanus <= 15)
                    {Console.WriteLine("Lastepilet!");}
                    else if (vanus <= 65)
                    {Console.WriteLine("Täispilet!");}
                    else if (vanus <= 100)
                    {Console.WriteLine("Sooduspilet!");}
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Mõtle ise reaktsioon välja!");
            }
            Console.WriteLine("Switch'i kasutamine");
            Random random = new Random();
            int paeva_nr = random.Next(1, 7);
            string paev;
            Console.WriteLine(paeva_nr);
            switch (paeva_nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Tundmatu päev";
                    break;
            }
            Console.WriteLine(paev);
            */
        }
    }
}
