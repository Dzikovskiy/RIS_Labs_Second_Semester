using System;
using RisLab2.DAO;

namespace RisLab2.View
{
    public class Menu
    {
        public void ShowMenu()
        {
            ComputerStoreView computerStoreView = new ComputerStoreView();

            while (true)
            {
                Console.WriteLine("\n1. Add computer");
                Console.WriteLine("2. Edit computer");
                Console.WriteLine("3. Delete computer");
                Console.WriteLine("4. Show all computers");
                Console.WriteLine("5. Show computers sorted by price");
                Console.WriteLine("6. Find computer by name");
                Console.WriteLine("7. Exit\n");


                int number;
                var choose = Console.ReadLine();
                //if number is not correct set it to zero
                if (!int.TryParse(choose, out number))
                {
                    number = 0;
                }

                switch (number)
                {
                    case 1:
                        computerStoreView.AddComputerView();
                        break;
                    case 2:
                        computerStoreView.EditComputerView();
                        break;
                    case 3:
                        computerStoreView.DeleteComputerView();
                        break;
                    case 4:
                        computerStoreView.ShowAllComputers(ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew());
                        break;
                    case 5: 
                        computerStoreView.ShowAllComputersSortedByPrice();
                        break;
                    case 6:
                        computerStoreView.FindComputerByBrand();
                        break;
                    case 7:
                        Console.WriteLine("Exit!");
                        return;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
    }
}