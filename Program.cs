using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your First Name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter your Middle Initital (you can skip this): ");
            string mInitial = Console.ReadLine();

            Console.WriteLine("Please enter your LastName: ");
            string lName = Console.ReadLine();



            Person a = new Person(fName, lName, mInitial);

            Console.WriteLine("Please enter your Birth Date date (dd/mm/yyyy): ");
            a.BirthDate = Console.ReadLine();

            Console.WriteLine("Address: ");
            a.Address = Console.ReadLine();

            Console.WriteLine("Type of Jewelry(enter 1 for necklace, 2-earrings, 3-rings, 4-bracelet");
            string jewel = Console.ReadLine();

            Console.WriteLine("Please enter the number of items: ");
            int itemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter due date: ");
            string dueDate = Console.ReadLine();

         
            Calculations b = new Calculations();

           

            Product necklace = new Product();
            necklace.Name = "Necklace";
            necklace.Description = "Gold";
            necklace.Price = 5000;
            necklace.Items = 3;
            necklace.MonthlyInterestRate = 1.3M;

            Product earrings = new Product();
            earrings.Name = "Earrings";
            earrings.Description = "Gold";
            earrings.Price = 1500;
            earrings.Items = 5;
            earrings.MonthlyInterestRate = 0.5M;

            Product rings = new Product();
            rings.Name = "Ring";
            rings.Description = "Gold";
            rings.Price = 2000;
            rings.Items = 8;
            rings.MonthlyInterestRate = 0.7M;

            Product bracelet = new Product();
            bracelet.Name = "Bracelet";
            bracelet.Description = "Gold";
            bracelet.Price = 3000;
            bracelet.Items = 4;
            bracelet.MonthlyInterestRate = 1;

            
            Console.WriteLine("Your Name is: " + a.GetFullName());
            Console.WriteLine("Your age is : " + a.GetAge());
            switch (jewel)
            {
                case "1":
                    if (itemNum > necklace.Items)
                    {
                        Console.WriteLine("Can't process... Exceeded max Number of items which is: " + necklace.Items);
                        Console.WriteLine("Press enter to exit...");
                        break;
                    }
                    else
                    {
                        PrintDetails(necklace.Name, itemNum, b.CalculateInterest(necklace.Price, necklace.MonthlyInterestRate), b.CalculateAccruedAmount(necklace.Price, necklace.MonthlyInterestRate, dueDate, itemNum));
                        break;
                    }

                case "2":
                    if (itemNum > earrings.Items)
                    {
                        Console.WriteLine("Exceeded max Number of items: " + earrings.Items);
                        break;
                    }
                    else
                    {
                        PrintDetails(earrings.Name, itemNum, b.CalculateInterest(earrings.Price, earrings.MonthlyInterestRate), b.CalculateAccruedAmount(earrings.Price, earrings.MonthlyInterestRate, dueDate, itemNum));
                        break;
                    }

                case "3":
                    if (itemNum > rings.Items)
                    {
                        Console.WriteLine("Exceeded max Number of items: " + rings.Items);
                        break;
                    }
                    else
                    {
                        PrintDetails(rings.Name, itemNum, b.CalculateInterest(rings.Price, rings.MonthlyInterestRate), b.CalculateAccruedAmount(rings.Price, rings.MonthlyInterestRate, dueDate, itemNum));
                        break;
                    }

                case "4":
                    if (itemNum > bracelet.Items)
                    {
                        Console.WriteLine("Exceeded max Number of items: " + bracelet.Items);
                        break;
                    }
                    else
                    {
                        PrintDetails(bracelet.Name, itemNum, b.CalculateInterest(bracelet.Price, bracelet.MonthlyInterestRate), b.CalculateAccruedAmount(bracelet.Price, bracelet.MonthlyInterestRate, dueDate, itemNum));
                        break;
                    }

            }
           
            

            Console.ReadLine();
        }

        static void PrintDetails(string name, int itemNum, decimal interest, decimal accruedAmount)
        {
            Console.WriteLine("Jewelry Purchased: " + name);
            Console.WriteLine("Number of items purchased: " + itemNum);
            Console.WriteLine("Your Interest is: " + interest);
            Console.WriteLine("Your Accrued Amount is: " + accruedAmount);
        }
    }


    

   
}
