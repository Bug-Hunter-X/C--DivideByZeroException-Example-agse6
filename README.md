# C# DivideByZeroException Example

This repository demonstrates a common runtime exception in C#: `DivideByZeroException`. The `bug.cs` file contains code that is vulnerable to this exception. The `bugSolution.cs` file offers a solution to prevent the exception.

## Bug Description
The program attempts to divide by the value of `MyProperty`. If `MyProperty` is 0, it will throw a `DivideByZeroException`. 

## Solution
The solution involves adding input validation or a check to ensure that `MyProperty` is not 0 before attempting division.