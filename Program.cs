// See https://aka.ms/new-console-template for more information
// Console.Write("Hello, World!");
// Console.WriteLine("I Love Pizza!");


// Console.WriteLine("\tBroCode"); 
// // This Makes a tab.  the \ initializes an escape sequence
// Console.WriteLine("Bro\bCode");
// Console.ReadKey();
// // Program stops running when you type a key

// int x; // delcaration
// x = 123; // initialization
// int y = 321; // both declaration and initialization
// int z = x + y; //
// int age = 32;
// double height = 300.5;
// // double can store decimals where int cant
// bool alive =  true;
// // boolean
// char symbol = '@';
// a single symbol
// String name = "Bro";
// String userName = symbol + name;



// Console.WriteLine("Your age is " + age);
// Console.WriteLine("Your height is " + height);
// Console.WriteLine("Are you alive " + alive);
// Console.WriteLine("Your symbol is" + symbol);
// Console.WriteLine("Your name is  " + name);
// Console.WriteLine("Your username is  " + userName);

// Console.WriteLine(y);


// constants = immutable 
// const double pi = 3.14159;
// pi = 420;

// double a = 3.14;
// int b =  Convert.ToInt32(a);

// int c = 123;
// double d = Convert.ToDouble(c);

// int e = 321;
// string f = Convert.ToString(e);

// string g = "$";
// char h = Convert.ToChar(g);

// string i = "true";
// bool j = Convert.ToBoolean(i);


// Console.WriteLine(b.GetType());
// Console.WriteLine(d.GetType());
// Console.WriteLine(f.GetType());
// Console.WriteLine(h.GetType());
// Console.WriteLine(j.GetType());

// Console.WriteLine("What's your name?");
// string name =  Console.ReadLine();


// Console.WriteLine("What's your age?");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Hello " + name);
// Console.WriteLine("Sounds like you are " + age + " years old");

// int friends  = 10;
// friends++;
// friends  = friends + 1;
// friends += 1;

// friends  = friends * 2;
// friends *= 2;

// friends = friends / 2;
// friends /= 2;

// int remainder = friends % 2;



// Console.WriteLine(friends);


// double x = 3.23;
// double y = 5;
// double a = Math.Pow(x, 2);
// double b = Math.Sqrt(x);
// double c =  Math.Abs(x);
// double d = Math.Round(x);
// double e = Math.Ceiling(x);
// double f = Math.Floor(x);
// double g = Math.Max(x, y);
// double g = Math.Min(x, y);

// Console.WriteLine(d);

// Random random = new Random();

// // int num = random.Next(1, 21);
// double num1 = random.NextDouble();
// double num2 = random.NextDouble();
// double num3 = random.NextDouble();

// Console.WriteLine("Enter Side A:");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter Side B:");
// double b = Convert.ToDouble(Console.ReadLine());

// double c = Math.Sqrt((a * b) + (b * b));

// Console.WriteLine("The Hypotenuse is : " + c);

// string fullName = "Bro Code";
// string phoneNumber = "123-456-8902";
// string userName = fullName.Insert(0,"@");
// string firstName = fullName.Substring(0,3);
// string lastName = fullName.Substring(4,4);


// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();


// phoneNumber = phoneNumber.Replace("-", "/");
// Console.WriteLine(phoneNumber);
// Console.WriteLine(userName);
// Console.WriteLine(fullName.Length);
// Console.WriteLine(firstName);
// Console.WriteLine(lastName);

// Console.WriteLine("Please Enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());

// if (age > 100)
// {
//   Console.WriteLine("You are too old");
// }
// else if (age >= 18)
// {
//   Console.WriteLine("You are now signed Up!");
// }
// else if (age < 0)
// {
//   Console.WriteLine("You haven't been born yet");
// }
// else
// {
//   Console.WriteLine("You too young fool");
// }

// Console.WriteLine("Please enter name");
// string name = Console.ReadLine();

// if (name == "")
// {
//   Console.WriteLine("Hello" + name);
// }
// else
// {
//   Console.WriteLine("You did not enter your name!");
// }
// Console.WriteLine("What day is it?");
// string day = Console.ReadLine();

// switch(day)
// {
//   case "Monday":
//     Console.WriteLine("It's Monday");
//     break;
//   case "Tuesday":
//     Console.WriteLine("It's Tuesday");
//     break;
//   case "Wednesday":
//     Console.WriteLine("It's Wednesday");
//     break;
//   case "Thursday":
//     Console.WriteLine("It's Thursday");
//     break;
//   case "Friday":
//     Console.WriteLine("It's Friday");
//     break;
//   case "Saturday":
//     Console.WriteLine("It's Saturday");
//     break;
//   case "Sunday":
//     Console.WriteLine("It's Sunday");
//     break;
//  default:
//     Console.WriteLine(day + " is not a day");
//     break;
// }
// Console.WriteLine("Enter Your name:");
// string name = Console.ReadLine();

// while (name == "")
// {
//   Console.WriteLine("Enter Your name:");
//   name = Console.ReadLine();
// }

// Console.WriteLine("Hello " + name);

// for (int i = 0; i <= 10; i++) 
// {
//   Console.WriteLine(i);
// }

// int num = 0;
// for (int i = 0; i <= 10; i++) 
// {
//   for (int j = 0; j <= 10; j++)
//   {
//     num++;
//     Console.WriteLine(num);
//   }
// }


// string[] cars = {"BMW", "Mustang", "Corvette"};
// cars[0] = "Tesla";

// Console.WriteLine(cars[0]);
// Console.WriteLine(cars[1]);
// Console.WriteLine(cars[2]);

// for (int i = 0; i < cars.Length; i++)
// {
//   Console.WriteLine(cars[i]);
// }

// foreach(string car in cars)
// {
//   Console.WriteLine(car);
// }





// string name = "Bro";
// int age = 21;

// singHappyBirhtday(name, age);





// static void singHappyBirhtday(string birthdayBoy, int yearsOld)
// {
//   Console.WriteLine("Happy Birthday To You!");
//   Console.WriteLine("Happy Birthday To You!");
//   Console.WriteLine("Happy Birthday Dear " + birthdayBoy);
//   Console.WriteLine("Happy Birthday To You!");
//   Console.WriteLine("You're " + yearsOld + " years old");

// }


// double x;
// double y;
// double result;

// Console.Write("Enter in number 1:");
// x = Convert.ToDouble(Console.ReadLine());


// Console.Write("Enter in number 2:");
// y = Convert.ToDouble(Console.ReadLine());


// result = Multiply(x, y);

// Console.WriteLine(result);

// Console.ReadKey();


// static double Multiply(double x, double y)
// {
//   double z = x * y;
//   return z;
// }

// static double Multiply(double x, double y, double z)
// {
//   double z = x * y;
//   return z;
// }
// double total = CheckOut(1,2,3);
// Console.WriteLine(total);

// static double CheckOut(params double[] prices)
// {
//   double total = 0;

//   foreach (double price in prices)
//   {
//     total += price;
//   }
//   return total;
// }
// double x;
// double y;
// double result;

// try
// {
//   Console.Write("Enter number 1:");
//   x = Convert.ToDouble(Console.ReadLine());

//   Console.Write("Enter number 2: ");
//   y = Convert.ToDouble(Console.ReadLine());

//   result = x / y;

//   Console.WriteLine("result: " + result);

// }
// catch (FormatException e)
// {
//   Console.WriteLine("Enter only numbers please");
// }

// catch (DivideByZeroException e)
// {
//   Console.WriteLine("Can't divide by zero");
// }

// catch (Exception e)
// {
//   Console.WriteLine("Can't divide by zero");
// }
// finally
// {
//   Console.WriteLine("THanks for visiting");
// }

// double temperature= 20;
// string message;

// if (temperature >= 20)
// {
//   message = "its cold outside";
// }
// else 
// {
//   message = "its warm outside";
// }

// Console.WriteLine(message);

