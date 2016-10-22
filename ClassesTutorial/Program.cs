using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            //AbstractCar aCar = new AbstractCar(); nu se poate instantia
            ICar car = new Mercedes();
            //AbstractCar car2 = new AbstractCar(); nu se poate instantia
            EngineStruct engineStruct = new EngineStruct();
            //Console.WriteLine("This is my first C# application");
           // Console.ReadKey();
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);
            Console.ReadKey();
        }
    }

    public class Mercedes:AbstractCar
    {
        //protected int year;
        //protected string customer;
        internal int year;
        internal string colour;
        private string _description;
        private int _price;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "This is a car";
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = 67000;
            }
        }
        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }
    }

    interface ICar
    {

    }
    public abstract class AbstractCar:ICar
    {

    }

    public struct EngineStruct
    {

    }
}
