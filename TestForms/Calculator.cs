using System;
using System.Collections.Generic;

namespace TestForms
{
    public class Calculator
    {
        private readonly IReadOnlyDictionary<OperationId, Func<int, int, int>> _operations =
            new Dictionary<OperationId, Func<int, int, int>>
            {
                [OperationId.Sum] = (a, b) => a + b,
                [OperationId.Subtract] = (a, b) => a - b,
                [OperationId.Divide] = (a, b) => a / b,
                [OperationId.Multiply] = (a, b) => a * b,
            };

        public Calculator()
        {
            ValidateOperations();
        }

        public int Calculate(int op1, int op2, OperationId operationId)
        {
            var operation = _operations[operationId];
            return operation(op1, op2);
        }

        private void ValidateOperations()
        {
            foreach (OperationId operationId in Enum.GetValues(typeof(OperationId)))
            {

                if (!_operations.ContainsKey(operationId))
                {
                    throw new Exception($"Operation with id {operationId} not added to operetions dictionary!");
                }

                if (_operations[operationId] == null)
                {
                    throw new Exception($"Operation with id {operationId} is null!");
                }
            }
        }
    }
}
