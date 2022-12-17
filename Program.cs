void FillArrayInt (int[,] arrayInt){
    for (int line = 0; line < arrayInt.GetLength(0); line ++){
        for (int columns = 0; columns < arrayInt.GetLength(1); columns ++){
            arrayInt[line, columns] = new Random().Next(1, 101);
            Console.Write($"{arrayInt[line, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (double[,] array){
    for (int line = 0; line < array.GetLength(0); line ++){
        for (int columns = 0; columns < array.GetLength(1); columns ++){
            array[line, columns] = Math.Round(new Random().NextDouble()  * (-10-1) + 10, 2);
            Console.Write($"{array[line, columns]} ");
        }
        Console.WriteLine();
    }
}
void CheckPosition (double[,] array, int xPosition, int yPosition){
if (yPosition < array.GetLength(0) && xPosition < array.GetLength(1)){
     Console.WriteLine($"{array[yPosition, xPosition]}");
}
else {
    Console.Write($"Элемента с индексацией: {yPosition},{xPosition} не существует");
}
}

void CheckPositionInt (int [,] arrayInt, int xPosition, int yPosition){
if (yPosition < arrayInt.GetLength(0) && xPosition < arrayInt.GetLength(1)){
     Console.WriteLine($"{arrayInt[yPosition, xPosition]}");
}
else {
    Console.Write($"Элемента с индексацией: {yPosition},{xPosition} не существует");
}
}

void Average (int [,] arrayInt){
    double avg = 0;
    for (int i = 0; i < arrayInt.GetLength(1); i ++){
        avg = 0;
        for (int j = 0; j < arrayInt.GetLength(0); j ++){
            avg = avg + arrayInt[j, i];
        }
        avg = avg / arrayInt.GetLength(0);
          Console.Write($"{Math.Round(avg, 1)}; ");    //почему то не выводит разделитель       //Console.Write($"{string.Join("; ", Math.Round(avg, 2))}");
    }
    
}





Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество индексов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Каким типом данных заполнить массив?: 1 - целые, 2 - дробные: ");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1){
    int [,] arrayInt = new int[m, n];
    FillArrayInt(arrayInt);
        Console.Write("Нужно ли провести поиск элемента? 1 - да, 2 - нет: ");
choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 2) {
    Console.WriteLine("Нужно ли посчитать среднее арифметическое каждого столбца?: 1 - да, 2 - нет: ");
    choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1){
        Average(arrayInt);
    }
        else if (choice == 2){
        Console.Write("Программа завершена");
    }
}

    else if (choice == 1) {
Console.Write("Введите номер строки: ");
int yPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер индекса: ");
int xPosition = Convert.ToInt32(Console.ReadLine());
CheckPositionInt(arrayInt, xPosition, yPosition);
}
}


else if (choice == 2){
    double [,] array = new double[m, n];
    FillArray(array);

    Console.Write("Нужно ли провести поиск элемента? 1 - да, 2 - нет: ");
choice = Convert.ToInt32(Console.ReadLine());
if (choice == 2) {
    Console.WriteLine("Программа завершена");
    }
else if (choice == 1) {
Console.Write("Введите номер строки: ");
int yPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер индекса: ");
int xPosition = Convert.ToInt32(Console.ReadLine());
CheckPosition(array, xPosition, yPosition);
    }
}