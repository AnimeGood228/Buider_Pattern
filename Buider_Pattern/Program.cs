using Buider_Pattern;
using Buider_Pattern.Сomponents;

class Program
{
    static void Main(string[] args)
    {
       
        var cpu = new CPU("Ryzen 7 7800X", 16);
        var motherboard = new Motherboard("ASUS ROG Strix", "ATX");
        var ram = new RAM("Kingston fury", 32);
        var storage = new Storage("SSD", 1000);
        var gpu = new GPU("NVIDIA GeForce RTX 4070", 10);

        
        var computerBuilder = new ComputerBuilder();
        Computer computer = computerBuilder
            .SetCPU(cpu)
            .SetMotherboard(motherboard)
            .SetRAM(ram)
            .SetStorage(storage)
            .SetGPU(gpu)
            .Build();

        
        Console.WriteLine(computer);
    }
}