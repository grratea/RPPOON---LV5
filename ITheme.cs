using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public interface ITheme
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);

    }
}
