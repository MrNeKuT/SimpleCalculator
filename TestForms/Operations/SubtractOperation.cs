namespace TestForms
{
    public class SubtractOperation : IOperation
    {
        public string Sign => "-";

        public int Calculate(int op1, int op2) => op1 - op2;
    }
}
