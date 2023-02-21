namespace Project4
{
    internal class Program
    {
        static void Main()
        {
            QuadraticEquation Y = new QuadraticEquation();
            Console.Write("a = ");
            Y.SetA(Convert.ToDouble(Console.ReadLine()));

            Console.Write("b = ");
            Y.SetB(Convert.ToDouble(Console.ReadLine()));

            Console.Write("c = ");
            Y.SetC(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($"D = {Y.GetD()}");

            if (Y.HasRoots() == true)
            {
                Console.WriteLine($"X1 = {Y.GetX1()}");
                Console.WriteLine($"X2 = {Y.GetX2()}");
                //Console.WriteLine(Y.GetRoots());
            }
            else
            {
                Console.WriteLine("No Roots Found");
            }

            if (Y.HasRoots() == true)
            {
                Console.WriteLine(Y.GetRoots());
            }
            else
            {
                Console.WriteLine("No Roots Found");
            }

        }
    }
    class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        #region Getters and Setters
        public double GetA()
        {
            if (_a == 0)
            {
                throw new Exception("a can not be set to zero");
            }
            return _a;
        }
        public void SetA(double a)
        {
            if (a == 0)
            {
                throw new Exception("a can not be set to zero");
            }
            _a = a;
        }
        public double GetB()
        {
            return _b;
        }
        public void SetB(double b)
        {
            _b = b;
        }
        public double GetC()
        {
            return _c;
        }
        public void SetC(double c)
        {
            _c = c;
        }
        #endregion
        public double GetD()
        {
            return Math.Pow(GetB(), 2) - (4 * GetA() * GetA());
        }

        public double? GetX1()
        {
            return (-GetB() - Math.Sqrt(GetD())) / (2 * GetA());
        }
        public double? GetX2()
        {
            return (-GetB() + Math.Sqrt(GetD())) / (2 * GetA());
        }
        public bool HasRoots()
        {
            if (GetD() >= 0)
            {
                return true;
            }
            return false;
        }
        public (double?, double?) GetRoots()
        {
            return (GetX1(), GetX2());
        }
    }
}