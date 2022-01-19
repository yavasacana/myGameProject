using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager =
            new GamerManager(new ValidationManager());
            gamerManager.Add(new Gamer
            {
             ID = 2,
             BirthYear = 1998,
             FirstNAme = "Ali",
             LastName = "YAVAŞCAN",
             TC = 361
            }
            );
            CampaignManager campaignManager =
            new CampaignManager(new ValidationManager());
            campaignManager.Add(new Campaign
            {
                IdCampaign = 1,
                CampaignName = "Muazzam Cumartesi İndirimleri",
            }
            );


            
        }
    }
}
