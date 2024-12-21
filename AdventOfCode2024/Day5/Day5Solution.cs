using Common;

namespace Day5;

public class Day5Solution : ISolution
{
    private IEnumerable<Rule> ParseRules(string[] input)
    { 
        var rules = new List<Rule>();
        foreach (var line in input)
        {
            if (line.Contains('|'))
            { 
                rules.Add(Rule.Parse(line));
            }
        }

        return rules;
    }

    private IEnumerable<Update> ParseUpdates(string[] input)
    { 
        var updates = new List<Update>();
        foreach (var line in input)
        {
            if (line.Contains(','))
            { 
                updates.Add(Update.Parse(line));
            }
        }
        return updates;
    }

    public long SolvePart1(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var rules = ParseRules(lines);
        var updates = ParseUpdates(lines);

        var result = 0;

        foreach (var update in updates)
        {
            var valid = true;
            foreach (var rule in rules)
            {
                if (!update.SatisfiesRule(rule))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
            {
                result += update.MiddleNumber;
            }
        }

        return result;
    }

    public long SolvePart2(string input)
    {
        throw new NotImplementedException();
    }
}
