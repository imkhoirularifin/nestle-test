static string DecimalToBinaryRecursive(int decimalNumber)
{
    if (decimalNumber == 0)
        return "";

    int remainder = decimalNumber % 2;
    int quotient = decimalNumber / 2;

    return DecimalToBinaryRecursive(quotient) + remainder;
}

Console.WriteLine("Nestle Test");
Console.WriteLine("Moh Khoirul Arifin Batch 13 Online");
Console.WriteLine();

Console.Write("Enter a decimal number: ");
int decimalNum = Convert.ToInt32(Console.ReadLine());

var binaryNum = DecimalToBinaryRecursive(decimalNum);
Console.WriteLine("Binary number: " + binaryNum);