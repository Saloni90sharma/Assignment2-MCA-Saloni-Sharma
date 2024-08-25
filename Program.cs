using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment2 Question1 ");
            A2Q1 obj1 = new A2Q1();
            obj1.Function1();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question2 ");
            A2Q2 obj2 = new A2Q2();
            obj2.Function2();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question3");
            A2Q3 obj3 = new A2Q3();
            obj3.Function3();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question4");
            A2Q4 obj4 = new A2Q4();
            obj4.Function4();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question5");
            A2Q5 obj5 = new A2Q5();
            obj5.Function5();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question6");
            A2Q6 obj6 = new A2Q6();
            obj6.Function6();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question7");
            A2Q7 obj7 = new A2Q7();
            obj7.Function7();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question8");
            A2Q8 obj8 = new A2Q8();
            obj8.Function8();
            Console.ReadLine();

            Console.WriteLine("Assignment2 Question9");
            A2Q9 obj9 = new A2Q9();
            obj9.Function9();
            Console.ReadLine();

            Console.WriteLine("Assignment1 Question10");
            A2Q10 obj10 = new A2Q10();

            Console.Write("Enter hourly wage: Rs. ");
            double hourlyWage = double.Parse(Console.ReadLine());

            Console.Write("Enter hours worked per week: ");
            double hoursPerWeek = double.Parse(Console.ReadLine());


            obj10.Function10(hourlyWage, hoursPerWeek);
        }
    }

    class A2Q1
    {
        private double totalPrice;
        public void Function1()
        {
            double[] itemPrices = { 500.0, 1500.0, 800.0, 1200.0, 700.0 };
            totalPrice = 0;
            foreach (double price in itemPrices)
            {
                totalPrice += price;
            }
            if (totalPrice > 3000)
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine("Total price of the item in the cart: Rs. " + totalPrice);
        }
    }

    class A2Q2
    {
        public void Function2()
        {
            double fahrenheit;
            double celsius;
            Console.WriteLine("Enter the temperature in celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature convert into fahrenheit: {fahrenheit}F");
            if (celsius < 0)
            {
                Console.WriteLine("Warning : Freezing Temperature");
            }
        }
    }

    class A2Q3
    {
        private decimal balance = 1000.0m;
        public void Function3()
        {

            while (true)
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit Money");
                Console.WriteLine("3.Withdraw money");
                Console.WriteLine("Exit");
                Console.WriteLine("Choose an option from the above");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Balance:{balance:C}");
                        break;
                    case 2:
                        Console.WriteLine("Enter deposit amount:");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine($"Deposited{deposit:C}.New Balance:{balance:C}");
                        break;
                    case 3:
                        Console.WriteLine("Enter withdrawing amount");
                        decimal withdraw = decimal.Parse(Console.ReadLine());
                        if (withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine($"Withdraw{withdraw:C}.New Balance:{balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM.");
                        return;
                    default:
                        Console.WriteLine("Invalid option.Try again.");
                        break;
                }

            }

        }
    }

    class A2Q4
    {
        public void Function4()
        {
            const int NumberOfSubjects = 5;
            int[] marks = new
            int[NumberOfSubjects];
            int total = 0;
            for (int i = 0; i < NumberOfSubjects; i++)
            {
                Console.Write($"Enter the marks for subject{i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }
            double average = (double)total / (double)NumberOfSubjects;
            char grade;
            if (average >= 90)
                grade = 'A';
            else if (average >= 80)
                grade = 'B';
            else if (average >= 70)
                grade = 'C';
            else if (average >= 60)
                grade = 'D';
            else
            {
                grade = 'F';
            }
            Console.WriteLine($"\nAverage Marks: {average:F2}");
            Console.WriteLine($"Grade: {grade}");

        }
    }

    class A2Q5
    {
        public void Function5()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();


            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");
            }
        }
        static bool IsValidPassword(string password)
        {

            if (password.Length < 8)
                return false;


            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;


            if (!Regex.IsMatch(password, @"\d"))
                return false;


            return true;
        }
    }

    class A2Q6
    {
        public void Function6()
        {

            const double flatRate = 20.0;
            const double perKilometerRate = 10.0;
            const double nightSurchargeRate = 1.5;
            const int nightSurchargeStartHour = 22;


            Console.Write("Enter the distance traveled (in kilometers): ");
            double distance = double.Parse(Console.ReadLine());


            Console.Write("Enter the hour the ride started (0-23): ");
            int hour = int.Parse(Console.ReadLine());


            double fare;
            if (distance <= 2)
            {
                fare = flatRate;
            }
            else
            {
                fare = flatRate + (distance - 2) * perKilometerRate;
            }


            if (hour >= nightSurchargeStartHour || hour < 6)
            {
                fare *= nightSurchargeRate;
            }

            Console.WriteLine($"The total fare is: Rs. {fare:F2}");
        }
    }

    class A2Q7
    {
        public void Function7()
        {
            const int totalDays = 5;
            bool[] attendance = new bool[totalDays];
            int daysAttended = 0;


            for (int i = 0; i < totalDays; i++)
            {
                Console.Write($"Did the student attend on day {i + 1}? (y/n): ");
                char input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (input == 'y')
                {
                    attendance[i] = true;
                    daysAttended++;
                }
                else if (input == 'n')
                {
                    attendance[i] = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
                    i--;
                }
            }


            Console.WriteLine($"\nTotal number of days attended: {daysAttended}");


            if (daysAttended == totalDays)
            {
                Console.WriteLine("The student has perfect attendance.");
            }
            else
            {
                Console.WriteLine("The student does not have perfect attendance.");
            }
        }
    }

    class A2Q8
    {
        public void Function8()
        {
            const int NumberOfMonths = 12;
            double[] expenses = new double[NumberOfMonths];
            double totalExpenses = 0;
            int monthWithHighestExpense = 0;
            int monthWithLowestExpense = 0;


            for (int i = 0; i < NumberOfMonths; i++)
            {
                Console.Write($"Enter the expenses for month {i + 1}: ");
                expenses[i] = double.Parse(Console.ReadLine());
                totalExpenses += expenses[i];


                if (expenses[i] > expenses[monthWithHighestExpense])
                {
                    monthWithHighestExpense = i;
                }


                if (expenses[i] < expenses[monthWithLowestExpense])
                {
                    monthWithLowestExpense = i;
                }
            }

            Console.WriteLine($"\nTotal expenses for the year: Rs. {totalExpenses:F2}");


            Console.WriteLine($"Month with the highest expense: {GetMonthName(monthWithHighestExpense)} (Rs. {expenses[monthWithHighestExpense]:F2})");


            Console.WriteLine($"Month with the lowest expense: {GetMonthName(monthWithLowestExpense)} (Rs. {expenses[monthWithLowestExpense]:F2})");
        }


        static string GetMonthName(int monthIndex)
        {
            string[] months = {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
            };
            return months[monthIndex];
        }
    }

    class A2Q9
    {
        private List<(string Name, double Price)> cartItems = new List<(string Name, double Price)>();
        public void AddItem(string name, double price)
        {
            cartItems.Add((name, price));
            Console.WriteLine($"{name} added to the cart.");
        }

        public void RemoveItem(string name)
        {
            var item = cartItems.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (item != default)
            {
                cartItems.Remove(item);
                Console.WriteLine($"{name} removed from the cart.");
            }
            else
            {
                Console.WriteLine($"{name} not found in the cart.");
            }
        }

        public void ViewCart()
        {
            if (cartItems.Count == 0)
            {
                Console.WriteLine("The cart is empty.");
                return;
            }

            Console.WriteLine("\nItems in your cart:");
            foreach (var item in cartItems)
            {
                Console.WriteLine($"- {item.Name}: Rs. {item.Price:F2}");
            }

            Console.WriteLine($"\nTotal Price: Rs. {cartItems.Sum(item => item.Price):F2}");
        }

        public void Function9()
        {
            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine("\nShopping Cart Options:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter the name of the item: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the price of the item: ");
                        if (double.TryParse(Console.ReadLine(), out double price))
                        {
                            AddItem(name, price);
                        }
                        else
                        {
                            Console.WriteLine("Invalid price. Please try again.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter the name of the item to remove: ");
                        string itemNameToRemove = Console.ReadLine();
                        RemoveItem(itemNameToRemove);
                        break;

                    case "3":
                        ViewCart();
                        break;

                    case "4":
                        shopping = false;
                        Console.WriteLine("Thank you for shopping!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }

    class A2Q10
    {
        public double CalculateMonthlySalary(double hourlyWage, double hoursPerWeek)
        {
            const int WeeksInMonth = 4;
            double weeklySalary = hourlyWage * hoursPerWeek;
            double monthlySalary = weeklySalary * WeeksInMonth;
            return monthlySalary;
        }
        public void Function10(double hourlyWage, double hoursPerWeek)
        {
            double monthlySalary = CalculateMonthlySalary(hourlyWage, hoursPerWeek);
            Console.WriteLine($"\nHourly Wage: Rs. {hourlyWage:F2}");
            Console.WriteLine($"Hours Worked Per Week: {hoursPerWeek:F2}");
            Console.WriteLine($"Monthly Salary: Rs. {monthlySalary:F2}");
        }
    }

}