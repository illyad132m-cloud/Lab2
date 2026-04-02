using lab_2_task_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Resolution hd = new(1280, 720);
Resolution fullHd = new(1920, 1080);

Console.WriteLine($"HD: {hd}");
Console.WriteLine($"Full HD: {fullHd}");

Console.WriteLine($"\nМноження Full HD на 0.5: {fullHd * 0.5}");
Console.WriteLine($"Додавання 500 пікселів до HD: {hd + 500}");

Console.WriteLine($"\nЗміна орієнтації HD на портретну: {~hd}");

Console.WriteLine($"\nЯкість Full HD: {(double)fullHd:F2} MP");
Console.WriteLine($"Співвідношення сторін HD: {(string)hd}");

Console.WriteLine($"\nFull HD > HD? {fullHd > hd}");

Resolution extreme = new(10, 30000);
Console.WriteLine($"\nВалідація (ввід 10x30000): {extreme}");
