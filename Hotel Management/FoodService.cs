using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    class FoodService
    {

        public FoodService() { }

        public Dictionary<string, int> Menu()
        {
            Console.WriteLine("1. Dosa \n2. Idly \n3. Roast \n4. Naan \n5. Chicken Gravy \n6. Briyani \n7. Exit");
            string[] menu = { "Dosa", "Idly", "Roast", "Naan", "Chicken Gravy", "Briyani" };
            Dictionary<string,int> item = new Dictionary<string,int>();
            Console.Write("Order Please : ");
            int order  = int.Parse(Console.ReadLine())-1;
            if(order >=6)
            {
                goto exit;
            }
            Console.Write("Quantity : ");
            int quantity = int.Parse(Console.ReadLine());
            item.Add(menu[order], quantity);

            

            for (; ; )
            {
                Console.Write("Want to order again : ");
                string opt = Console.ReadLine();
                if (opt.ToUpper().Equals("YES"))
                {
                    Console.Write("Order Please : ");
                    order = int.Parse(Console.ReadLine())-1;
                    Console.Write("Quantity : ");
                    quantity = int.Parse(Console.ReadLine());
                    item.Add(menu[order],quantity);
                    return item;
                }
                else
                {
                    break;
                }
            }



            //foreach (KeyValuePair<string,int> i in item) 
            //{
            //    Console.WriteLine("Your Order");
            //    Console.WriteLine("Item : "+i.Key+"\tQuantity : "+i.Value);
            //}




            Console.Write("Want Room Service too?? : ");
            if (Console.ReadLine().ToUpper().Equals("YES"))
            {
                RoomService roomService = new RoomService();
                roomService.roomType();
            }


            exit:
                Console.WriteLine("Thank You!!");


        }

    }
}
