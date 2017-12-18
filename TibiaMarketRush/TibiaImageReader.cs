using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TibiaMarketRush
{
    class TibiaImageReader
    {
        private Dictionary<string, Bitmap> Dictionary;
        private Color NumberColor;

        public TibiaImageReader()
        {
            Dictionary = new Dictionary<string, Bitmap>
            {
                { ",", new Bitmap(Properties.Resources.comma) },
                {"0", new Bitmap(Properties.Resources.number_0) },
                {"1", new Bitmap(Properties.Resources.number_1) },
                {"2", new Bitmap(Properties.Resources.number_2) },
                {"3", new Bitmap(Properties.Resources.number_3) },
                {"4", new Bitmap(Properties.Resources.number_4) },
                {"5", new Bitmap(Properties.Resources.number_5) },
                {"6", new Bitmap(Properties.Resources.number_6) },
                {"7", new Bitmap(Properties.Resources.number_7) },
                {"8", new Bitmap(Properties.Resources.number_8) },
                {"9", new Bitmap(Properties.Resources.number_9) }
            };

            NumberColor = Color.FromArgb(244, 244, 244);
        }

        public uint GetValueOfCurrentItem(Point a, Point b)
        {
            Bitmap bitmap = new Bitmap(b.X - a.X + 1, b.Y - a.Y + 1);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(a, b, bitmap.Size);

            return ImageToValue(bitmap);
        }

        private uint ImageToValue(Bitmap image)
        {
            string result = "";

            int x;
            for (x = 0; x < image.Width; x++)
            {
                bool hasBreak = false;
                for (int y = 0; y < image.Height; y++)
                {
                    //if (x == 39 || y == 4)
                    //{
                    //    Console.WriteLine();
                    //}

                    if (image.GetPixel(x, y).Equals(NumberColor))
                    {
                        hasBreak = true;
                        break;
                    }
                }

                if (hasBreak)
                {
                    break;
                }
            }

            for (; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Tuple<bool, string, int> actual = GetChar(image, x, y);

                    if (actual.Item1)
                    {
                        result += actual.Item2;
                        x += actual.Item3;
                    }
                }
            }

            return uint.Parse(result.Replace(",", ""));
        }

        public Tuple<bool, string, int> GetChar(Bitmap image, int x, int y)
        {
            foreach (string key in Dictionary.Keys)
            {
                Bitmap character = Dictionary[key];

                bool sucess = true;
                for (int xx = 0; xx < character.Width; xx++)
                {
                    for (int yy = 0; yy < character.Height; yy++)
                    {
                        if (xx + x >= image.Width || xx + x < 0 || yy + y >= image.Height || yy + y < 0 || image.GetPixel(xx + x, yy + y) != character.GetPixel(xx, yy))
                        {
                            sucess = false;
                            break;
                        }
                    }

                    if (!sucess)
                    {
                        break;
                    }
                }

                if (sucess)
                {
                    return new Tuple<bool, string, int>(true, key, character.Width);
                }
            }

            return new Tuple<bool, string, int>(false, "", -1);
        }

    }
}
