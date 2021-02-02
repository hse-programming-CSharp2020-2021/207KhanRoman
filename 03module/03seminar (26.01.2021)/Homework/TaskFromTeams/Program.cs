using System;
using MyLab;

namespace TaskFromTeams
{

    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            VetoCommision com = new VetoCommision();
            VetoVector[] vector = new VetoVector[5];

            for(int i =0; i<5; i++)
            {
                vector[i] = new VetoVector();
                vector[i].Name = rnd.Next(10000).ToString();
                com.OnChoice += vector[i].IsVeto;
            }
            VetoEventArgs veto = com.Vote("What?");
            if (veto.VetoBy == null) Console.WriteLine("Вето не наложено");
            else Console.WriteLine($"{veto.VetoBy.Name} - тот гаденыш, который наложил вето(");
        }
    }
}
