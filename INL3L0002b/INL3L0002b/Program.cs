using System;


namespace INL3L0002b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Rebecka Klausen,rebkla-1 & L0002b
            //här ber jag om input från användaren (namn, efternamn och personnummer)
            Console.Write("Ange förnamn: ");
            string namn = Console.ReadLine();
            Console.Write("Ange efternamn: ");
            string efternamn = Console.ReadLine();
            Console.Write("Ange personnummer: ");
            string pnr = (Console.ReadLine());
            Console.Clear();

            //här kallar jag mina metoder och booleans
            
            person(namn, efternamn);
            ktr21(pnr);
        }
        static void person(string namn, string efternamn)
        {
            Console.WriteLine(namn + " " + efternamn);
        }
        static double ktr21(string pnr)
        {
            int value = 0;
            for (int i = 0; i < pnr.Length; i++)
            {
                int t = (pnr[i] - 48)
                    << (1 - (i & 1));
                if (t > 9)
                    t = t - 9;
                value += t;

            }

            int svar = value % 10;
            if (svar == 0)
            {
                Console.WriteLine("Personnummret stämmer");
                female_male(pnr);
            }
            if (svar != 0)
            {
                Console.WriteLine("sackta i backarna, mig kan du inte lura mig");

            }
            

            return (value % 10);

        }

        
        
        static void female_male(string pnr)
        {
            int gender = pnr[8] - 48;
            if ((gender == 1) || (gender == 3) || (gender == 5) || (gender == 7) || (gender == 9))
            {
                Console.WriteLine("Man");
            } if ((gender == 0) || (gender == 2) || (gender == 4) || (gender == 6) || (gender == 8))
            {
                Console.WriteLine("Kvinna");
            }
        }
    }

    
}

