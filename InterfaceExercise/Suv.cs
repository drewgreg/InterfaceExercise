using System;
namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {
        }
        public int CargoSize { get; set; }


        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward.");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park.");
                HasChangedGears = false;
            }
            Console.WriteLine("Can't park until we change gears");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing.");
                HasChangedGears = false;
            }
            Console.WriteLine("Can't reverse until we change gears");
        }
    }
}

