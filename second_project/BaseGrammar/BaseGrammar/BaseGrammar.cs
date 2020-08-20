using System;

namespace BaseGrammar
{
    class BaseGrammar
    {
        //成员变量
        private double _length;

        private double _width;

        public void AcceptDetails()
        {
            _length = 4.5;
            _width = 3.5;
        }

        private double GetArea()
        {
            return _length * _width;
        }

        public void Display()
        {
            Console.WriteLine("Length:{0}",_length);
            Console.WriteLine($"Length:{_width}");
            Console.WriteLine("Length:{0}",GetArea());
        }
    }

    class ExecuteRectangle
    {
        private static void Main(string[] args)
        {
            var baseGrammar = new BaseGrammar();
            baseGrammar.AcceptDetails();
            baseGrammar.Display();
        }
    }
}