int Prompt(string messege) {
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] GenerateArray(int Length, int minValue, int maxValue) {
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++) {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}
void PrintArray(int[] array) {
    System.Console.WriteLine("[");
    for (int i = 0; i < array.Length - 1; i++) {
        System.Console.WriteLine($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(Length, min, max);
PrintArray(array);