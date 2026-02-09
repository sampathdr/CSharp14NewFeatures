using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14.ExtensionMembers
{
    /// <summary>
    /// Extension Members
    /// </summary>
    internal static class StringExtensions
    {
        extension(string str)
        {
            public bool IsBlank => string.IsNullOrWhiteSpace(str);
            public int WordCount => string.IsNullOrWhiteSpace(str) ? 0 : str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
