int Prompt(string messege) {
    System.Console.Write(messege);
    string readInput = System.Console.Write();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent) {
    int power = 1;
    for (int i = 0; int < exponent; i++) {
        power *=powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent) {
    if(exponent < 0 ) {
        System.Console.WriteLine("Показатель должен быть не меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent)) {
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}