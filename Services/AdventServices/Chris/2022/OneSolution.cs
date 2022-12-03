namespace Services.AdventServices.Chris._2022;

public class OneSolution : BaseSolution
{
    private IEnumerable<int> GetLines()
    {
        return GetFileLines(GetFileLocation(2022, 1), line =>
        {
            var isInt = int.TryParse(line, out var num);
            return isInt ? num : -1;
        });
    }

    public override string GetPartOneSolution()
    {
        var lines = GetLines();
        return GetListOfCalories(lines).Max().ToString();
    }

    public override string GetPartTwoSolution()
    {
        var lines = GetLines();
        return GetListOfCalories(lines)
            .OrderByDescending(i => i)
            .Take(3)
            .Sum()
            .ToString();
    }

    private static IEnumerable<int> GetListOfCalories(IEnumerable<int> inputLines)
    {
        var current = 0;
        var output = new List<int>();

        foreach (var inputLine in inputLines)
        {
            if (inputLine == -1)
            {
                output.Add(current);
                current = 0;

                continue;
            }

            current += inputLine;
        }

        return output;
    }
}