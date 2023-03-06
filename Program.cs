using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Finals
{
    class Program
    {
        static List<string> todays = new List<string>() { " ADOBONG MANOK = 65 pesos", " SINIGANG = 65 pesos", " MENUDO = 50 pesos", " PORK BINAGOONGAN = 50 pesos", " BEEF TERIYAKI = 75 pesos" };
        static List<int> TMPrice = new List<int>() { 65, 65, 50, 50, 75 };
        static List<string> Schoolsupplies = new List<string>(){" ManilaPaper = 10 pesos", " Ink GELPEN = 15 pesos" , " CATLEYA NOTEBOOK = 16 PESOS" ,
                                                    " CATLEYA BINDER = 150 Pesos", " MARKER = 10 pesos"};
        static List<int> SSPrice = new List<int>() { 10, 15, 16, 150, 10 };

        static List<string> snacks = new List<string>(){" Shawarma = 60 pesos", " Hotdog Sandwhich = 45 pesos" , " Bag of PopCorn = 20 PESOS" ,
                                                    " kwek-kwek = 50 Pesos per 5 pcs", " takoyaki =  30 pesos for 4 pcs"};
        static List<int> SPrice = new List<int>() { 60, 45, 20, 50, 30 };

        static List<string> merch = new List<string>(){" Lanyard = 149 pesos", " Iskolar club tote bag = 168 pesos" , " Iskolar classic shirt = 218 pesos" ,
                                                    " Iskolar skewd shirt = 200 Pesos", " iskolar minimalist =  220 pesos"};
        static List<int> Pmerch = new List<int>() { 149, 168, 218, 200, 220 };

        static List<string> cartlist = new List<string>();

        public static int itemNum;


        static void Main(string[] args)
        {
            string name;
            int num;

            Console.WriteLine(" ____________________________");
            Console.WriteLine("| PRESS ENTER TO ACCESS THE PROGRAM  |");
            Console.WriteLine("|____________________________________|");
            Console.ReadLine();

            try
            {
                Console.WriteLine("");
                Console.WriteLine("ENTER YOUR NAME");
                name = Console.ReadLine();
                Console.WriteLine("ENTER YOUR STUDENT NUMBER");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Welcome  " + name + " " + "BN" + num);
            }
            catch (FormatException e)
            {
                Console.WriteLine("");
                Console.WriteLine("ERROR!! : ENTER ONLY NUMBER PLEASE");
                return;
            }


            while (true)
            {

                ShowMenu();
                string input = GetInput();

                switch (input)
                {
                    case "1":
                        string ans1;
                        int totalPrice = 0;
                        TodaysMenu();
                        do
                        {

                            Console.WriteLine("");
                            Console.WriteLine("WHAT ITEM DO YOU WANT TO ADD TO YOUR CART");
                            itemNum = Convert.ToInt32(Console.ReadLine());
                            cartlist.Add(todays[itemNum - 1]);

                            totalPrice += TMPrice[itemNum - 1];
                            Console.WriteLine($"Item added to cart: {todays[itemNum - 1]}");
                            Console.WriteLine($"Current total price: {totalPrice} pesos");

                            Console.WriteLine("Do you want to add more? (yes/no)");
                            ans1 = Console.ReadLine();
                        }
                        while (ans1.ToLower() != "no");


                        break;


                    case "2":
                        string ans2;
                        int totalPrice2 = 0;
                        SchoolSupplies();
                        do
                        {

                            Console.WriteLine("");
                            Console.WriteLine("WHAT ITEM DO YOU WANT TO ADD TO YOUR CART");
                            itemNum = Convert.ToInt32(Console.ReadLine());
                            cartlist.Add(Schoolsupplies[itemNum - 1]);

                            totalPrice2 += SSPrice[itemNum - 1];
                            Console.WriteLine($"Item added to cart: {Schoolsupplies[itemNum - 1]}");
                            Console.WriteLine($"Current total price: {totalPrice2} pesos");

                            Console.WriteLine("Do you want to add more? (yes/no)");
                            ans2 = Console.ReadLine();
                        }
                        while (ans2.ToLower() != "no");

                        break;




                    case "3":
                        string ans3;
                        int totalPrice3 = 0;
                        InSnacks();
                        do
                        {

                            Console.WriteLine("");
                            Console.WriteLine("WHAT ITEM DO YOU WANT TO ADD TO YOUR CART");
                            itemNum = Convert.ToInt32(Console.ReadLine());
                            cartlist.Add(snacks[itemNum - 1]);

                            totalPrice3 += SPrice[itemNum - 1];
                            Console.WriteLine($"Item added to cart: {snacks[itemNum - 1]}");
                            Console.WriteLine($"Current total price: {totalPrice3} pesos");

                            Console.WriteLine("Do you want to add more? (yes/no)");
                            ans3 = Console.ReadLine();
                        }
                        while (ans3.ToLower() != "no");


                        break;


                    case "4":

                        string ans4;
                        int totalPrice4 = 0;
                        Merchandise();
                        do
                        {

                            Console.WriteLine("");
                            Console.WriteLine("WHAT ITEM DO YOU WANT TO ADD TO YOUR CART");
                            itemNum = Convert.ToInt32(Console.ReadLine());
                            cartlist.Add(merch[itemNum - 1]);

                            totalPrice4 += Pmerch[itemNum - 1];
                            Console.WriteLine($"Item added to cart: {merch[itemNum - 1]}");
                            Console.WriteLine($"Current total price: {totalPrice4} pesos");

                            Console.WriteLine("Do you want to add more? (yes/no)");
                            ans4 = Console.ReadLine();
                        }
                        while (ans4.ToLower() != "no");


                        break;

                    case "5":
                        // show contents of cart
                        int totalAmount5 = 0;
                        int Price = 0;
                        Console.WriteLine("");
                        Console.WriteLine("YOUR CART:");
                        if (cartlist.Count == 0)
                        {
                            Console.WriteLine("Your cart is empty.");
                        }
                        //shows the total amount
                        else
                        {

                            foreach (string item in cartlist)
                            {
                                Console.WriteLine(item);
                            }

                            Console.WriteLine($"Total items: {cartlist.Count} items"); ;


                            // remove items in the cart 
                            Console.WriteLine("Enter the number of the item you want to remove, or enter 0 to go back:");
                            int itemToRemove = int.Parse(Console.ReadLine());

                            if (itemToRemove != 0 && itemToRemove <= cartlist.Count)
                            {
                                cartlist.RemoveAt(itemToRemove - 1);
                                Console.WriteLine("Item removed from cart.");
                            }
                        }
                        break;



                    case "6":
                        // exit the program
                        Console.WriteLine("SALAMAT SA PAG GAMIT KA ISKO/ISKA");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }



        static void ShowMenu()
        {


            Console.WriteLine("            ____________________________________");
            Console.WriteLine("           |        WELCOME TO PUP SHOP         |");
            Console.WriteLine("           |____________________________________|");
            Console.WriteLine("");
            Console.WriteLine("                  CHOOSE FROM THE MENU");
            Console.WriteLine("____________________________");
            Console.WriteLine("1.TODAY'S MENU");
            Console.WriteLine("2.SCHOOL SUPPLIES");
            Console.WriteLine("3.SNACKS");
            Console.WriteLine("4.MERCHANDISE");
            Console.WriteLine("5.CHECK YOUR CART");
            Console.WriteLine("6.EXIT");
            Console.WriteLine("____________________________");

        }

        static string GetInput()
        {
            Console.Write("What is your choice: ");
            string Input = Console.ReadLine();

            return Input;
        }


        static void TodaysMenu()
        {

            Console.WriteLine("            ____________________________________");
            Console.WriteLine("           |             TODAY'S MENU           |");
            Console.WriteLine("           |____________________________________|");
            Console.WriteLine("");
            Console.WriteLine("*****choose item from 1 - 5*****");
            foreach (var todays in todays)
            {

                Console.WriteLine(todays);

            }

        }



        static void SchoolSupplies()
        {
            Console.WriteLine("            ____________________________________");
            Console.WriteLine("           |             SCHOOL SUPPLIES        |");
            Console.WriteLine("           |____________________________________|");
            Console.WriteLine("");
            Console.WriteLine("*****choose item from 1 - 5*****");
            foreach (var Schoolsupplies in Schoolsupplies)
            {

                Console.WriteLine(Schoolsupplies);
            }

        }



        static void InSnacks()
        {
            Console.WriteLine("            ____________________________________");
            Console.WriteLine("           |               SNACKS               |");
            Console.WriteLine("           |____________________________________|");
            Console.WriteLine("");
            Console.WriteLine("*****choose item from 1 - 5*****");
            foreach (var Snacks in snacks)
            {

                Console.WriteLine(Snacks);
            }

        }


        static void Merchandise()
        {
            Console.WriteLine("            ____________________________________");
            Console.WriteLine("           |               MERCHANDISE          |");
            Console.WriteLine("           |____________________________________|");
            Console.WriteLine("");
            Console.WriteLine("*****choose item from 1 - 5*****");
            foreach (var Merch in merch)
            {

                Console.WriteLine(Merch);
            }

        }
    }
}



