using System;
using System.IO;

namespace RisLab2.DAO
{
    public class ComputerStoreDao
    {
        public static ComputerStore ReadComputerStoreFromFileOrReturnNew()
        {
            if (File.Exists("store.dat"))
            {
                StreamReader streamReader = new StreamReader("store.dat");

                //reads xml from file
                var strFromFile = streamReader.ReadToEnd();

                streamReader.Close();
                
                //parses xml to string
                var storeFromFile = strFromFile.DeserializeString<ComputerStore>();
                
                return storeFromFile;
            }
            else
            {
                return new ComputerStore();
            }
        }

        public static void WriteComputerStoreToFile(ComputerStore computerStore)
        {
            //create xml form string
            var str = computerStore.SerializeToString();

            //write xml to the file
            FileStream fileStream = new FileStream("store.dat", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(str);
            streamWriter.Close();
        }
    }
}