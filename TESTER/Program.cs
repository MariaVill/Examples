// String.Empty - инициализация строк по умолчанию
// rows - ряды в переводе
// table[0,0] table[0,1] table[0,2] ... table[0,4]
// table[1,0] table[1,1] table[1,2] ... table[1,4]
// table[1,1] = "слово";
string[,] table = new string[5, 5];
table[0,1] = "7";
for (int rows = 0; rows < 5; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"{table[rows,columns]}9");
    }
Console.WriteLine();
}
