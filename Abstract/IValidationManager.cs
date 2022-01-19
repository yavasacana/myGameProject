using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IValidationManager 
    {
        bool Validate(Gamer gamer);
        bool Validate(Campaign campaign);

    }
}
