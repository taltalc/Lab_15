using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progect
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(20,3);
            arithProgression.setStart(1);
            arithProgression.getNext();
            arithProgression.reset();
            Console.WriteLine(" ");
            GeomProgression geomProgression = new GeomProgression(20, 3);
            geomProgression.setStart(1);
            geomProgression.getNext();
            geomProgression.reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        
        void setStart(int x);
        void getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int Countmembers { get; set; }
        public double FirstMember { get; set; }
        public double Delta { get; set; }
        public int Start { get; set; }
        public double Member { get; set; }
        public ArithProgression(int countmembers,  double delta)
        {
            Countmembers = countmembers;
            Delta = delta;
        }   
        public void setStart(int x)
        {
            
            FirstMember = x;
        }
            
        public void getNext()
        {
        for (int i = 0; i < Countmembers; i++)   
        {
            Member = (FirstMember+i*Delta);
            Console.Write(Member+" ");     
        }            
           
        }    
        public void reset()
        {
         Member = Start;       
        }            
    
    }
    class GeomProgression: ISeries
    {
        public int Countmembers { get; set; }
        public double FirstMember { get; set; }
        public double Denominator { get; set; }
        public int Start { get; set; }
        public double Member { get; set; }
        
        
        
        
        public GeomProgression(int countmembers,double denominator)
        {
            Countmembers = countmembers;
           Denominator = denominator;
        }
        public void setStart(int x)
        {
            if (x>0)
            {
                FirstMember = x;

            }
            else
            {
                Console.WriteLine("Первый член геометрической прогрессии не может быть орицательным или равным нулю.");
            }
     
        }
        public void getNext()
        {
            if( Denominator>0)
            {
                for (int i = 0; i < Countmembers; i++)
                {
                    Member = FirstMember * Math.Pow(Denominator, i);
                    Console.Write(Member + " ");
                }

            }
            else
            {
                Console.WriteLine("Знаменатель геометрической прогрессии не может быть отрицательным или равным нулю.");
            }
            
     
        }
        public void reset()
        {
            Member = Start;
        }


    }

 } 
