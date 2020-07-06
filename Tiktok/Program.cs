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
            TikTokManager.Initialize();


            TikTokManager.Show();

            
            TikTokManager.Show("#ootd");

            TikTokManager.Show("5");

            TikTokManager.Show(Audience.World);

            Console.ReadLine();
        }
    }
}
