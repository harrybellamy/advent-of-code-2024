namespace Day5
{
    internal class Update
    {
        private readonly List<int> values;

        public Update(IEnumerable<int> values) 
        {
            if (!values.Any())
            {
                throw new ArgumentException("An update must consist of at least one value.", nameof(values));
            }

            this.values = values.ToList();
        }

        public int MiddleNumber => values[values.Count /2];

        public static Update Parse(string line)
        {
            return new Update(line.Split(',').Select(x => int.Parse(x)));
        }

        public bool SatisfiesRule(Rule rule)
        {
            var beforeIndex = values.IndexOf(rule.Before);
            var afterIndex = values.IndexOf(rule.After);

            if (beforeIndex == -1 || afterIndex == -1)
            {
                return true;
            }

            return beforeIndex < afterIndex;
        }

        public Update MakeValid(IEnumerable<Rule> rules)
        { 
            var rulesInvolvingUpdateNumbers = rules.Where(w => values.Contains(w.Before) && values.Contains(w.After));
            var naiveOrdering = values
                .OrderByDescending(o => rulesInvolvingUpdateNumbers.Count(c => c.Before == o))
                .ThenByDescending(o => rulesInvolvingUpdateNumbers.Count(c => c.After == o));

            return new Update(naiveOrdering);
        }
    }
}
