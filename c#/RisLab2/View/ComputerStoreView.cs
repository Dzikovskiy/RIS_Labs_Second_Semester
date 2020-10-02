using System;
using RisLab2.DAO;

namespace RisLab2.View
{
    public class ComputerStoreView
    {
        public void AddComputerView()
        {
            Console.WriteLine("Enter brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter price");
            string price = Console.ReadLine();

            ComputerService.AddComputer(new Computer {Brand = brand, Price = Int32.Parse(price)});
        }

        public void ShowAllComputers(ComputerStore computerStore)
        {
            foreach (var computer in computerStore.Computers)
            {
                Console.WriteLine("Brand: " + computer.Brand + " Price: " + computer.Price);
            }
        }

        public void EditComputerView()
        {
            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            Console.WriteLine("Enter number of computer to edit");

            int number;

            while (true)
            {
                var choose = Console.ReadLine();
                //if number is not correct set it to zero
                if (!int.TryParse(choose, out number))
                {
                    number = 0;
                }

                if (computerFromFile.Computers.Count == 0)
                {
                    Console.WriteLine("Your store are empty");
                    return;
                }

                if (number > computerFromFile.Computers.Count || number <= 0)
                {
                    Console.WriteLine("Wrong number");
                }
                else
                {
                    Console.WriteLine("Enter brand: ");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Enter price");
                    string price = Console.ReadLine();

                    computerFromFile.Computers[number - 1] = new Computer {Brand = brand, Price = Int32.Parse(price)};
                    ComputerStoreDao.WriteComputerStoreToFile(computerFromFile);
                    Console.WriteLine("Computer edited");
                    return;
                }
            }
        }

        public void DeleteComputerView()
        {
            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            Console.WriteLine("Enter number of computer to delete");

            int number;

            while (true)
            {
                var choose = Console.ReadLine();
                //if number is not correct set it to zero
                if (!int.TryParse(choose, out number))
                {
                    number = 0;
                }

                if (computerFromFile.Computers.Count == 0)
                {
                    Console.WriteLine("Your store are empty");
                    return;
                }

                if (number > computerFromFile.Computers.Count || number <= 0)
                {
                    Console.WriteLine("Wrong number");
                }
                else
                {
                    computerFromFile.Computers.RemoveAt(number - 1);
                    ComputerStoreDao.WriteComputerStoreToFile(computerFromFile);
                    Console.WriteLine("Computer deleted");
                    return;
                }
            }
        }

        public void ShowAllComputersSortedByPrice()
        {
            var computerFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();

            computerFromFile.Computers
                .Sort((a, b) => a.Price.CompareTo(b.Price));

            ShowAllComputers(computerFromFile);
        }

        public void FindComputerByBrand()
        {
            var computerStoreFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            
            Console.WriteLine("Enter brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("\n");
            foreach (var computer in computerStoreFromFile.Computers)
            {
                if (computer.Brand.Equals(brand))
                {
                    Console.WriteLine("Brand: " + computer.Brand + " Price: " + computer.Price);
                }
            }
        }
    }
}