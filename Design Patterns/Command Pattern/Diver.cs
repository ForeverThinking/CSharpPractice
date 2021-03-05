using System;

namespace command_pattern
{
    /// <summary>
    /// Receiver class to be controlled
    /// </summary>
    public class Diver : ISubmersible
    {
        public void Ascend()
        {
            Console.WriteLine("Ascending to the surface...");
        }

        public void Dive()
        {
            Console.WriteLine("Decreasing depth...");
        }
    }
}