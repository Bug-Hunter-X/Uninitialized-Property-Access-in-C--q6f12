# Uninitialized Property Access in C#

This example showcases a subtle but common error in C#: attempting to access a class property before it has been properly initialized within the constructor or elsewhere.  Accessing an uninitialized property can lead to unpredictable results, often throwing exceptions or producing incorrect data.

The `bug.cs` file contains the flawed code. The `bugSolution.cs` file provides a corrected version that addresses the problem.

## How to Reproduce

1. Compile and run `bug.cs`.  Observe the potential exception (NullReferenceException if MyProperty is a reference type) or unexpected default value (0 for an integer).
2. Examine the corrected implementation in `bugSolution.cs` to understand how to avoid the issue.

##  Solution
The solution involves ensuring all properties are initialized before they are accessed, either directly in the constructor, or with explicit default values. 
