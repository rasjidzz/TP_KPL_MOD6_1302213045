namespace TP_MODUL6_1302213045
{
    class Mainprogram
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Risjad Shidqi Febian");
            video1.increaseplaycount(50);
            video1.printvideodetails();
            SayaTubeVideo video2 = new SayaTubeVideo("Roger Federer courtlevel Practice");
            video2.increaseplaycount(10);
            video2.printvideodetails();
        }
    }
}