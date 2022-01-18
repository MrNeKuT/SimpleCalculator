using System;
using System.Collections.Generic;

namespace TestForms
{
    public class Calculator
    {
        private List<IOperation> _operations = new List<IOperation>();

        public int Calculate(int op1, int op2, int operationIdx)
        {

            if (!ValidateOperationId(operationIdx))
            {
                throw new ArgumentException($"{operationIdx} operation id is invalid!");
            }

            return _operations[operationIdx].Calculate(op1, op2);
        }

        public Calculator AddOperation(IOperation operation)
        {
            if(operation == null)
            {
               throw new ArgumentNullException("Operation you trying to add is null!");
            }

            _operations.Add(operation);
            return this;
        }

        public IEnumerable<string> GetOperationsSigns()
        {
            foreach (IOperation operation in _operations)
            {
                yield return operation.Sign;
            }
        }

        public string GetOperationSign(int id)
        {
            if (!ValidateOperationId(id))
            {
                throw new ArgumentException($"{id} operation id is invalid!");
            }

            return _operations[id].Sign;
        }

        public bool ValidateOperationId(int id) =>
            id >= 0 && id < _operations.Count;
    }
}
