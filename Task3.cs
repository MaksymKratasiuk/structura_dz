using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structura_dz
{
    public struct RGBColor
    {
        public int red;
        public int green;
        public int blue;

        public RGBColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public string ToHex()
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue);
        }

        public HSLColor ToHSL()
        {
            double r = (double)red / 255;
            double g = (double)green / 255;
            double b = (double)blue / 255;

            double cMax = Math.Max(Math.Max(r, g), b);
            double cMin = Math.Min(Math.Min(r, g), b);
            double delta = cMax - cMin;

            double hue = 0;
            if (delta != 0)
            {
                if (cMax == r)
                {
                    hue = ((g - b) / delta) % 6;
                }
                else if (cMax == g)
                {
                    hue = ((b - r) / delta) + 2;
                }
                else
                {
                    hue = ((r - g) / delta) + 4;
                }
                hue *= 60;
                if (hue < 0)
                {
                    hue += 360;
                }
            }

            double lightness = (cMax + cMin) / 2;

            double saturation = 0;
            if (delta != 0)
            {
                saturation = delta / (1 - Math.Abs(2 * lightness - 1));
            }

            return new HSLColor(hue, saturation, lightness);
        }

        public CMYKColor ToCMYK()
        {
            double r = (double)red / 255;
            double g = (double)green / 255;
            double b = (double)blue / 255;

            double k = 1 - Math.Max(Math.Max(r, g), b);
            double c = (1 - r - k) / (1 - k);
            double m = (1 - g - k) / (1 - k);
            double y = (1 - b - k) / (1 - k);

            return new CMYKColor(c, m, y, k);
        }
    }
    public struct HSLColor
    {
        public double hue;
        public double saturation;
        public double lightness;

        public HSLColor(double hue, double saturation, double lightness)
        {
            this.hue = hue;
            this.saturation = saturation;
            this.lightness = lightness;
        }
    }

    public struct CMYKColor
    {
        public double cyan;
        public double magenta;
        public double yellow;
        public double key;

        public CMYKColor(double cyan, double magenta, double yellow, double key)
        {
            this.cyan = cyan;
            this.magenta = magenta;
            this.yellow = yellow;
            this.key = key;
        }
    }


    internal class Task3
    {
        public static void task3()
        {
            RGBColor rgbColor = new RGBColor(255, 0, 0);
            string hexColor = rgbColor.ToHex();
            Console.WriteLine(hexColor);

            rgbColor = new RGBColor(255, 0, 0);
            HSLColor hslColor = rgbColor.ToHSL();
            Console.WriteLine("H: {0}, S: {1}, L: {2}", hslColor.hue, hslColor.saturation, hslColor.lightness);
            


        }
    }
}
