Star Pattern Programs in C#
/**[Star_Pattern_Readme.pdf](https://github.com/user-attachments/files/17562788/Star_Pattern_Readme.pdf)
**/
This document contains various star pattern programs written in C#. Each code snippet is
followed by an explanation and the expected output to illustrate how the patterns look
when executed.
1. Inverted Triangle and Right Triangle Patterns
Code:
```csharp
for(int i = 1; i <= 5; i++) {
for(int j = 5; j >= i; j--) {
Console.Write(" * ");
}
Console.WriteLine();
}
Console.WriteLine("\n\n");
for(int i = 1; i <= 5; i++) {
for(int j = 1; j <= i; j++) {
Console.Write(" * ");
}
Console.WriteLine();
}```
Explanation:
This code creates two different patterns. The first pattern is an inverted triangle, while the
second pattern is a right triangle that grows from 1 to 5 rows.
Expected Output:
* * * * *
* * * *
* * *
* *
*

*
* *
* * *
* * * *
* * * * *2. Right-Aligned Triangle Pattern
Code:
```csharp
int i, j;
for(i = 1; i <= 5; i++) {
for(j = 5; j > i; j--) {
Console.Write(" ");
}
for(j = 1; j <= i; j++) {
Console.Write("*");
}
Console.WriteLine(" ");
}
```
Explanation:
This code creates a right-aligned triangle pattern with spaces on the left side to align the
stars to the right.
Expected Output:
*
**
***
****
*****
3. Center-Aligned Triangle Pattern
Code:
```csharp
for(i = 1; i <= 5; i++) {
for(j = 5; j > i; j--) {
Console.Write(" ");
}
for(j = 1; j <= 2 * i - 1; j++) {
Console.Write("*");
}
Console.WriteLine();}
```
Explanation:
This code generates a center-aligned triangle. It adjusts spaces to create a centered pyramid
pattern.
Expected Output:
*
***
*****
*******
*********
4. Symmetrical Triangle Star Pattern
Code:
```csharp
for(i = 1; i <= 5; i++) {
for(j = 5; j > i; j--) {
Console.Write(" ");
}
for(j = 1; j <= i; j++) {
Console.Write("*");
}
for(j = 1; j < i; j++) {
Console.Write("*");
}
Console.WriteLine();
}
```
Explanation:
This code generates a symmetrical triangle by printing stars on both left and right sides of
the center.Expected Output:
*
***
*****
*******
*********
5. Diamond Shape Pattern
Code:
```csharp
for(i = 1; i <= 5; i++) {
for(j = 5; j > i; j--) {
Console.Write(" ");
}
for(j = 1; j <= i; j++) {
Console.Write("*");
}
for(j = 1; j < i; j++) {
Console.Write("*");
}
Console.WriteLine();
}
for(i = 1; i <= 4; i++) {
for(j = 1; j <= i; j++) {
Console.Write(" ");
}
for(j = 4; j >= i; j--) {
Console.Write("*");
}
for(j = 4; j > i; j--) {
Console.Write("*");
}
Console.WriteLine();
}
```Explanation:
This code generates a diamond shape by combining a pyramid pattern (upper part) and an
inverted pyramid pattern (lower part).
Expected Output:
    *
   ***
  *****
 *******
*********
 *******
  *****
  ***
   *
