using System;

namespace jeu_de_maths
{
    class Program
    {

        enum e_Operateur
        {

        ADDITION = 1,
        MULTIPLICATION = 2,
        SOUSTRACTION = 3

        }

        static bool PoserQuestion(int min, int max)
        {

            Random rand = new Random();
            int reponseInt = 0;
            while (true)
            {

                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);
                e_Operateur o = (e_Operateur)rand.Next(1,4);
                int resultatAttendu;

                switch (o)
                {

                    case e_Operateur.ADDITION:           
                            Console.WriteLine(a + " + " + b + " = ");
                            resultatAttendu = a + b;
                        break;

                        case e_Operateur.MULTIPLICATION:
                        Console.WriteLine(a + " x " + b + " = ");
                        resultatAttendu = a * b;
                        break;

                    case e_Operateur.SOUSTRACTION:

                       Console.WriteLine(a + " - " + b + " = ");
                        resultatAttendu = a - b;
                        break;
                       default:
                        Console.WriteLine("Operateur inconnu");
                        return (false);



                }
                     string reponse = Console.ReadLine();
                }
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (reponseInt == resultatAttendu)

                    {

                        return true;

                    }

                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
            // reponseInt
        }
        static void Main(string[] args)
        {

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 5;
            int points = 0;
     

            for (int i = 0; i < NB_QUESTIONS; i++)
            {

                Console.WriteLine("Question no " +  (i+1) + "/" + NB_QUESTIONS);
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);

                if (bonneReponse)

                {
                    points++;
                    Console.WriteLine("bonne reponse!!!!");

                }
                else
                {

                    Console.WriteLine("Mauvaise reponse");
                }


                Console.WriteLine("");

            }

            int moyenne = points * 100 / NB_QUESTIONS;

        Console.WriteLine("NBRS DE POINTS: " + points + " / " + NB_QUESTIONS);
        Console.WriteLine("Moyenne de : " + moyenne );

     


            if (points == NB_QUESTIONS)
            {
                Console.WriteLine("Excellent!!!");

            }

            else if (points == 0)
            {

                Console.WriteLine("Revise tes maths");
            }

            else if (points > moyenne)
            {
                Console.WriteLine("pas mal");

            }

            else

            {
                Console.WriteLine("peut mieux faire");

            }



        }
    }
}