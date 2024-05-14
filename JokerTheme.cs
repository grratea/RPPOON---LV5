using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{

    public class JokerTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('=', width);
        }

        public string GetHeader(int width)
        {
            return new string('=', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }
}
