// Опишем метод, который будет отдельно печатать матрицу (двумерный массив)
// на экран и заполнять ее числами

void PrintArray(int[,] matr) // метод вывода массива на экран
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // matrix.GetLength(0) = 3
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // matrix.GetLength(1) = 4
        {
            Console.Write($"{matr[rows, columns]} "); // обязательно использовать Console.Write, чтобы небыло переноса строки
        }
        Console.WriteLine(); // перенос на новую строку
    }
}

void FillArray(int[,] matr) // метод заполнения нашего двумерного массива matrix случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4]; // создаем двумерный числовой массив

PrintArray(matrix); // вызов метода вывода двумерного массива на экран
FillArray(matrix); // заполняем двумерный массив случайными числами
Console.WriteLine(); // отступ между двумя массивами
PrintArray(matrix); // выводим на экран заполненный двумерный массив
