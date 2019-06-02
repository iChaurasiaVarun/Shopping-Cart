using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Utils
{
    /// <summary>
    /// To Read file
    /// </summary>
    internal class FileReader
    {
        internal string GetFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
