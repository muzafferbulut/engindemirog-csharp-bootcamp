using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Projet with abstraction!");

            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Muzaffer",
                LastName = "Bulut",
                BirthYear = 1998,
                TcNo = 12345678912
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            // yeni bir sistem geldiğini varsayalım
            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager1.Add(gamer);

            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "BlackFriday"
            };

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(campaign);
        }
    }
}
