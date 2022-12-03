namespace AocApi.Helpers;

public static class WordHelpers
{
    public static string Capitalise(string input)
    {
        return $"{input[0].ToString().ToUpper()}{input[1..].ToLower()}";
    }

    public static string GetNumberWord(int number)
    {
        return number switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",

            10 => "Ten",
            11 => "Eleven",
            12 => "Twelve",
            13 => "Thirteen",
            14 => "Fourteen",
            15 => "Fifteen",
            16 => "Sixteen",
            17 => "Seventeen",
            18 => "Eighteen",
            19 => "Nineteen",

            20 => "Twenty",
            21 => "Twenty One",
            22 => "Twenty Two",
            23 => "Twenty Three",
            24 => "Twenty Four",
            25 => "Twenty Five",

            _ => "",
        };
    }
}