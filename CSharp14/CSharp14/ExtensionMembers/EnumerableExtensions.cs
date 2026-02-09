using System.Collections.Generic;
using System.Linq;

namespace CSharp14.ExtensionMembers
{
    internal static class EnumerableExtensions
    {
        extension<T>(IEnumerable<T> source)
        {
            // extension property:
            public bool IsEmpty => !source.Any();

            // static extension Opertor:
            public static IEnumerable<T> operator +(IEnumerable<T> left, IEnumerable<T> right) => left.Concat(right);
        }
    }
}
