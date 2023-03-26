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
            SayaTubeVideo video3 = new SayaTubeVideo("This is an example title that is exactly 100 characters long and should not cause an exception to be thrown");
            video3.increaseplaycount(10000001);
            video3 .printvideodetails();
        }
    }
}