int SecondDigit(int num)
{
    int secdig;
    secdig = (num % 100) / 10;
    return secdig;
}

int num = 456;
Console.WriteLine("Второе число числа " + num + ": " + SecondDigit(num));

num = 782;
Console.WriteLine("Второе число числа " + num + ": " + SecondDigit(num));

num = 918;
Console.WriteLine("Второе число числа " + num + ": " + SecondDigit(num));