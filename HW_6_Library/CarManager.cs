﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public static class CarManager
    {
        public static void GetFullCarInfo<T>(T car) where T : Car
        {
            Console.WriteLine($"Number of seats : {car.GetNumberOfSeats()} \nRelease year : {car.GetYear()} \nEngine power : {car.EnginePower}");
        }
        public static void ShowParam<T>(T message)
        {
            Console.Write(message);
        }

    }
}
