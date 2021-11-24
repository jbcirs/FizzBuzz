using System;
using System.Collections.Generic;
using System.Text;

public class FizzBuzz
{
    public static void Main()
    {
        var result = fizzbuzz<string>(1, 100);
        Console.WriteLine(result);

        var rules = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"}
        };

        result = fizzbuzz<string>(1, 100, rules);
        Console.WriteLine(result);
    }

    public static T fizzbuzz<T>(int start, int end) where T : class
    {
        var result = string.Empty;

        for (int i = start; i <= end; i++)
        {
            var phrase = string.Empty;

            if (i % 3 == 0)
            {
                phrase += "Fizz";
            }

            if (i % 5 == 0)
            {
                phrase += "Buzz";
            }

            if (!string.IsNullOrWhiteSpace(phrase))
            {
                result += $" {phrase} ";
            }
            else
            {
                result += $" {i} ";
            }    
        }

        return result as T;
    }

    public static T fizzbuzz<T>(int start, int end, Dictionary<int, string> rules) where T : class
    {
        var result = new StringBuilder();

        for (int i = start; i <= end; i++)
        {
            var ruleMatched = false;

            foreach (var rule in rules)
            {
                if (i % rule.Key == 0)
                {
                    result.Append(rule.Value);
                    ruleMatched = true;
                }
            }

            if (!ruleMatched)
            {
                result.Append(i);
            }

            result.Append("\n");
        }

        return result.ToString() as T;
    }
}