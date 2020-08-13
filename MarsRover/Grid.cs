using System;

namespace MarsRover
{
    public class Grid
    {
        private int _gridSizeX;
        private int _gridSizeY;

        public Grid(int sizeXGrid, int sizeYGrid)
        {
            _gridSizeX = Math.Abs(sizeXGrid);
            _gridSizeY = Math.Abs(sizeYGrid);
        }

        public int GridHeight() => _gridSizeY;

        public int GridWidth() => _gridSizeX;
    }
}
