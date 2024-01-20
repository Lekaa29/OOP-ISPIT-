using ISPIT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ISPIT
{
    internal class AV1
    {
    }
    //Stanje klasa na ovom kolegiju, dakle unutar primjera, zadataka, LV-a i pismenih
    //ispita ´ce biti privatno.
    public class Dog
    {
        private string name = "Rex";
        
        internal string colour = "Brown";

        public double A;
        //getter i setter kao svojstvo
        public double a { get => A; set => A = value; } //a se updatea zajedno kad i A

        //automatsko svojstvo get i set
        public string visina { get; set; }


        public string breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }


        //(PRISTUPNE METODE) getter i setter
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        public string Bark()
        {
            return "Woof! " + $"I am {name}"; // $ interpolacijski string
        }
    }


    public class Dot
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        //PREOPTEREĆIVANJE KONSTRUKTORA:

        //PODRAZUMIJEVNI KONSTRUKTOR
        public Dot() { X = Y = 0; }
        //PARAMETARSKI KONSTRUKTOR
        public Dot(int x, int y) {  X = x; Y = y; }
        //KONSTRUKTOR KOPIJE
        public Dot(Dot dot) { X = dot.X; Y = dot.Y;}

        // PRAZNI DESTRUKTOR
        ~Dot() { }

        //INKREMENTER (NEZ KAK NAZVAT IZGLEDA LIJEPO)  Dot.Upvote();
        public void Upvote() => X++;


    }


    //KOMPOZICIJA (RAZDVAJANJE PROBLEMA NA VIŠE KLASA KOJE SU NEKIM NAČINOM POVEZANE)
    public class Question
    {
        private string text;
        private Answer[] answers;  //IZ KLASE Answer 
        public Question(string text, Answer[] answers)
        {
            this.text = text;
            this.answers = answers;
        }
    }
    public class Answer
    {
        public string Text { get; set; }
        public Answer(string answer){ Text = answer; }
    }



    public class MonthlyPrecipitation
    {
        public int Days { get; private set; }
 
        private double[] precipitations;  //array iniciranje
    
        public MonthlyPrecipitation(int year, int month, int days)
        {
            Days = days;
            precipitations = new double[Days];  //array kreiranje
        }
        public double arrayFuncs(double[] precipitations)
        {
            //kopiranje arraya .Copy(iz, u, duzina)
            Array.Copy(precipitations, this.precipitations, precipitations.Length);
            //pristup
            precipitations[0] = 1;

            //prolaz
            double totalPrecipitation = 0.0;
            foreach (var precipitation in precipitations)
            {
                totalPrecipitation += precipitation;
            }
            double averagePrecipitation = totalPrecipitation / precipitations.Length;
            return averagePrecipitation;
        }

}

}
