using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPIT
{
    internal class AV5
    {
    }
    //namespace . je ko /
    //using Ferit.OOP.Complex.Math;
    //namespace Ferit.OOP.Complex


    //IZNIMKE
    public void RunSimpleDemo()
    {
        try
        {
            //
        }
        catch (Exception e)
        {
            //
        }
        finally
        {
            //
        }
        throw new ArgumentException($"Parameter {} cannot be zero.");
        //catch (ArgumentException e){ Console.WriteLine(e.Message) };
    }
    //Exceptioni su klase tako da je moguce napravit exception koji nasljeduje exception i sve
    //ostale igre


    //GENERIČKI TIPOVI
    //Riječ je o klasama čiji objekti unutar sebe drže podatke različitog tipa i omogućuju
    //različite radnje nad podacima.

    public class Stack<T>
    {
        private int stackPointer;
        private T[] data;
        public Stack(int size)
        {
            data = new T[size];
            stackPointer = -1;
        }
        public void Push(T value) { stackPointer++; data[stackPointer] = value; }

    }

    //preopterećivanje generičkih tipova

    public static class ArrayUtilities
    {
        public static int FindLargestIndex<T>(T[] array) where T : IComparable<T>
        {
            return 1;
        }
    }

}



}
