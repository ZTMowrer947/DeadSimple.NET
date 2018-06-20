# DeadSimple.NET
A .NET Implementation of my very own DeadSimple Programming Language

## What is DeadSimple?
DeadSimple is an esoteric programming language created by me with only 4 operations. The name comes from the fact that it is, well...

**Dead Simple to program in.**

This language was created as a proof-of-concept for a very simple yet limited language that could at least display output to the console without directly altering memory values. This language technically does not use a stack internally, but incrementing and decrementing numbers does simulate the use of a stack that stores integers.

### Syntax
The four instructions are applied to a single integer variable.

- _: Resets to 0
- +: Increments by 1
- -: Decrements by 1
- S: Prints out the Unicode character represented by the integer value

All other characters are ignored, and thus can be used in comments.

### Example 'Hello, World!' Program
```
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++S # H
+++++++++++++++++++++++++++++S # e
+++++++SS # ll
+++S # o
_
++++++++++++++++++++++++++++++++++++++++++++S # ,
------------S # space
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++S # w
--------S # o
+++S # r
------S # l
--------S # d
_
+++++++++++++++++++++++++++++++++S # !
_
++++++++++S # newline
```

This can also be written as a one-liner:
```
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++S+++++++++++++++++++++++++++++S+++++++SS+++S_++++++++++++++++++++++++++++++++++++++++++++S------------S+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++S--------S+++S------S--------S_+++++++++++++++++++++++++++++++++S_++++++++++S
```

### Using the interpreter ###
You must have .NET Core 2.0 installed to use this interpreter.
Visual Studio (the IDE) would also be nice.

1. Download the project
2. If you have Visual Studio, build the project there. If not run `dotnet build Mowrer.DeadSimple.sln /p:Configuration=Release /p:Platform="Any CPU"` in the root directory.
3. In the `Mowrer.DeadSimple.Core/bin/Release/netcoreapp2.0` directory, run `dotnet dsi.dll <filename>`, replacing the filename with the path to the file containing DeadSimple code.
