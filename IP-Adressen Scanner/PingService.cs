using System.Net.NetworkInformation;

public class PingService
{
    public bool IsAlive(string ip)
    {
        Ping ping = new Ping();
        var reply = ping.Send(ip, 500);
        return reply.Status == IPStatus.Success;
    }
}