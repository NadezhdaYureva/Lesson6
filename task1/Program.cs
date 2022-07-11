// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] numbers(int M)
{
    int[] MNum = new int[M];
    for (int i = 0; i < M; i++)
    {
        MNum[i] = prompt($"Введите {i + 1} из {M} чисел ");
    }
    return MNum;
}
int NumberOfPositive(int[] array)
{
    int counter = 0;
    foreach (int el in array)
    {
        if (el > 0) counter++;
    }
    return counter;
}


int M = prompt("Сколько чисел вы хотетите ввести? ");
int[] mynumbers = numbers(M);
Console.WriteLine($"Вы ввели {NumberOfPositive(mynumbers)} чисел больше нуля");
