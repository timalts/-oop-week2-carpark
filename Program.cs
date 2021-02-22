using System;
using System.Collections.Generic;

namespace parking_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car_list = new List<Car>();
            Car first = new Car(20);
            Car second = new Car(10);
            Car third = new Car(24);
            Car fourth = new Car(13);
            Console.WriteLine($"First car charge: {first.calculateCharges()}");
            Console.WriteLine($"Second car charge: {second.calculateCharges()}");
            Console.WriteLine($"Third car charge: {third.calculateCharges()}");
            Console.WriteLine($"Fourth car charge: {fourth.calculateCharges()}");
            car_list.Add(first);
            car_list.Add(second);
            car_list.Add(third);
            car_list.Add(fourth);
            Parking park = new Parking(car_list);
            Console.WriteLine($"Total parking charges: {park.calculateTotal()}");
        }
    }
}
