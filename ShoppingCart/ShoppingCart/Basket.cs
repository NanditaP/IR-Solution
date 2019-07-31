using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Basket
    {

        private  List<Fruits> BasketContents;
        public Basket()
        {
            BasketContents = new List<Fruits>();//create a new empty basket
        }

        public void AddBasket(string fruitToBuy)
        {
            Fruits f = new Fruits(fruitToBuy);
            BasketContents.Add(f);//add to the basket list
        }

       /* public double calcBasketTotal()
        {
            double basketTotal = 0.0d;
            foreach (Fruits eachFruit in BasketContents)
            {
                basketTotal += eachFruit.Fprice;
            }

            return basketTotal;
        }*/

        public double calcOfferBasketTotal()
        {
         
            double appleTotal = 0.0d;
            double orangeTotal = 0.0d;
            
            int NoOfApples = 0;
            int NoOfOranges = 0;

            foreach (Fruits eachFruit in BasketContents)
            {
                if (eachFruit.Fname == "APPLE")
                {
                    NoOfApples++;
                    appleTotal += eachFruit.Fprice;
                }
                else if (eachFruit.Fname == "ORANGE")
                {
                    NoOfOranges++;
                    orangeTotal += eachFruit.Fprice;
                }

            }

            //check how many 'buy one get one offers' are possible
            //deduct that amount from the total apple price
            if (NoOfApples > 2)
            {
                appleTotal = appleTotal - ((NoOfApples / 2) * 0.60d);
            }

            //Check the no of 'buy 3 and get 1 offer' and deduct the money from total
            if(NoOfOranges > 2)
            {
                orangeTotal = orangeTotal - ((NoOfOranges / 3) * 0.25d);
            }
            double totSave = ((NoOfApples / 2) * 0.60d) + ((NoOfOranges / 3) * 0.25d);

            if (totSave>0)
            {
                Console.WriteLine("Today you have saved £{0:0.00} ", totSave);
            }
            
            //return the updated basket total
            return appleTotal + orangeTotal;
        }

    }
}
