using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provet_2019_10_03
{
    class Books
    {
        public int price;
        string name = "";
        int rarity;
        string category = "";
        int actualValue;
        bool cursed;
        Random generator = new Random();

        public void Book()
        {
            actualValue = generator.Next(50, 151);
            rarity = generator.Next(1, 4);
            
            if (generator.Next(1, 3) == 1)
            {
                cursed = true;
            }
            else if(generator.Next(1,3) == 2)
            {
                cursed = false;
            }
            List<string> bookNames = new List<string>() { "Snorf", "Lorf", "Dorf", "Horf", "Jorf" };
            List<string> bookCategories = new List<string>() { "Horror", "Fantasy", "Sci-Fi", "Action", "Adventure" };


            name = bookNames[generator.Next(0, 5)];
            category = bookCategories[generator.Next(0, 5)];



        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Category: "+category);
            Console.WriteLine("Rarity: "+rarity);
            Console.WriteLine("Value: "+actualValue);
        }
        //public int Evaluate()
        //{

        //}
        //public string GetCategory()
        //{

        //}
        //public string GetName()
        //{

        //}
        //public bool IsCursed()
        //{

        //}







    }
}
