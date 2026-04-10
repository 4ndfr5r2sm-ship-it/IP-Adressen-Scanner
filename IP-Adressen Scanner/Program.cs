var ips = IpRangeGenerator.Generate("192.168.0.");

var pingService = new PingService();

foreach (var ip in ips)
{
    if (pingService.IsAlive(ip))
    {
        Console.WriteLine($"{ip} ist erreichbar");
    }
}