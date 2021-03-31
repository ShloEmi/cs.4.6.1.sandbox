using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csproj461
{
    public class Class1
    {
        public string AString { get; set; }

        public int AnInt { get; set; }

        protected bool Equals(Class1 other)
        {
            return AString == other.AString && AnInt == other.AnInt;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Class1) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((AString != null ? AString.GetHashCode() : 0) * 397) ^ AnInt;
            }
        }
    }
}
