using System;
using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using GameDemoProject.Concrete;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, 
             * satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz. 
             * Burada amaç yazdığınız kodun kalitesidir. Ödevde gereksinimleri tam anlamadığınız durum benim için önemli 
             * değil, kendinize göre mantık geliştirebilirsiniz. Dediğim gibi kod kalitesiyle ilgileniyoruz şu an :)

             * Gereksinimler:

                1. Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir 
                   ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama 
                   yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.
                   Bunu yapacak servisi simule etmeniz yeterlidir.)

                2. Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile 
                   ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

                3. Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

                4. Satışlarda kampanya entegrasyonunu simule ediniz.
             */

            User user = new User { Id = 1, DateOfBirth = new DateTime(1998, 10, 20), 
                                   TcNo="46546", FirstName = "Muzaffer", LastName="Bulut"};

            BaseUserManager baseUserManager = new PremiumUserManager();
            baseUserManager.Register(user);

            Game game = new Game() { Id = 1, GameName = "PES2022", Category = "Sport", Price = 249.99 };
            Campaign campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "BlackFriday",
                Description = "hede hede",
                DeadLine = new DateTime(2022, 4, 30)
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);


            baseUserManager.Buy(game, user);
            baseUserManager.Sell(game, user);
        }
    }
}
