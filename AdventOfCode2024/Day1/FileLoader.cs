namespace Day1
{
    internal class FileLoader
    {
        private static readonly string defaultFileName = "input.txt";

        public string LoadInput() => File.ReadAllText(defaultFileName);
    }
}
