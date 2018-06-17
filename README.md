# RUDS.NET
A .NET Implementation of my very own R U DS Programming Language

## What is R U DS?
R U DS is an esoteric programming language created by me with only 4 operations: R, U, D, and S. The name comes from both the operator names and the shortening of the likely response to programming in this language:
  
**Are You Dead Serious?**
  
This language was created as a proof-of-concept for a very simple yet limited language that could at least display output to the console without directly altering memory values. This language technically does not use a stack internally, but incrementing and decrementing numbers does simulate the use of a stack that stores integers.

### Syntax
- R: Resets the stack variable to 0
- U: Increments the stack variable by 1
- D: Decrements the stack variable by 1
- S: Prints out the Unicode character represented by the stack variable

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
