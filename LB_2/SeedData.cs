namespace LB_2;

public static class SeedData
{
    public static void Seed(ComputerDbContext context)
    {
        if (!context.HardDrives.Any())
        {
            var intel1 = new Processor()
            {
                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel2 = new Processor()
            {

                Name = "Intel Core i5-8400",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 8,
                ProcessorModel = "8400",
                ClockFrequency = 3400,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 8000
            };
            var intel3 = new Processor()
            {

                Name = "AMD FX-6100",
                ProcessorManufacturer = "AMD",
                ProcessorSeries = "FX-6100",
                ProcessorGeneration = 6,
                ProcessorModel = "6100",
                ClockFrequency = 3300,
                SocketType = "socket",
                NumCores = 4,
                NumThreads = 6,
                Price = 1750
            };
            var intel4 = new Processor()
            {

                Name = "AMD Ryzen 3 4100",
                ProcessorManufacturer = "AMD",
                ProcessorSeries = "Ryzen 3",
                ProcessorGeneration = 4,
                ProcessorModel = "4100",
                ClockFrequency = 3800,
                SocketType = "socket",
                NumCores = 4,
                NumThreads = 8,
                Price = 2500
            };
            var intel5 = new Processor()
            {

                Name = "AMD Ryzen 7 5700X",
                ProcessorManufacturer = "AMD",
                ProcessorSeries = "Ryzen 7",
                ProcessorGeneration = 5,
                ProcessorModel = "5700",
                ClockFrequency = 3400,
                SocketType = "socket",
                NumCores = 8,
                NumThreads = 16,
                Price = 7199
            };
            var intel6 = new Processor()
            {

                Name = "AMD Athlon 3000G",
                ProcessorManufacturer = "AMD",
                ProcessorSeries = "Athlon",
                ProcessorModel = "3000G",
                ClockFrequency = 3500,
                SocketType = "socket",
                NumCores = 2,
                NumThreads = 4,
                Price = 1899
            };
            var intel7 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel8 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel9 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel10 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel11 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel12 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel13 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel14 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel15 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel16 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel17 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel18 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel19 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            var intel20 = new Processor()
            {

                Name = "Intel Core i5-7300",
                ProcessorManufacturer = "Intel",
                ProcessorSeries = "Core i5",
                ProcessorGeneration = 7,
                ProcessorModel = "7300",
                ClockFrequency = 3200,
                SocketType = "socket",
                NumCores = 6,
                NumThreads = 12,
                Price = 10000
            };
            context.Processors.AddRangeAsync(intel1, intel2, intel3, intel4, intel5, intel6, intel7, intel8
                , intel9, intel10, intel11, intel12, intel13, intel14, intel15, intel16, intel17, intel18, intel19, intel20);


            var nvidia = new VideoCard()
            {
                Name = "GTX 1650",
                ClockFrequency = 1500,
                SeriesName = 16,
                VideoMemory = 4096,
                Price = 10000
            };

            var nvidia1 = new VideoCard()
            {
                Name = "RTX 3050",
                ClockFrequency = 1700,
                SeriesName = 30,
                VideoMemory = 4096,
                Price = 13000
            };

            context.VideoCards.AddRangeAsync(nvidia, nvidia1);

            var hdd = new HardDrive()
            {
                Name = "Western Digitle",
                HardDriveType = "HDD",
                StorageSize = 1000,
                ReadWriteSpeed = 150,
                Price = 1000
            };
            var sdd = new HardDrive()
            {
                Name = "Kingston",
                HardDriveType = "SSD",
                StorageSize = 1000,
                ReadWriteSpeed = 550,
                Price = 2000
            };
            context.HardDrives.AddRangeAsync(hdd, sdd);

            var ram1 = new Ram()
            {
                Name = "Kingston Fury",
                TypeMemory = "DDR4",
                Size = 16385,
                OperatingFrequency = 3200,
                Price = 3000
            };
            var ram2 = new Ram()
            {
                Name = "Micron",
                TypeMemory = "DDR3",
                Size = 16385,
                OperatingFrequency = 2666,
                Price = 2000
            };
            context.Rams.AddRangeAsync(ram1, ram2);

            var mother1 = new MotherBoard()
            {
                Name = "Asus",
                Chipset = "mxx",
                FormFactor = "atx",
                Socket = "1700",
                Price = 2000
            };
            var mother2 = new MotherBoard()
            {
                Name = "Gigybite",
                Chipset = "mxx",
                FormFactor = "atx",
                Socket = "amd3",
                Price = 3000
            };
            context.MotherBoards.AddRangeAsync(mother1, mother2);

            var unit1 = new Unit()
            {
                Name = "Article",
                FormFactorMotherBoard = "mxx",
                Height = 200,
                Length = 300,
                Width = 150,
                Price = 2400
            };
            var unit2 = new Unit()
            {
                Name = "Article",
                FormFactorMotherBoard = "mxx",
                Height = 200,
                Length = 300,
                Width = 150,
                Price = 2400
            };
            context.Units.AddRangeAsync(unit1, unit2);

            context.SaveChanges();
        }

    }
}