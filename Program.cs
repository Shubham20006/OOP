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
            Console.WriteLine("Types Of Rice");
            Console.WriteLine("--------------");
            for (int i = 0; i < Data.typesOfRice.Count; i++)
            {
                Console.WriteLine(Data.typesOfRice[i].name);
                Console.WriteLine(Data.typesOfRice[i].weight);
                Console.WriteLine(Data.typesOfRice[i].price);
                Console.WriteLine("------");
                int val = Data.typesOfRice[i].weight * Data.typesOfRice[i].price;
                Console.WriteLine("The Price for " + Data.typesOfRice[i].weight + "kg is " + val);
                Console.WriteLine("------");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Types Of Pulse");
            Console.WriteLine("--------------");
            for (int i = 0; i < Data.typesOfPulse.Count; i++)
            {
                Console.WriteLine(Data.typesOfPulse[i].name);
                Console.WriteLine(Data.typesOfPulse[i].weight);
                Console.WriteLine(Data.typesOfPulse[i].price);
                Console.WriteLine("------");
                int val = Data.typesOfPulse[i].weight * Data.typesOfPulse[i].price;
                Console.WriteLine("The Price for " + Data.typesOfPulse[i].weight + "kg is " + val);
                Console.WriteLine("------");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Types Of Wheat");
            Console.WriteLine("--------------");
            for (int i = 0; i < Data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(Data.typesOfWheat[i].name);
                Console.WriteLine(Data.typesOfWheat[i].weight);
                Console.WriteLine(Data.typesOfWheat[i].price);
                Console.WriteLine("------");
                int val = Data.typesOfWheat[i].weight * Data.typesOfWheat[i].price;
                Console.WriteLine("The Price for " + Data.typesOfWheat[i].weight + "kg is " + val);
                Console.WriteLine("------");
            }
        }
    }
}