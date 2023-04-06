using System;
namespace EdCivica
{
    public class Program
    {
        static void main(string[] args)
        {
            
        }
        public static string funzioneuno(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";

            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione + n) % alfabeto.Length;
                    risultato += alfabeto[posizione];
                }
                else
                {
                    risultato += c;
                }
            }

            return risultato;
        }
        public static string funzionedue(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";

            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione - n + alfabeto.Length) % alfabeto.Length;
                    risultato += alfabeto[posizione];
                }
                else
                {
                    risultato += c;
                }
            }

            return risultato;
        }
        static int funzione3(string s, int n)
        {
            
            int somma = 0;
            foreach (char lettera in s)
            {
                if (Char.IsLetter(lettera)) 
                {
                    int valore = (int)Char.ToLower(lettera) - 96; 
                    somma += valore;
                }
            }
            return somma * n;
        }

        static int funzione4(string s, int n)
        {
            int somma = 0;

           
            s = s.ToUpper();

            
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                
                if (Char.IsLetter(c))
                {
                   
                    int valore = c - 'A' + 1;

                    
                    somma += valore;
                }
            }

            
            int risultato = (int)Math.Ceiling((double)somma / n);

            return risultato;
        }
        static int funzione5()
        {
            return 0;
        }
    }


}
