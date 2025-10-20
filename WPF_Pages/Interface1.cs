using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Pages
{
    public interface Interface1
    {
        void Print(string text);
        void Print(string formatSTR, string textToPrint);
        void Print(List<string> strings);

        bool TryToPrint123();
        void Print(Image img);
    }
}
