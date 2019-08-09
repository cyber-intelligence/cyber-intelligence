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
                _Y += 102;

                if (_Y >= (resolution.Height - 102))
                {
                    _X += 107;
                    _Y = 2;
                }
            }

            return new Point(_X, _Y);
        }
        #endregion

        #region IndexToWallpaperArea
        public static Rectangle IndexToWallpaperArea(int index, Size resolution)
        {
            var indexLocation = IndexToLocation(index, resolution);
            return new Rectangle(new Point(indexLocation.X, indexLocation.Y), new Size(105, 100));
        }
        #endregion

        #region LighterColor
        public static Color LighterColor(Color clr, double Whiteness)
        {
            var red = clr.R;
            var green = clr.G;
            var blue = clr.B;

            var newRed = red + (255 - red) * Whiteness;
            var newGreen = green + (255 - green) * Whiteness;
            var newBlue = blue + (255 - blue) * Whiteness;

            return Color.FromArgb((int)newRed, (int)newGreen, (int)newBlue);
        }
        #endregion

        #region DarkerColor
        public static Color DarkerColor(Color clr, double Darkness)
        {
            var red = clr.R;
            var green = clr.G;
            var blue = clr.B;

            var newRed = red * Darkness;
            var newGreen = green * Darkness;
            var newBlue = blue * Darkness;

            return Color.FromArgb((int)newRed, (int)newGreen, (int)newBlue);
        }
        #endregion

        #region GetForgroundProcessID
        public static int GetForgroundProcessID()
        {

            return 0;
        }
        #endregion

    }
}