namespace WebApplication8
{
    public class ArithmeticOperations
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }

        public int Add()
        {
            return Operand1 + Operand2;
        }
        public int Sub()
        {
            return Operand1 - Operand2;
        }
    }
}
