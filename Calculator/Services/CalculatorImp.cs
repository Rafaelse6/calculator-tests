namespace Calculator.Services
{
    public class CalculatorImp
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Div(int num1, int num2)
        {
            return num1 / num2;

        }

        public bool ItsEven(int num)
        {
            return num % 2 == 0;
        }
    }

}