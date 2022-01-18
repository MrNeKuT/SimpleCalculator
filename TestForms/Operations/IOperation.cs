using System;

namespace TestForms
{
    public interface IOperation
    {
        string Sign { get; }
        int Calculate(int op1, int op2);
    }
}
