chonk thechonk = new chonk();
flöf thefluf = new flöf();

Console.WriteLine($"{thechonk.name} har {thechonk.coins} coins och {thechonk.tree} forest ");
Console.WriteLine($"{thefluf.name} har {thefluf.coins} coins and {thefluf.tree} forest");

Console.WriteLine("steal");
thefluf.coins -= 1124523243;

Console.WriteLine($"{thefluf.name} har nu {thefluf.coins} coins");

Console.WriteLine("tryck trä för att fortsätta(enter)");
Console.ReadKey();