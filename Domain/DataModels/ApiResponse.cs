namespace Domain.DataModels;

public class ApiResponse
{
    public static ApiResponse Make(string partOneSolution = "", string partTwoSolution = "")
    {
        return new ApiResponse
        {
            PartOneSolution = partOneSolution,
            PartTwoSolution = partTwoSolution,
        };
    }

    public string PartOneSolution { get; set; } = string.Empty;

    public string PartTwoSolution { get; set; } = string.Empty;
}