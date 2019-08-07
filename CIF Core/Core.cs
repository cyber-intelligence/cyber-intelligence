using System.Drawing;

namespace CIF_Core
{
    public class Core
    {

        #region IndexToLoction
        public static Point IndexToLocation(int index, Size resolution)
        {
            int _X = 0;
            int _Y = 2;
            for (int i = 0; i < index; i++)
            {
                _Y += 120;

                if (_Y >= (resolution.Height + 106))
                {
                    _X += 112;
                    _Y = 2;
                }
            }

            return new Point(_X, _Y);
        }
        #endregion

    }
}