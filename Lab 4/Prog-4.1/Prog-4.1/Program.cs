using System;
using System.Runtime.InteropServices;

namespace MediaPlay
{
    class Program
    {
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string sound, IntPtr hmod, int flags = 0x0001);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a sound: (1).  Exit 'E'");
                string sound = Console.ReadLine();
                while (!(sound == "1" || sound == "S" || sound == "E"))
                    sound = Console.ReadLine();
                if (sound == "1")
                {
                    Console.WriteLine("Play a music");
                    PlaySound("C:/Users/Jarvis/Downloads/default.wav", IntPtr.Zero);
                }
                if (sound == "E")
                {
                    break;
                }
            }

        }
    }
}
