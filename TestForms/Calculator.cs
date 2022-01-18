using System;
using System.Collections.Generic;

namespace TestForms
{
    public class Calculator
    {
        private readonly IReadOnlyList<Operation> _operations = new List<Operation>() {
            new Operation(
              sign: "+",
              operation: (a, b) => a + b
            ),

            new Operation(
              sign: "-",
              operation: (a, b) => a - b
            ),

           new Operation(
              sign: "/",
              operation: (a, b) => a / b
            ),
        };

        public Calculator()
        {
            ValidateOperations();
        }

        public int Calculate(int op1, int op2, int operationIdx)
        {

            if (!ValidateOperationId(operationIdx))
            {
                throw new ArgumentException($"{operationIdx} operation id is invalid!");
            }

            return _operations[operationIdx].operation(op1, op2);
        }

        public IEnumerable<string> GetOperationsSigns()
        {
            foreach (Operation operation in _operations)
            {
                yield return operation.sign;
            }
        }

        public string GetOperationSign(int id)
        {
            if (!ValidateOperationId(id))
            {
                throw new ArgumentException($"{id} operation id is invalid!");
            }

            return _operations[id].sign;
        }

        public bool ValidateOperationId(int id) =>
            id >= 0 && id < _operations.Count;

        private void ValidateOperations()
        {
            for (int i = 0; i < _operations.Count; i++)
            {
                Operation operation = _operations[i];

                if (operation == null)
                {
                    throw new Exception($"Operation with idx={i} is null!");
                }

                if (operation.operation == null)
                {
                    throw new Exception($"Operation logic of \"{operation.sign}\" operation is null!");
                }
            }
        }
    }
}
