using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("********************************************************");
            Console.WriteLine("* Fruits Shopping Cart                                 *");
            Console.WriteLine("* Todays Offer                                         *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("* One Apple =  0.60pence (Buy 1 get 1 free)            *");
            Console.WriteLine("* One Orange = 0.25pence (3 for the price of 2)        *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("* You can enter your fruit choice                      *");
            Console.WriteLine("* until you have entered exit                          *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("* Payment owed will be displayed                       *");
            Console.WriteLine("* after exit                                           *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("*********************************\n\n");
            Basket bsk = new Basket();
            while (true)
            {
                Console.WriteLine("* Input your Choice: Apple/Orange/Exit? ");
                string input = Console.ReadLine().ToUpper();
                
                
                if (input.Trim() == "EXIT")
                {
                    Console.WriteLine("Thank you for shopping with us :)");
                    break;
                }
                bsk.AddBasket(input);


            }

            Console.WriteLine("* \nYou need to pay  £{0:0.00}" , bsk.calcOfferBasketTotal());
            Console.ReadLine();



        }
    }
}
