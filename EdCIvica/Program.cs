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
        public static string funzionedue()
        {
            return "";
        }
    }


}
