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

