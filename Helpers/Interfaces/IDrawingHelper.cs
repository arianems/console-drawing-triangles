using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesTest.Helpers.Interfaces
{
    public interface IDrawingHelper
    {
        void WriteBlankColumns(int blankColumns);
        void WriteFullRow(int rowWidth);

        void WriteBorderedBlankRow(int rowWidth);
    }
}
