# R-U-DS.NET
A .NET Implementation of my very own R U DS Programming Language

## What is R U DS?
R U DS is an esoteric programming language created by me with only 4 operations: R, U, D, and S. The name comes from both the operator names and the shortening of the likely response to programming in this language:

**Are You Dead Serious?**

This language was created as a proof-of-concept for a very simple yet limited language that could at least display output to the console without directly altering memory values. This language technically does not use a stack internally, but incrementing and decrementing numbers does simulate the use of a stack that stores integers.

This should not be confused with RUDS: an acronym for a few different things that have absolutely nothing to do with this project.

### Syntax
The four instructions are applied to a single integer variable.

- R: Resets to 0
- U: Increments by 1
- D: Decrements by 1
- S: Prints out the Unicode character represented by the integer value

All other characters are ignored, and thus can be used in comments.

### Example 'Hello, World!' Program
```
UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUS # H
UUUUUUUUUUUUUUUUUUUUUUUUUUUUUS # e
UUUUUUUSS # ll
UUUS # o
R
UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUS # ,
DDDDDDDDDDDDS # space
UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUS # w
DDDDDDDDS # o
UUUS # r
DDDDDDS # l
DDDDDDDDS # d
R
UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUS # !
R
UUUUUUUUUUS # newline
```

This can also be written as a one-liner
```
UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUSUUUUUUUUUUUUUUUUUUUUUUUUUUUUUSUUUUUUUSSUUUSRUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUSDDDDDDDDDDDDSUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUSDDDDDDDDSUUUSDDDDDDSDDDDDDDDSRUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUSRUUUUUUUUUUS
```

### Using the interpreter ###
You must have .NET Core 2.0 installed to use this interpreter.
Visual Studio (the IDE) would also be nice.

1. Download the project
2. If you have Visual Studio, build the project there. If not run `dotnet build Mowrer.RUDS.sln /p:Configuration=Release /p:Platform="Any CPU"` in the root directory.
3. In the `Mowrer.RUDS.Core/bin/Release/netcoreapp2.0` directory, run `dotnet ruds.dll <filename>`, replacing the filename with the path to the file containing R U DS code.
