using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ValidationManager : IValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (
                gamer.ID==1 &&
                gamer.BirthYear == 1998 && 
                gamer.FirstNAme == "Ali" &&
                gamer.LastName=="YAVAŞCAN" && 
                gamer.TC==361)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IValidationManager.Validate(Campaign campaign)
        {
            if (campaign.IdCampaign == 1  && 
                campaign.CampaignName == "Muazzam Cuma Fırsatları"  )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
