using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface ICampaingManager
    {
        void Add(Campaign campaign );
        void Update(Campaign campaign);

        void Delete(Campaign campaign);
    }
}
