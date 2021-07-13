using System.Collections.Generic;
using System;

public class OperationManager
{
    public Dictionary<Operation, Func<int>> DelegateExecute{get; set;}

    public OperationManager() {
        DelegateExecute = new Dictionary<Operation, Func<int>>(3);
    }

    public void AddOperation(Operation operation, Func<int> myDelegate) {
        if (!DelegateExecute.ContainsKey(operation)) {
            DelegateExecute.Add(operation, myDelegate);
        }
    }

}