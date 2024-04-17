using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{

    class RoomService
    {
        
        int roomId;
        
        int roomtype;
        
        List<int>roomNumbers = new List<int>() { 101, 102, 103, 201, 202, 203, 301, 302, 303 };
        List<int> roomNumber = new List<int>() { 104, 105, 106, 204, 205, 206, 304, 305, 306 };


        

        public List<int> available_rooms()
        {
            if(roomtype == 1) 
            {
                foreach (int room in roomNumbers)
                {
                    Console.WriteLine(room);
                }
                return (roomNumbers);
            }

            else if(roomtype == 2) 
            {
                foreach (int room in roomNumber)
                {
                    Console.WriteLine(room);
                }
                return (roomNumber);
            }

            else
            {   
                return new List<int>();
            }   
        }
        public void roomType()
        {
            for (; ; )
            {
                Console.Write("\n1. Single\n2. Double\nChoice of your room : ");
                roomtype = int.Parse(Console.ReadLine());

                if (roomtype == 1)
                {
                    Console.Write("Person Count :");
                    int count = int.Parse(Console.ReadLine());
                    List<int> newlist = available_rooms();
                    Console.Write("Rooms you want from the above room Id's : ");
                    roomId = int.Parse(Console.ReadLine());
                    if (newlist.Contains(roomId))
                    {

                        Console.WriteLine($"Room Id {roomId} is allocated");
                        newlist.Remove(roomId);
                        //ro = newlist.ToArray();
                    }
                    foreach (int i in newlist)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (roomtype == 2)
                {
                    Console.Write("Person Count : ");
                    int count = int.Parse(Console.ReadLine());
                    List<int> newdoublelist = available_rooms();
                    Console.WriteLine("Rooms you want from the above room Id's : ");
                    roomId = int.Parse(Console.ReadLine());
                    if (newdoublelist.Contains(roomId))
                    {

                        Console.WriteLine($"Room Id {roomId} is allocated");
                        newdoublelist.Remove(roomId);
                        //ro = newdoublelist.ToArray();
                    }
                    foreach (int i in newdoublelist)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if(roomtype==3)
                {

                }
                else
                {
                    available_rooms();
                    Console.WriteLine("Invalid Room Type");
                }
                Console.WriteLine("Want more rooms : ");
                if (Console.ReadLine().ToUpper().Equals("YES"))
                    roomType();
                else
                    break;
                

            }
            Console.Write("Want food service too?? : ");
            if (Console.ReadLine().ToUpper().Equals("YES"))
            {
                FoodService foodService = new FoodService();
                foodService.Menu();
            }
            


            //return ro;
        }
    }
}
