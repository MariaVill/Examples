// See https://aka.ms/new-console-template for more information
int a1 = 2;
int b1 = 3;
int c1 = 4;
int a2 = 5;
int b2 = 6;
int c2 = 7;
int a3 = 219;
int b3 = 9;
int c3 = 10;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
