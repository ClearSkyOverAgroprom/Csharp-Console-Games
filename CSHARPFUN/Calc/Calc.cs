List<char> formula = new List<char>();
List<string> formulaString = new List<string>();
int plusExists = 0;
int minusExists = 0;
int multiplyExists = 0;
int divideExists = 0;
int numberOne = 0;
int numberTwo = 0;
    
while (true)
{
    Console.WriteLine("Enter formula");
    formula = Console.ReadLine().ToList();
    
    formulaString = formula.Select(x => x.ToString()).ToList();
    
    plusExists = formula.IndexOf('+');
    if (plusExists != -1)
    {
        List<string> beforePlus  = formulaString.GetRange(0, plusExists);
        List<string> afterPlus = formulaString.GetRange(plusExists +1, formula.Count - plusExists -1);
        int beforePlusInt = int.Parse(string.Join("", beforePlus));
        int afterPlusInt = int.Parse(string.Join("", afterPlus));
        int result = beforePlusInt + afterPlusInt;
        Console.WriteLine($"{beforePlusInt} + {afterPlusInt} = {result}");
    }
    
    minusExists = formula.IndexOf('-');
    if (minusExists != -1)
    {
        List<string> beforeMinus  = formulaString.GetRange(0, minusExists);
        List<string> afterMinus = formulaString.GetRange(minusExists +1, formula.Count - minusExists - 1);
        int beforeMinusInt = int.Parse(string.Join("", beforeMinus));
        int afterMinusInt = int.Parse(string.Join("", afterMinus));
        int result = beforeMinusInt - afterMinusInt;
        Console.WriteLine($"{beforeMinusInt} - {afterMinusInt} = {result}");
    }
    
    multiplyExists = formula.IndexOf('*');
    if (multiplyExists != -1)
    {
        List<string> beforeMultiply  = formulaString.GetRange(0, multiplyExists);
        List<string> afterMultiply = formulaString.GetRange(multiplyExists +1, formula.Count - multiplyExists-1);
        int beforeMultiplyInt = int.Parse(string.Join("", beforeMultiply));
        int afterMultiplyInt = int.Parse(string.Join("", afterMultiply));
        double result = beforeMultiplyInt * afterMultiplyInt;
        Console.WriteLine($"{beforeMultiplyInt} * {afterMultiplyInt} = {result}");
    }
    
    divideExists = formula.IndexOf('/');
    if (divideExists != -1)
    {
        List<string> beforeDivide  = formulaString.GetRange(0, divideExists);
        List<string> afterDivide = formulaString.GetRange(divideExists +1, formula.Count - divideExists-1);
        int beforeDivideInt = int.Parse(string.Join("", beforeDivide));
        int afterDivideInt = int.Parse(string.Join("", afterDivide));
        double result = beforeDivideInt / afterDivideInt;
        Console.WriteLine($"{beforeDivideInt} / {afterDivideInt} = {result}");
    }
}