using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok
{
   static class TikTokManager
    {
        private static List<TikTok> TIKTOKS;

        private static string FILENAME = "TikTok.txt";

        static TikTokManager()

        {

            

            TIKTOKS = new List<TikTok>();

            try

            {

                // Reading all the lines

                var lines = File.ReadLines(FILENAME);

                // For each line

                foreach (var line in lines)

                {

                    if (lines != null)

                    {

                        // Parse the line and add to list

                        TIKTOKS.Add(TikTok.Parse(line));

                    }

                }

            }

            catch (Exception error)

            {

                Console.WriteLine("File Read Error: " + error.Message);

               
            }

        }

        public static void Initialize()

        {

           

            TIKTOKS.Add(new TikTok("Ruby", "5", "#OOTD", Audience.World));

            TIKTOKS.Add(new TikTok("Khushi", "7", "#YOLO", Audience.Group));

            TIKTOKS.Add(new TikTok("Amit", "7", "#BE YOU", Audience.World));

            TIKTOKS.Add(new TikTok("Milan", "5", "#KHUSHBOO", Audience.Group));

            TIKTOKS.Add(new TikTok("Puja", "6", "#FUNDAY", Audience.Group));

        }


        public static void Show()

        {

            foreach (TikTok tiktok in TIKTOKS)

            {

                Console.WriteLine(tiktok + "\n");

            }

        }

       
        public static void Show(string tag)

        {

            foreach (TikTok tiktok in TIKTOKS)

            {

                // Make both as lower case to make them case insensitive

                if (tiktok.HashTag.ToLower() == tag.ToLower())

                {

                    Console.WriteLine(tiktok + "\n");

                }

            }

        }

        


        public static void Show (Audience audience)
        {
            foreach (TikTok tiktok in TIKTOKS)
            {
                if(tiktok.Audience== Audience.World)
                {
                    Console.WriteLine(tiktok + "\n");
                }

            }

        }

        
    }

}

