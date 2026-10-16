namespace Ultra_Calc_Xtrem;

class Program
{
    static void Main(string[] args)
    {
        List<int> results = new List<int>();
        List<char> formula = new List<char>();
 
        while (true)
        {
            Console.WriteLine("Enter formula");
            formula = (Console.ReadLine() ?? "").ToList();

            int plusExists = formula.IndexOf('+');
            if (plusExists != -1)
            {
                results = GetFormulaNumbers(formula, plusExists);
                double result = results[1] + results[2];
                Console.WriteLine($"{results[1]} + {results[2]} = {result}");
            }

            int minusExists = formula.IndexOf('-');
            if (minusExists != -1)
            {
                results = GetFormulaNumbers(formula, minusExists);
                double result = results[1] - results[2];
                Console.WriteLine($"{results[1]} - {results[2]} = {result}");
            }

            int multiplyExists = formula.IndexOf('*');
            if (multiplyExists != -1)
            {
                results = GetFormulaNumbers(formula, multiplyExists);
                double result = results[1] * results[2];
                Console.WriteLine($"{results[1]} * {results[2]} = {result}");
            }

            int divideExists = formula.IndexOf('/');
            if (divideExists != -1)
            {
                results = GetFormulaNumbers(formula, divideExists);
                double result = results[1] / results[2];
                Console.WriteLine($"{results[1]} / {results[2]} = {result}");
            }
            
        }
    }

    private static List<int> GetFormulaNumbers(List<char> formula, int operatorPos)
    {
        List<int> result = new List<int>();
        List<string> formulaString = formula.Select(x => x.ToString()).ToList();
        List<string> beforeDivide = formulaString.GetRange(0, operatorPos);
        List<string> afterDivide = formulaString.GetRange(1 + operatorPos , formula.Count - operatorPos);
        int beforeDivideInt = int.Parse(string.Join("", beforeDivide));
        int afterDivideInt = int.Parse(string.Join("", afterDivide));
        result.Add(beforeDivideInt);
        result.Add(afterDivideInt);
        return result;
    }
}