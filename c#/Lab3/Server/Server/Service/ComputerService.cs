using Server.DAO;

namespace Server
{
    public class ComputerService
    {
        public static void AddComputer(Computer computer)
        {
            var store = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            store.Computers.Add(computer);
            ComputerStoreDao.WriteComputerStoreToFile(store);
        }

        public static void EditComputer(Computer computer)
        {
            var store = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            store.Computers[FindComputerIndexInStore(computer, store)] = computer;
            ComputerStoreDao.WriteComputerStoreToFile(store);
        }

        public static void DeleteComputer(Computer computer)
        {
            var store = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            store.Computers.RemoveAt(FindComputerIndexInStore(computer, store));
            ComputerStoreDao.WriteComputerStoreToFile(store);
        }
        
        public static ComputerStore FindComputerByBrand(Computer computer)
        {
            var computerStoreFromFile = ComputerStoreDao.ReadComputerStoreFromFileOrReturnNew();
            ComputerStore store = new ComputerStore();
            
            string brand = computer.Brand;
          
            foreach (var comp in computerStoreFromFile.Computers)
            {
                if (comp.Brand.Equals(brand))
                {
                    store.Computers.Add(comp);
                }
            }
            return store;
        }

        private static int FindComputerIndexInStore(Computer computer, ComputerStore store)
        {
            var index = -1;

            for (int i = 0; i < store.Computers.Count; i++)
            {
                if (computer.Id.Equals(store.Computers[i].Id))
                {
                    index = i;
                }
            }

            return index;
        }
    }
}