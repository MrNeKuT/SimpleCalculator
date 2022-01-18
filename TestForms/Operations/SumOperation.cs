namespace TestForms
{
    public class SumOperation : IOperation
    {
        public string Sign => "+";
        public int Calculate(int op1, int op2) => op1 + op2;
    }
}
