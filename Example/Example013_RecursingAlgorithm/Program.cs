using static System.Console;
Clear();

// string[,] table = new string[2,5];
// table[1,2] = "word";

// for( int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         WriteLine($"-{table[rows, columns]}-");
//     }
// }


void PrintImage(int[,] image)
{
    for( int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i,j] == 0) Write($" "); 
            else Write($" {image[i, j]} ");
        }
    WriteLine();
    }
}

void FillArray(int[,] matr)
{
   
    for( int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,2);
        }
    }
} 

// void FillImage(int row, int col) // Затрачивает много ресурсов
// {
//     if(image[row,col] == 0)
//     {
//         image[row,col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

int[,] matrix = new int[23,25]; //тут можно вставить картинку
// PrintImage(matrix);
// FillArray(matrix);
// WriteLine("");
// PrintImage(matrix);

double Factorial(int n)
{
    if( n == 1) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 6; i++)
{
    WriteLine($"{i}! = {Factorial(i)}");
}


//Числа Фибоначи
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for(int i = 1; i < 6; i++)
{
    WriteLine($"f({i}) - {Fibonacci(i)}");
}