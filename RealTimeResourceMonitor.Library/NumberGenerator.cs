using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RealTimeResourceMonitor.Library
{
    public class NumberGenerator
    {

        private int GenerateRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 100);

            return number;
        }

    }
}
