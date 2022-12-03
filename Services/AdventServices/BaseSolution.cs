namespace Services.AdventServices;

public abstract class BaseSolution : ISolution
{
    private const string BaseFileLocation = "./InputFiles";
    public abstract string GetPartOneSolution();

    public abstract string GetPartTwoSolution();

    protected string GetFileLocation(int year, int day)
    {
        return $"{BaseFileLocation}/{year}/{day}.txt";
    }

    protected string[] GetFileLines(string fileName)
    {
        return File.ReadLines($"{fileName}").ToArray();
    }

    protected T[] GetFileLines<T>(string fileName, Func<string, T> middleFunc)
    {
        var lines = GetFileLines(fileName);
        return lines.Select(middleFunc).ToArray();
    }
}