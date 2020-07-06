using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Display Initilization of TIKTOK:");

            TikTokManager.Initialize();

            Console.WriteLine("Display Show method of TIKTOK");
            TikTokManager.Show();

            Console.WriteLine("Display HashTag  Of TIKTOK:");
            TikTokManager.Show("#OOTD");


            Console.WriteLine("Display With Audience OF TIKTOK");

            TikTokManager.Show(Audience.World);

            Console.ReadLine();
        }
    }
}
