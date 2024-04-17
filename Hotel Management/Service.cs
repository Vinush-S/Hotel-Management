using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    class Service
    {
        public void showServices()
        {
            for (; ; )
            {
                Console.WriteLine("\nOur Services");
                Console.Write("\n1. Food \n2. Rooms \n3. Exit \nPlease Select Your Needs :");
                int Need = int.Parse(Console.ReadLine());

                if (Need == 1)
                {
                    FoodService foodService = new FoodService();
                    foodService.Menu();

                }
                else if (Need == 2)
                {

                    RoomService roomService = new RoomService();
                    roomService.roomType();
                    //roomNumber = roomService.roomType();
                }
                else
                {
                    Console.WriteLine("Thank You!!");
                }
                break;
            }
        }
    }
}
