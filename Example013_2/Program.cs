// числовой массив

// int[,] matrix = new int[3, 4]; // двумерный массив (3 строки и 4 столбца)

// for (int rows = 0; rows < 3; rows++)
// { 
//     for (int columns = 0; columns < 4; columns++) 
//     {
//         Console.Write($"{matrix[rows, columns]} ");
//     }
// Console.WriteLine();
// }

// более правильный вариант написание циклов вместо конкретных чисел 3 и 4 пишем конструкции
// matrix.GetLength(0) и matrix.GetLength(1)
//                      0  1
int[,] matrix = new int[3, 4];

for (int rows = 0; rows < matrix.GetLength(0); rows++) // matrix.GetLength(0) = 3
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++) // matrix.GetLength(1) = 4
    {
        Console.Write($"{matrix[rows, columns]} "); // обязательно использовать Console.Write, чтобы небыло переноса строки
    }
Console.WriteLine(); // перенос на новую строку
}