using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPIT
{
    internal class ROK
    {
    }

    //(n se unosi s tipkovnice)
    public class dummy
    {
        int n = Convert.ToInt32(Console.ReadLine());
    }
    //faktor uspjesnosti
    public virtual bool WillScore()
    {
        return generator.GenerateDouble() < scoreProbability;
    }

    
}
