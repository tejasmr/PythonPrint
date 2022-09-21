# PythonPrint
Use python like print function in C#

[![NuGet](https://img.shields.io/nuget/v/PythonPrint.svg)](https://www.nuget.org/packages/PythonPrint)
[![NuGet Downloads](https://img.shields.io/nuget/dt/PythonPrint.svg)](https://www.nuget.org/packages/PythonPrint)

## Usage:

```cs
using static Print.Print;

namespace X {
  class A {
    static void Main() {
       print(1, 2, "hi");
       int[] arr = {1, 2, 3, 4};
       print(arr);
    }
  }
}
```
