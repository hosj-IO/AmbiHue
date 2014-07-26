using System;
using System.Drawing;

namespace AmbiHue
{
    class Core
    {
        public static Tuple<double, double> GetRGBtoXY(Color c)
        {
            /*Source:
             * https://stackoverflow.com/questions/22564187/rgb-to-philips-hue-hsb
             */
            // For the hue bulb the corners of the triangle are:
            // -Red: 0.675, 0.322
            // -Green: 0.4091, 0.518
            // -Blue: 0.167, 0.04
            var normalizedToOne = new double[3];
            float cred = c.R;
            float cgreen = c.G;
            float cblue = c.B;
            normalizedToOne[0] = (cred / 255);
            normalizedToOne[1] = (cgreen / 255);
            normalizedToOne[2] = (cblue / 255);
            float red, green, blue;

            // Make red more vivid
            if (normalizedToOne[0] > 0.04045)
            {
                red = (float)Math.Pow(
                        (normalizedToOne[0] + 0.055) / (1.0 + 0.055), 2.4);
            }
            else
            {
                red = (float)(normalizedToOne[0] / 12.92);
            }

            // Make green more vivid
            if (normalizedToOne[1] > 0.04045)
            {
                green = (float)Math.Pow((normalizedToOne[1] + 0.055)
                        / (1.0 + 0.055), 2.4);
            }
            else
            {
                green = (float)(normalizedToOne[1] / 12.92);
            }

            // Make blue more vivid
            if (normalizedToOne[2] > 0.04045)
            {
                blue = (float)Math.Pow((normalizedToOne[2] + 0.055)
                        / (1.0 + 0.055), 2.4);
            }
            else
            {
                blue = (float)(normalizedToOne[2] / 12.92);
            }

            var X = (float)(red * 0.649926 + green * 0.103455 + blue * 0.197109);
            var Y = (float)(red * 0.234327 + green * 0.743075 + blue * 0.022598);
            var Z = (float)(red * 0.0000000 + green * 0.053077 + blue * 1.035763);

            var x = X / (X + Y + Z);
            var y = Y / (X + Y + Z);
            var xDouble = Convert.ToDouble(x);
            var yDouble = Convert.ToDouble(y);

            return Tuple.Create(xDouble, yDouble);
        }
    }
}
