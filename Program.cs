namespace InventoryManagementDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Hp\Desktop\240\InventoryManagementDemo\InventoryManagementDemo\Inventory.json";

            ReadData readData = new ReadData();

            var Data = readData.Read(path);
            Console.WriteLine("--------------");
            Console.WriteLine(" Share Details ");
            Console.WriteLine("--------------");
            for (int i = 0; i < Data.typesOfShare.Count; i++)
            {
                Console.WriteLine(Data.typesOfShare[i].name);
                Console.WriteLine(Data.typesOfShare[i].NumOfShare);
                Console.WriteLine(Data.typesOfShare[i].price);
                Console.WriteLine("------");
                int val = Data.typesOfShare[i].NumOfShare * Data.typesOfShare[i].price;
                Console.WriteLine("The total Price for " + Data.typesOfShare[i].NumOfShare + " share is " + val);
                Console.WriteLine("------");
            }
        }
    }
}
