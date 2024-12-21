namespace Common
{
    public class Point
    {
        private readonly int maxColumn;
        private readonly int maxRow;
        private int currentColumn;
        private int currentRow;

        public Point(int maxColumn, int maxRow)
        {
            this.maxColumn = maxColumn;
            this.maxRow = maxRow;
            currentColumn = 0;
            currentRow = 0;
        }

        public int Column => this.currentColumn;
        public int Row => this.currentRow;

        public bool Valid => ExtentsCheck(currentColumn, currentRow);
        public Point North => NewPoint(currentColumn, currentRow - 1);
        public Point NorthWest => NewPoint(currentColumn - 1, currentRow - 1);
        public Point NorthEast => NewPoint(currentColumn + 1, currentRow - 1);
        public Point South => NewPoint(currentColumn, currentRow + 1);
        public Point SouthWest => NewPoint(currentColumn - 1, currentRow + 1);
        public Point SouthEast => NewPoint(currentColumn + 1, currentRow + 1);
        public Point West => NewPoint(currentColumn - 1, currentRow);
        public Point East => NewPoint(currentColumn + 1, currentRow);
        public Point Next => East.Valid ? East : NewPoint(0, currentRow + 1);

        private bool ExtentsCheck(int column, int row)
        {
            return column >= 0 && row >= 0 && column < maxColumn && row < maxRow;
        }

        private Point NewPoint(int column, int row)
        {
            var retval = new Point(maxColumn, maxRow)
            {
                currentColumn = column,
                currentRow = row
            };
            return retval;
        }

        public override string ToString()
        {
            return $"Current Column: {currentColumn}, Current Row: {currentRow}";
        }
    }
}
