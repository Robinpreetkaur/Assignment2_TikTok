using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktok
{

    public enum Audience { World, Group, Special };


    class TikTok
    {
        private static  int  _ID=1;

        public string Originator { get; }
        public string Length { get; }
        public string HashTag{ get; }
        public Audience Audience { get; }
        public string Id { get; }

        

        public TikTok(string originator, string length, string hashtag, Audience audience)
        {
           Originator= originator;
            Length = length;
            HashTag = hashtag;
            Audience = audience;
            Id = $"{_ID}";
            _ID++;


        }

        private TikTok(string id, string originator, string length, string hashtag, Audience audience)
        {
            Id = id;
            Originator = originator;
            Length = length;
            HashTag = hashtag;
            Audience = audience;


        }

       

        public override string ToString()
        {
           
        
            return $"TikTok Details\n  ID: {Id} \n Originator: {Originator} \nLength: {Length} \nHashtag: {HashTag} \nAudience: {Audience}" + "\n";
        }

        public static TikTok Parse(string line)
        {
           string[] obj = line.Split(new char[] {'\t'});
           
          
                TikTok t1 = new TikTok(obj[0], obj[1], obj[2] , obj[3], Audience.Group);
            return t1;
           
            
        }
    }
    }


