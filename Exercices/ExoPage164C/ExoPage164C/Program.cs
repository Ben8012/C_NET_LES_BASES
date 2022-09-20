int digitChar(char digit)
{
    return int.Parse(digit.ToString());
}
char[] number2Digits(int num)
{
    return num.ToString().ToCharArray();
}
Console.WriteLine("Entrez un premier nombre : ");
string n1 = Console.ReadLine();
Console.WriteLine("Entrez un deuxième nombre : ");
string n2 = Console.ReadLine();
char[] digits1 = n1.ToCharArray();
char[] digits2 = n2.ToCharArray();
int len1 = digits1.Length;
int len2 = digits2.Length;
int moreDigits;
int potentiallyFewerDigits;
char[] numMoreDigits;
char[] numPotentiallyFewerDigits;
if (len1 > len2)
{
    moreDigits = len1;
    numMoreDigits = digits1;
    potentiallyFewerDigits = len2;
    numPotentiallyFewerDigits = digits2;
}
else
{
    moreDigits = len2;
    numMoreDigits = digits2;
    potentiallyFewerDigits = len1;
    numPotentiallyFewerDigits = digits1;
}
Stack<char> additionDigits = new Stack<char>();
int carryOver = 0;
for (int i = 0; i < moreDigits; i++)
{
    int columnAddition = 0;
    columnAddition += digitChar(numMoreDigits[moreDigits - 1 - i]) + carryOver;
    if (i < potentiallyFewerDigits)
    {
        columnAddition += digitChar(numPotentiallyFewerDigits[potentiallyFewerDigits - 1 - i]);
    }
    char[] columnAdditionDigits = number2Digits(columnAddition);
    int howManyDigitsInColumnAddition = columnAdditionDigits.Length;
    if (columnAddition < 10 && i < moreDigits - 1)
    {
        carryOver = 0;
    }
    else
    {
        // carryOver = digitChar(columnAdditionDigits[0]);
        carryOver = digitChar(columnAdditionDigits[0]);
        Console.WriteLine($"carryOver: {carryOver}");
    }
    additionDigits.Push(columnAdditionDigits[howManyDigitsInColumnAddition - 1]);
}
string additionString = "";
if (carryOver > 0)
{
    additionString += carryOver;
}
while (additionDigits.TryPop(out char digit))
{
    additionString += digit;
}
Console.WriteLine($"{n1} + {n2} = {additionString}");