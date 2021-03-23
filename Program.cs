using System;

namespace C_fundamental3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockPublisher clockPublisher = new ClockPublisher();
            ClockSubcriber clockSubcriber = new ClockSubcriber();
            clockSubcriber.Subscribe(clockPublisher);

            clockPublisher.Run();
        }
    }
}
