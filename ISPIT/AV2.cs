using ISPIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ISPIT
{
    internal class AV2
    {
    }

    //STATIC

    public class Koala
    {
        //Totalkoalas nije vezan za instancu klase vec za samu klasu
        //on moze brojat ukupan broj instanci
        private static int TotalKoalasBorn = 0;
        public static readonly int EndangeredCount = 50;
    }

    //OPTEREĆIVANJE OPERATORA
    public class Complex
    {
        public int Re;
        public int Im;

        //vraća Complex, preopterećuje +, ulazi C C
        public static Complex operator +(Complex lhs, Complex rh)
        {
            return new Complex(lhs.Re + rhs.Re, lhs.Im + rhs.Im);
        }
        //drugačiji jer se poziva ovaj umjesto prvog kad su argumenti ulaza C i int
        //moze imat samo jedan ulaz u situacji a=-a  onda je ulaz sam C
        public static Complex operator +(Complex lhs, int value)
        {
            return new Complex(lhs.Re + value, lhs.Im);
        }
        /*
         *Kod preopterećivanja operatora == i != u većini je 
         *slučajeva nužno prepisati i metode Equals() i GetHashCode(). 
         *Kod operatora za usporedbu trebalo bi se implementirati sučelja 
         *IComparable i IComparable<T>.
        */

        //vraća bool
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return true;
        }
        //kad pre. op. == moramo i != inace compajler nece dopustit
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return true;
        }
        //INKREMENT, dekrement je -- al compajleru ovaj put ne smeta ako je samo jedan
        public static Complex operator ++(Complex complex)
        {
            return complex;
        }

        //OPERATORI KONVERZIJE- mora bit ili explicit ili implicit
        //Complex c11 = (Complex)47;   47 je int
        //int d = (int)c10;  c10 je complex
        //implicit za one koje nemaju manjka informacija u returnu(gubitak podataka)
        //explicit za one koji imaju manjak informacija i gube podatke u returnu
        public static explicit operator int(Complex complex)
        {
            return complex.Re;
        }
        public static implicit operator Complex(int value)
        {
            return new Complex();
        }
        //PREOPTEREĆIVANJE INDEKSARA
        string[] words;
        public string this[int wordIndex]
        {
            get { return words[wordIndex]; }
            set { words[wordIndex] = value; }
        }


        //STRING    
        private readonly string vowels = "aeiou";
        private string[] bannedWords;
        //unos u banned words
        public void unos(string[] bannedWords)
        {
            this.bannedWords = new string[bannedWords.Length];

            for (int i = 0; i<bannedWords.Length; i++)
            {
                this.bannedWords[i] = bannedWords[i].ToLower();
            }
        }
        //contains
        public bool ShouldBan(string word)
        {
            foreach (string bannedWord in bannedWords)
            {
                string lowercaseWord = word.ToLower();
                if (word.Contains(bannedWord))
                {
                    return true;
                }
            }
            return false;
        }
        //count chars
        public int CountVowels(string word)
        {
            int vowelCount = 0;
            foreach (char letter in word)
            {
                if (vowels.Contains(Char.ToLower(letter)))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        //empty
        string empty = string.Empty();
        public bool checkempty(string s)
        {
            return String.IsNullOrEmpty(s);
        }



        //MATH
        double a = Math.Pow(1, 4) * Math.Sin(3 * 2) + Math.Sqrt(5 + 5);
    }


    //RANDOM
    public class randoms
    {
        private Random generator;
        private int count = 0;
        private double countd = 0.0;
        public randoms(Random generator, int count, double countd)
        {
            this.generator = generator;
            this.count = count;
            this.countd = countd;
        }
        public randoms() : this(new Random(), 8, 8.00)
        {
        }
        //random generiranje
        public void generate()
        {
            this.count = generator.Next(0, 10);
            this.countd = generator.NextDouble() * 5 + 1.00; // 0.00:1.00 * 5 + 1 == <1.00,6.00>

        }

        //VREMENA I DATUMI  
        private DateTime time;
        public void unesidatum(string time) { 
            this.time = DateTime.Parse(time);
        }
        public void unesidatum(DateTime time)
        {
            this.time = time;
        }
        //timespan
        public void produzi(TimeSpan duration)
        {
            this.time += duration;
        }

        DateTime time2 = new DateTime(2020, 10, 15, 20, 30, 0);
        DateTime time3 = DateTime.Now;

        TimeSpan postpone = new TimeSpan(0, 30, 0);
    }


    //DATOTEKE
    public class DataProcessor
    {
        public void Store(int n, string name)
        {
            using (StreamWriter writer  = new StreamWriter(name))
            {
                for(int i = 0; i < n; i++)
                {
                    writer.WriteLine(i); //zapisuje u datoteku name
                }
            }
        }

        public int[] Load(int n, String name)
        {
            int[] data = new int[n];

            using (StreamReader reader = new StreamReader(name))
            {
                int current = 0;
                string line = string.Empty;

                while((line = reader.ReadLine()) != null && current < n) //ne moze for
                {
                    data[current] = int.Parse(line); //int parse
                    current++;
                }
            }
            return data;
        }

        /*
            string fileName = "file.txt";
            DataProcessor.Store(5, fileName);
        */


        //proširenje string ugrađene klase

        public static class StringExtensions
        {
            public static string ToSentenceCase(this string text)
            {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
        }

        /*
            string input = "this is a dummy sentence.";
            Console.WriteLine(input.ToSentenceCase());
        */
        
        

}
