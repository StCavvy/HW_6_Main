namespace HW_6
{
    public class Program
    {
        static void Main()
        {
            Minivan minivan1 = new Minivan()
            {
                ModelName = "Minivan1",
                NumberOfSeats = 4,
                Year = 1999
            };
            Car minivan2 = new Minivan()
            {
                ModelName = "Minivan2(Car)",
                NumberOfSeats = 4,
                Year = 1999
            };
            Console.WriteLine($"Minivan 1 : \n{Convert.ToString(minivan1.GetNumberOfSeats())} \n{Convert.ToString(minivan1.GetYear())}");
            Console.WriteLine($"Minivan 2 : \n{Convert.ToString(minivan1.GetNumberOfSeats())} \n{Convert.ToString(minivan1.GetYear())} \n ");


            Console.WriteLine("Additional tasks!");
            Console.WriteLine("Abstract property : " + Convert.ToString(minivan2.EnginePower) + "\n" + "Abstract method : " + minivan2.GetModelName() + "\n ");
            Console.WriteLine("Generic with type Car :");
            CarManager.GetFullCarInfo(minivan1);
            Console.WriteLine("Generic method ShowParam : ");
            CarManager.ShowParam(minivan1.ModelName);

        }
    }
}
