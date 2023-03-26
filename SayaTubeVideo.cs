using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL6_1302213045
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;
        public SayaTubeVideo(String judul)
        {
            this.title = judul;
            this.playcount = 0;
            Random rand = new Random();
            int randid = rand.Next(00000, 99999);
            this.id = randid;
        }
        public void increaseplaycount(int count)
        {
            this.playcount += count; 
        }
        public void printvideodetails()
        {
            Console.WriteLine("\nID Film : " + this.id);
            Console.WriteLine("Judul Film : " + this.title);
            Console.WriteLine("Playcount Film : " + this.playcount);
        }
    }
}
