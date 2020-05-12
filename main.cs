using System;
namespace painting

{
    abstract class painting
    {
        private string artist;
        private string name;
        private string medium;
        private int year;

        public virtual void copyright() {
            Console.WriteLine("Verification copyright");
        }

        public virtual void description() {
            Console.WriteLine("description of painting");
        }

        public string Proartist {
            get {
                return artist;
            }
            set {
                name = value;
            }
        }
               
        public string Proname {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Promedium {
            get {
                return medium;
            }
            set {
                name = value;
            }
        }

        public int Proyear {
            get {
                return year;
            }
            set {
                name = value;
            }
        }
    }

   class Gogh : painting
   {
       public string artist = "Gogh";
       public string name = "Starry Night";
       public string medium = "AA";
       public string year = 1889;

       public override void copyright() {
            Console.WriteLine("Verification copyright");
        }

        public void check() {
            Console.WriteLine("Verification origin");
        }

   }

   class Program
   {
       static void Main(string[] args)
       {
           // Class encapsulation and inheritance
           Gogh newGogh = new Gogh();

           Console.WriteLine("Artist:" + newGogh.artist);
           Console.WriteLine("Name:" + newGogh.name);
           Console.WriteLine("Medium:" + newGogh.medium);
           Console.WriteLine("Year:" + newGogh.year);

           // Polymorphism and abstraction

           newGogh.copyright();
           newGogh.check();
       }
   }
}