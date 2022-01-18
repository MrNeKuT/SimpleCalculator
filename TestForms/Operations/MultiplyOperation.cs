namespace TestForms
{
    public class MultiplyOperation : IOperation
    {
        public string Sign => "*";

        public int Calculate(int op1, int op2) => op1 * op2;
    }
}
