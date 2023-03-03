namespace Parameters
{
    class ReferenceParameter
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }

    }
    
    class OutputParameter
    {
        public static void Divide(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }

    }

    class Squares
    {
        public static void WriteSquares()
        {
            int lado = 0;
            int area;

            while (lado < 10)
            {
                area = lado*lado;
                Console.WriteLine($"lado = {lado}, area = {area}");
                lado += 1;
            }
        }


    }
   
    class Entity
    {
        static int s_nextSerialNo;
        int _serialNo;

        public Entity()
        {
            _serialNo = s_nextSerialNo;
            s_nextSerialNo ++;
        }
        public int GetSerialNo()
        {
            return _serialNo;
        }
    
        public static int GetNextSerialNo()
        {
            return s_nextSerialNo;
        }

        public static void SetNextSerialNo(int value)
        {
            s_nextSerialNo = value;
        }

    }
    class Program
    {
        /*
        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // "2 1"
        }
        
        */

        /*
        public static void Main(string[] args)
            {
                // Diferente das variáveis de refencia, podemos passar como argumento
                // as variáveis de output antes delas serem instanciadas
                OutputParameter.Divide(10, 3, out int quo, out int rem);
                System.Console.WriteLine($"quo = {quo} rem = {rem}");
            }

        public static void Main(string[] args)
        {
            Squares.WriteSquares();
        }
        
            */
        public static void Main(string[] args)
        {
            Entity.SetNextSerialNo(1000);
            Entity e1 = new();
            Entity e2 = new();
            Console.WriteLine(e1.GetSerialNo());          // Outputs "1000"
            Console.WriteLine(e2.GetSerialNo());          // Outputs "1001"
            Console.WriteLine(Entity.GetNextSerialNo());
        }

    }

}
