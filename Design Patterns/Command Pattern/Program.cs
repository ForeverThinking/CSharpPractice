using System;

namespace command_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign first argument if any are found
            string argument = args.Length > 0 ? args[0] : null;

            // create new receiver class
            ISubmersible _diver = new Diver();

            // create command objects and assign receiver
            IDepthCommand _diveCommand = new ReleaseAirCommand(_diver);
            IDepthCommand _ascendCommand = new AddAirCommand(_diver);

            // create invoker class and assign commands
            Ballast ballast = new Ballast(_diveCommand, _ascendCommand);

            if (argument == "dive")
            {
                ballast.BlowAir();
            }
            else if (argument == "ascend")
            {
                ballast.AddAir();
            }
            else
            {
                Console.WriteLine("Cannot resolve argument command.");
            }
        }
    }
}
