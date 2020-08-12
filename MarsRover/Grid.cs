using System;

namespace MarsRover
{
    public class Grid
    {
        private int _xCoordinates;
        private int _yCoordinates;
        private int _gridSizeX;
        private int _gridSizeY;


        public Grid(int x, int y, int sizeXGrid, int sizeYGrid)
        {
            _xCoordinates = Math.Abs(x);
            _yCoordinates = Math.Abs(y);
            _gridSizeX = Math.Abs(sizeXGrid);
            _gridSizeY = Math.Abs(sizeYGrid);
        }

        public Grid GridEntryAndSizeValidation(Grid grid)
        {
            if (grid._xCoordinates > grid._gridSizeX || grid._yCoordinates > grid._gridSizeY)
            {
                grid._xCoordinates = 0;
                grid._yCoordinates = 0;
            }

            return grid;
        }

        public int XCoordinate() => _xCoordinates;

        public int YCoordinate() => _yCoordinates;

        public int GridHeight() => _gridSizeY;

        public int GridWidth() => _gridSizeX;
    }
}
