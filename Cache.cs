namespace CalculationSimulation
{
    /// <summary>
    /// This class acts as a cache of already calculated results
    /// </summary>
    public class Cache
    {
        #region Instance fields
        private int[,] cacheValues;
        private int _xDimension;
        private int _yDimension;
        #endregion

        #region Constructor
        public Cache()
        {
            // Create a 5x5 cache of results
            cacheValues = new int[_xDimension, _yDimension];

            for (int x = 0; x < _xDimension; x++)
            {
                for (int y = 0; y < _yDimension; y++)
                {
                    cacheValues[x, y] = -1; // -1 means "no result stored"
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Look up the value stored in cell [x,y]
        /// </summary>
        public int Lookup(int x, int y)
        {
            return cacheValues[x, y];
        }

        /// <summary>
        /// Stores the given value in cell [x,y]
        /// </summary>
        public void Insert(int x, int y, int value)
        {
            cacheValues[x, y] = value;
        }
        public int xValue{
            get{return _xDimension;}
            set{_xDimension = value;}
        }
        public int yValue{
            get{return _yDimension;}
            set{_yDimension = value;}
        } 
        #endregion
    }
}
