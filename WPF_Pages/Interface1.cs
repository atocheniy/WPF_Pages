using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Pages
{
    public interface Interface1
    {
        void Print(string text);
        void Print(string format, string text);
        void Print();

        bool TryToPrint123();
    }
}
