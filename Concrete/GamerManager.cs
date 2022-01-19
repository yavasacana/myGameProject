using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : IGamerManager
    {

        IValidationManager _validationManager;

        public GamerManager(IValidationManager validationManager)
        {
            _validationManager = validationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_validationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt olma süreci başarılı!");
            }
            else
            {
                Console.WriteLine("HATA!");
            }

        }

        public void Delete(Gamer gamer)
        {
            if (_validationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt silme süreci başarılı!");
            }
            else
            {
                Console.WriteLine("HATA!");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_validationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt güncelleme süreci başarılı!");
            }
            else
            {
                Console.WriteLine("HATA!");
            }
        }
    }
}
