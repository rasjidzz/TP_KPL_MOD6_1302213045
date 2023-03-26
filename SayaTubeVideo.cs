using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            if (judul !=  null || judul.Length <100)
            {
                this.title = judul;
            }
            this.playcount = 0;
            Random rand = new Random();
            int randid = rand.Next(00000, 99999);
            this.id = randid;
        }
        public void increaseplaycount(int count)
        {
            if (count > 0 || count < 10000000)
            {
                for(int i = 0; i < count;)
                {
                    this.playcount++;
                    i++;
                }
                int coba = 0;
                try
                {
                    coba = checked(count + 10);
                }
                catch (System.OverflowException b)
                {
                    Console.WriteLine("Cek : " + b.ToString);
                    Console.WriteLine("Count melebihi 10000000");
                }
            }
            
        }
        public void printvideodetails()
        {
            Console.WriteLine("\nID Film : " + this.id);
            Console.WriteLine("Judul Film : " + this.title);
            Console.WriteLine("Playcount Film : " + this.playcount);
        }
    }
}
