using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("********************************************************");
            Console.WriteLine("* Fruits Shopping Cart                                 *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("*                                                      *");
            Console.WriteLine("* One Apple =  0.60pence                               *");
            Console.WriteLine("* One Orange = 0.25pence                               *");
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
                string input = Console.ReadLine();
                bsk.AddBasket(input);
                
                if (input.Trim() == "exit")
                {
                    break;
                }


            }

            Console.WriteLine("* \nYou need to pay  £{0:0.00}" , bsk.calcBasketTotal());
            Console.ReadLine();



        }
    }
}
