using System;

namespace TestForms
{
    public class Operation
    {
        public readonly string sign;
        public readonly Func<int, int, int> operation;

        public Operation(string sign, Func<int, int, int> operation)
        {
            this.sign = sign;
            this.operation = operation;
        }
    }
}
