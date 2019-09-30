using System;

namespace Gitrepo_Övningar_Klasser
{

    public class Katt{

        private string namn;
        private string ras;
        private int ålder;

        public string Namn{
            get{return namn;}
            set{namn = value;}
        }
        public string Ras{
            get{return ras;}
            set{ras = value;}
        }
        public int Ålder{
            get{return ålder;}
            set{ålder = value;}

        }

        public void Skälla(){
            Console.Write("En katt kan ej skälla!");
            
        }
        public void Apport(){
            Console.Write("Katten " + namn + " säger: " + "Jag orkar inte. Det blir för mycket.");
        
        }


    }



}
