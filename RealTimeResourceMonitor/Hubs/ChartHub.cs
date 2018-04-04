using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeResourceMonitor
{
    public class ChartHub : Hub 
    {
        public Task Send(int number)
        {
            return Clients.All.SendAsync("RandomNumber", number);
        }
    }
}
