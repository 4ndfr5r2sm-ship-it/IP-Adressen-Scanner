using System.Collections.Generic;

public class IpRangeGenerator
{
    public static List<string> Generate(string baseIp)
    {
        var ips = new List<string>();

        for (int i = 1; i <= 254; i++)
        {
            ips.Add(baseIp + i);
        }

        return ips;
    }
}