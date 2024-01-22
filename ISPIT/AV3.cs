using ISPIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPIT
{
    internal class AV3
    {
    }

    //has-a kad unutar klase kao stanje imamo drugu klasu
    //is-a kad kopiramo base jedne klase i nadogradimo 

    public class Student
    {
        public int ID;
        public Student(int ID) //ovo mora postojat da bi radio BASE()
        {
            ID = ID;
        }
    }
    public class FeritStudent : Student
    {
        string program;
        public FeritStudent(string program, int ID) : base(ID)
        {
            this.program = program;
        }
    }

    //protected ne moze pristupit ni nasljedna klasa
    //private moze pristupit nasljedna klasa
    //public mogu pristupit sve klase

    //hiding: kad u novoj izvedenoj klasi napravimo metodu istog imena ko u onoj sto nasljedujemo
    //compajler ce pregazit s tom novom umjesto s originalnom
    //moze i bez virtual-override odnosa ali ovako je bolji practice jer
    //govorimo drugima da je poželjno napravit override

    public class Animal
    {
        public virtual string Move() { return "Moving animal style."; }
    }
    public class Kangaroo : Animal
    {
        public override string Move() { return "Hop! Hop! Hop!"; }
    }

    //metode koje su automatski postojece u svim klasam i najcesce se overraajdaju:
    //ToString(), GetHashCode() i Equals() metode klase System.Object.
    public class Location : IEquatable<Location> //moramo podržati .equals(Location)
    {
        private readonly double latitude = 1.0;
        private readonly double longitude = 2.0;

        public bool Equals(Location other)
        {
            return latitude == other.latitude && longitude == other.longitude;
        }

        public override string ToString()
        {
            return $"{latitude} {longitude}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(latitude, longitude);
        }

    }

    //abstraktna klasa i metode
    //klase koje su napravljene za nasljedivanje i ne mogu imat konkretan objekt
    //kocka nasljeduje klasu shape ali shape ne moze bit shape a = new shape
    //apstraktne metode su automatski i virtualne ali kad navedemo da su apstraktne
    //onda ih moramo implementirati 
    public abstract class Animal2
    {
        //...
        public abstract string MakeSound();
    }

    public class Dog2 : Animal2
    {
        //...
        public override string MakeSound()
        {
            return "Woof woof!!!";
        }
    }



}
