using System;

namespace kalitim // Note: actual namespace depends on the project name.
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
    }
    public class Surungenler:Hayvanlar{

        public Surungenler()
        {
            base.Adaptasyon();
        }
        public void SurunerekHareketEderler()
        
            {
                Console.WriteLine("Surungenler sürünerek hareket eder");
            }
    }
    public class Kuslar:Hayvanlar {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar");
        }
    }
}