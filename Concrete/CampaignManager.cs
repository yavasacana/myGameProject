using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CampaignManager : ICampaingManager
    {
        IValidationManager _validationManager;
        public CampaignManager(IValidationManager validationManager)
        {
            _validationManager = validationManager;
        }


        public void Add(Campaign campaign)
        {
            Console.WriteLine("Muazzam Cumartesi İndirimleri!!!"); 
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Süresi Doldu!!!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Süresi Uzatıldı/Güncellendi!!!");
        }
    }
}
