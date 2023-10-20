using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public abstract class Car
    {
        public abstract int EnginePower { get; }
        public int NumberOfSeats { get; set; }
        public string? ModelName { get; set; }
        public string? VINCode { get; init; }
        public int Year { get; set; }


        public abstract string GetModelName();
        public virtual int GetNumberOfSeats() { return NumberOfSeats; }
        public int GetYear() { return Year; }
    }
}
