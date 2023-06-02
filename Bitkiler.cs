using System;

namespace kalitim // Note: actual namespace depends on the project name.
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez yapar");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
           
        
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        
        public void TohumsuzCogalma()
        {
        Console.WriteLine("TohumsuzBitkiler sporla çoğalır");
        }
    }
}