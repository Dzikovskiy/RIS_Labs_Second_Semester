using System;
using RisLab2.DAO;

namespace RisLab2
{
    public class ComputerService
    {
        public static void AddComputer(Computer computer)
        {
            var store = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            store.Computers.Add(computer);
            ComputerStoreDao.WriteComputerStoreToFile(store);
        }
    }
}