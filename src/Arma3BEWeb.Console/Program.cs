using Microsoft.Owin.Hosting;

namespace Arma3BEWeb.Console
{
    public class Program
    {
        private static void Main()
        {
            var baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress))
            {
                System.Console.ReadLine();
            }
        }
    }
}