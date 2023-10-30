int Prompt(string messege) {
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int SumALLDigit(int number) {
    int result = 0;
    while (number > 0){
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumALLDigit(number)}");