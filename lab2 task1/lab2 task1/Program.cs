using lab2_task1;

Console.OutputEncoding = System.Text.Encoding.UTF8;
PcGame Apex = new PcGame("Apex Legends", "Respawn Entertaintment", 2019, "Battle Royale", 0m);
Apex.DisplayInfo();

Console.WriteLine("\nСпроба встановити ціну");

Apex.Price = -10m;
Apex.Price = 100m;

decimal DiscountedPrice = Apex.DiscountedPrice(50m);
Console.WriteLine($"\nЦіна на '{Apex.Title}' зі знижкою 50 %: {DiscountedPrice: F2} ₴");

Console.WriteLine("\nОновлення ціни після ДЛС");

Apex.PriceForDLC();

Console.WriteLine("\nСистемні вимоги");

Apex.SystemReq(32);
Apex.SystemReq(8);




