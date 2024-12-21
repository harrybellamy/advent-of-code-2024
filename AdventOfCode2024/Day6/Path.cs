using Common;

namespace Day6
{
    internal class Path
    {
        private enum Direction
        { 
            NORTH,
            EAST,
            SOUTH,
            WEST
        }

        private readonly Dictionary<Direction, Func<Point, Point>> directionMap = new()
        {
            { Direction.NORTH, p => p.North },
            { Direction.EAST, p => p.East },
            { Direction.SOUTH, p => p.South },
            { Direction.WEST, p => p.West },
        };

        private readonly string[] inputSpace;

        public Path(string[] inputSpace)
        {
            this.inputSpace = inputSpace;
        }

        public long FindPathLength()
        {
            var currentPoint = FindStartPoint();
            var currentDirection = Direction.NORTH;

            var path = new List<Point>();

            while (currentPoint.Valid)
            {
                path.Add(currentPoint);
                if (NextIsObstacle(currentPoint, currentDirection))
                {
                    currentDirection = Rotate(currentDirection);
                    currentPoint = Next(currentPoint, currentDirection);
                }
                else
                {
                    currentPoint = Next(currentPoint, currentDirection);
                }
            }

            return path.DistinctBy(x => new { x.Row, x.Column }).Count();
        }

        private Point Next(Point point, Direction direction)
        { 
            return directionMap[direction](point);
        }

        private bool NextIsObstacle(Point point, Direction direction)
        {
            const char ObstacleChar = '#';
            var checkPoint = Next(point, direction);
            return MatchesCharacter(checkPoint, ObstacleChar);
        }

        private Direction Rotate(Direction direction)
        {
            var rotationMap = new Dictionary<Direction, Direction>
            {
                { Direction.NORTH, Direction.EAST },
                { Direction.EAST, Direction.SOUTH },
                { Direction.SOUTH, Direction.WEST },
                { Direction.WEST, Direction.NORTH },
            };

            return rotationMap[direction];
        }

        private Point FindStartPoint()
        {
            var startPoint = new Point(inputSpace[0].Length, inputSpace.Length);

            while (!MatchesCharacter(startPoint, '^'))
            {
                startPoint = startPoint.Next;
            }

            return startPoint;
        }

        private bool MatchesCharacter(Point point, char character)
        {
            return point.Valid && inputSpace[point.Row][point.Column] == character;
        }
    }
}
