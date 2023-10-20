using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Minivan : Car
    {
        public override int EnginePower { get; }

        public Minivan()
        {
            EnginePower = 1100;
        }
        public override int GetNumberOfSeats()
        {
            NumberOfSeats = 10;
            return NumberOfSeats;
        }
        public new int GetYear()
        {
            return Year++;
        }
    }
}
