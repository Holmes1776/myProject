using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myProject
{
    class Games
    {
        static void Main(string[] args)
        {
            game red_dead_redemption_2 = new game();
            red_dead_redemption_2.SetPrice(60);
            red_dead_redemption_2.SetTitle("Red Dead Redemption 2");
            red_dead_redemption_2.SetStudio("Rockstar");
            game transactions = new game();
            transactions.SetTrans();

            game witcher3 = new game();
            Console.WriteLine("Please enter the games Price: ");
            witcher3.SetPrice(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the games name: ");
            witcher3.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the Studio's name: ");
            witcher3.SetStudio(Console.ReadLine());
            transactions.SetTrans();

            game skyrim = new game(20, "Skyrim", "Bethesda");
            transactions.SetTrans();

            Console.WriteLine("Please enter the games price: ");
            int tempid = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the games name: ");
            string tempName = Console.ReadLine();
            Console.WriteLine("Please enter the Studio's name: ");
            string tempAuthor = Console.ReadLine();
            game fallout = new game(tempid, tempName, tempAuthor);
            transactions.SetTrans();


            Console.WriteLine($"The store has sold {transactions.GetTrans()} games");
            displayBooks(red_dead_redemption_2);
            displayBooks(witcher3);
            displayBooks(skyrim);
            displayBooks(fallout);
        }

        static void displayBooks(game entry)
        {
            Console.WriteLine("List of information about the game sold");
            Console.WriteLine($"Game Price: {entry.GetPrice()}");
            Console.WriteLine($"Game Name: {entry.GetTitle()}");
            Console.WriteLine($"Studio Name: {entry.GetStudio()}");
        }
    }
    class game
    {
        int _Price;
        string _Title;
        string _Studio;
        private static int _transactions = 0;


        public game()
        {
            _Price = 0;
            _Title = "";
            _Studio = "";
        }

        public game(int id, string title, string studio)
        {
            _Price = id;
            _Title = title;
            _Studio = studio;
        }

        public int GetPrice()
        {
            return _Price;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetStudio()
        {
            return _Studio;
        }

        public void SetPrice(int price)
        {
            _Price = price;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetStudio(string studio)
        {
            _Studio = studio;
        }

        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }
    }
}
