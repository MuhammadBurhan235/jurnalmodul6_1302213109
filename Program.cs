using jurnalmodul6_1302213109;
public class Program
{
    public static void Main(string[] args)
    {
        string videoTitle = "Ease Your Mine";
        string username = "Burhan";
        SayaTubeUser myUser = new SayaTubeUser(username);
        SayaTubeVideo myVideo = new SayaTubeVideo(videoTitle);
        myVideo.IncreasePlayCount(2000);
        for (int i = 0; i < 50000000; i += 25000000)
        {
            try
            {
                myVideo.IncreasePlayCount(25000000);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }
        myVideo.PrintVideoDetails();

        Console.ReadLine();
    }
}