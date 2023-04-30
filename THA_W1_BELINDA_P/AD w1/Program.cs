using static Program;

internal class Program
{ 
    public class Car
    {
        private string Make;
        private string Model;
        private int Year;
        private double Price;
        private string Type;

        public string make
        {
            get
            {
                return Make;
            }
            set
            {
                Make = value;
            }
        }
        public string model
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }
        //public void SetMake(string make)
        //{
        //    this.Make = make;
        //}
        //public void SetModel(string model)
        //{
        //    this.Model = model;
        //}
        public void SetYear(int year)
        {
            this.Year = year;
        }
        public void SetPrice(double price)
        {
            this.Price = price;
        }
        public void SetType(string type)
        {
            this.Type = type;
        }
        public string GetMake()
        {
            return Make;
        }
        public string GetModel()
        {
            return Model;
        }
        public int GetYear()
        {
            return Year;
        }
        public double GetPrice()
        {
            return Price;
        }
        public string GetType()
        {
            return Type;
        }
    }

    public class Electric : Car
    {
        private int BatteryCapacity;

        public void SetBatteryCapacity(int batteryCapacity)
        {
            this.BatteryCapacity = batteryCapacity;
        }
        public int GetBatteryCapacity()
        {
            return BatteryCapacity;
        }
        public Electric()
        {
            SetType("Electric");
        }
    }

    public class Hybrid : Car
    {
        private int GasTankSize;
        private int BatteryCapacity;

        public void SetGasTankSize(int gasTankSize)
        {
            this.GasTankSize= gasTankSize;
        }
        public void SetBatteryCapacity(int batteryCapacity)
        {
            this.BatteryCapacity = batteryCapacity;
        }
        public int GetGasTankSize()
        {
            return GasTankSize;
        }
        public int GetBatteryCapcity()
        {
            return BatteryCapacity;
        }
        public Hybrid()
        {
            SetType("Hybrid");
        }
    }

    public class Gasoline : Car
    {
        private int GasTankSize;

        public void SetGasTankSize(int gasTankSize)
        {
            this.GasTankSize = gasTankSize;
        }
        public int GetGasTankType()
        {
            return GasTankSize;
        }
        public Gasoline()
        {
            SetType("Gasoline");
        }
    }

    public class Dealership
    {
        private string Name;
        private string Location;
        private List<Car> Cars = new List<Car>();
 

        public void GetName(string name)
        {
            Name = name;
        }
        public void GetLocation(string location)
        {
            Location = location;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCar(string carMake, string carModel)
        {
            Car mobilhapus = new Car();
            foreach (var car in Cars)
            {
                if (car.make == carMake && car.model == carModel)
                {
                    mobilhapus = car;
                }
            }
            Cars.Remove(mobilhapus);
        }
        public void PrintCars()
        {
            foreach (var cars in Cars)
            {
                Console.WriteLine("Car Name :" + cars.GetMake());
                Console.WriteLine("Car Model :" + cars.GetModel());
                Console.WriteLine("Car Year :" + cars.GetYear());
                Console.WriteLine("Car Price :" + cars.GetPrice());
                Console.WriteLine("Car Type : " + cars.GetType());
                Console.WriteLine();
                Console.WriteLine("---------------------------------\n");
            }
        }

        List<Sale> sales= new List<Sale>(); // ini list sale history
        List<Car> soldCars = new List<Car>(); // mobil yg ud kejual

        public void MakeSales(Sale sale, Car carSale)
        {           
            sales.Add(sale);
            soldCars.Add(carSale);
        }
        public void PrintSales()
        {
            foreach (var cars in sales)
            {
                foreach (var car in soldCars)
                {
                    Console.WriteLine("Car Name :" + cars.GetCustName());
                    Console.WriteLine("Car Model :" + car.make);
                    Console.WriteLine("Car Year :" + car.model);
                    Console.WriteLine("Car Price :" + cars.GetPricePaid());
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------\n");
                }
            }
        }
    }

    public class Sale : Dealership
    {
        private string CustomerName;
        private Car car;
        private double PricePaid;

        public void SetCustName(string custName)
        {
            this.CustomerName = custName;
        }
        public string GetCustName()
        {
            return CustomerName;
        }
        public void SetPricePaid(double pricePaid)
        {
            this.PricePaid = pricePaid;
        }
        public double GetPricePaid()
        {
            return PricePaid;
        }
        public Car Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }
    }

    public class ExecuteProgram
    {
        private static void Main(string[] args)
        {
            Dealership dealership1 = new Dealership();
            Console.WriteLine("Dealer Name :");
            dealership1.GetName(Console.ReadLine());
            Console.WriteLine("Dealer Location :");
            dealership1.GetLocation(Console.ReadLine());
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Remove Car");
                Console.WriteLine("3. Print All Car");
                Console.WriteLine("4. Make Sales");
                Console.WriteLine("5. Print Sales");
                Console.WriteLine("6. Exit");
                Console.Write("Choose menu :");
                int pilihmenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (pilihmenu == 1)
                {
                    Console.WriteLine("1. Electric");
                    Console.WriteLine("2. Hybrid");
                    Console.WriteLine("3. Gasoline");
                    Console.Write("Choose menu :");
                    int pilihmobil = Convert.ToInt32(Console.ReadLine());

                    if (pilihmobil == 1)
                    {
                        Electric electric = new Electric();

                        Console.Write("Input car make : ");
                        electric.make = Console.ReadLine();
                        Console.Write("Input car model : ");
                        electric.model = Console.ReadLine();
                        Console.Write("Input battery capacity : ");
                        electric.SetBatteryCapacity(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input car year : ");
                        electric.SetYear(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input car price : ");
                        electric.SetPrice(Convert.ToDouble(Console.ReadLine()));

                        dealership1.AddCar(electric);
                    }
                    if (pilihmobil == 2)
                    {
                        Hybrid hybrid = new Hybrid();

                        Console.Write("Input car make : ");
                        hybrid.make = Console.ReadLine();
                        Console.Write("Input car model : ");
                        hybrid.model = Console.ReadLine();
                        Console.Write("Input battery capacity : ");
                        hybrid.SetBatteryCapacity(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input gas tank capacity : ");
                        hybrid.SetGasTankSize(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input car year : ");
                        hybrid.SetYear(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input car price : ");
                        hybrid.SetPrice(Convert.ToDouble(Console.ReadLine()));

                        dealership1.AddCar(hybrid);

                    }
                    if (pilihmobil == 3)
                    {
                        Gasoline gasoline = new Gasoline();

                        Console.Write("Input car make : ");
                        gasoline.make = Console.ReadLine();
                        Console.Write("Input car model : ");
                        gasoline.model = Console.ReadLine();
                        Console.Write("Input gas tank capacity : ");
                        gasoline.SetGasTankSize(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input car year : ");
                        gasoline.SetYear(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input car price : ");
                        gasoline.SetPrice(Convert.ToDouble(Console.ReadLine()));

                        dealership1.AddCar(gasoline);

                    }
                }
                else if (pilihmenu == 2)
                {
                    Console.Write("Car make name :");
                    string carmake = Console.ReadLine();
                    Console.Write("Car model name :");
                    string carmodel = Console.ReadLine();
                    dealership1.RemoveCar(carmake,carmodel);

                }
                else if (pilihmenu == 3)
                {
                    dealership1.PrintCars();
                }
                else if (pilihmenu == 4)
                {
                    Sale sale = new Sale();
                    Car carSale = new Car();

                    Console.Write("Customer name : ");
                    sale.SetCustName(Console.ReadLine());

                    Console.Write("Car make : ");
                    carSale.make = Console.ReadLine();
                    Console.Write("Car model : ");
                    carSale.model = Console.ReadLine();
                    Console.Write("Car year : ");
                    carSale.SetYear(Convert.ToInt32(Console.ReadLine()));

                    Console.Write("Car price : ");
                    sale.SetPricePaid(Convert.ToDouble(Console.ReadLine()));

                    dealership1.RemoveCar(carSale.make, carSale.model);
                    dealership1.MakeSales(sale, carSale);

                }
                else if (pilihmenu == 5)
                {
                    dealership1.PrintSales();
                }
                else
                {
                    break;
                }
            }
        }
    }
    
}