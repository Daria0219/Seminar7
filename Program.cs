    /*
    двумерный массив размером m×n, заполненный случайными вещественными числами

    Console.WriteLine("Введите число строк m");
    int m=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число столбцов n");
    int n=int.Parse(Console.ReadLine());

void FillList(List<List<double>> MyList){
    for (int i=0; i<m; i++){
        MyList.Add(new List<double>());
        for(int j=0; j<n; j++)
            MyList[i].Add(Math.Round(new Random().NextDouble()*5,1));
    }
}
void PrintList(List<List<double>> MyList){
    for (int i=0; i<MyList.Count; i++){
        for(int j=0; j<MyList[i].Count; j++)
        Console.Write(MyList[i][j]+"  ");
    Console.WriteLine();}
    }
        
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
*/
/* программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

void FillArr (int[,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            array[i,j] = new Random().Next(0,10);}
}   }
void PrintArr(int[,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++)
        {Console.Write(array[i,j]+" ");}
Console.WriteLine();}}

Console.WriteLine("Введите число строк");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int stolb = int.Parse(Console.ReadLine());

int [,] mass = new int[str,stolb];
FillArr(mass);
PrintArr(mass);

Console.WriteLine("Введите позицию элемента в массиве (номер строки и номер столбца");
int numstr = int.Parse(Console.ReadLine());
int numstolb = int.Parse(Console.ReadLine());
if (numstr>str || numstolb>stolb) Console.WriteLine("такого элемента нет");
else Console.WriteLine("значение элемента: "+mass[numstr-1,numstolb-1]);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArr (int[,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            array[i,j] = new Random().Next(0,10);}
}   }
void PrintArr(int[,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++)
        {Console.Write(array[i,j]+" ");}
Console.WriteLine();}}

Console.WriteLine("Введите число строк");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int stolb = int.Parse(Console.ReadLine());

int [,] mass = new int[str,stolb];
FillArr(mass);
PrintArr(mass);
Console.WriteLine();
void SredArifmStolb(int[,] array){
double SredArifm=0;
    for (int j=0; j<array.GetLength(1); j++){
    double sum=0;
        for (int i=0; i<array.GetLength(0); i++){
            sum=sum+array[i,j];}
        SredArifm=Math.Round(sum/array.GetLength(0),2);
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {SredArifm}");}
}
SredArifmStolb(mass);