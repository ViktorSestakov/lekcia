class Computer
{
    public string CPU { get; set; } = "";
    public int RAM { get; set; }
    public int SSD { get; set; }
    public string GPU { get; set; } = "Встроенная";

    public void ShowInfo()
    {
        Console.WriteLine($"Процессор: {CPU}");
        Console.WriteLine($"ОЗУ: {RAM} ГБ");
        Console.WriteLine($"SSD: {SSD} ГБ");
        Console.WriteLine($"Видеокарта: {GPU}");
    }
}

class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRAM(int ram)
    {
        computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetSSD(int ssd)
    {
        computer.SSD = ssd;
        return this;
    }

    public ComputerBuilder SetGPU(string gpu)
    {
        computer.GPU = gpu;
        return this;
    }

    public Computer Build()
    {
        Computer result = computer;
        computer = new Computer();
        return result;
    }
}

class Program
{
    static void Main()
    {
        Computer officePC = new ComputerBuilder()
            .SetCPU("Intel Core i3")
            .SetRAM(8)
            .SetSSD(256)
            .Build();

        Computer gamingPC = new ComputerBuilder()
            .SetCPU("Intel Core i7")
            .SetRAM(32)
            .SetSSD(1000)
            .SetGPU("NVIDIA RTX 5070")
            .Build();

        Console.WriteLine("Офисный компьютер:");
        officePC.ShowInfo();

        Console.WriteLine();

        Console.WriteLine("Игровой компьютер:");
        gamingPC.ShowInfo();
    }
}
