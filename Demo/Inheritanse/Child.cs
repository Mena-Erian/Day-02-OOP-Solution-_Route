using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritanse
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            X = x;
            Y = y;
            Z = z;
        }
        /// public Child() : base()
        /// {
        ///         
        /// }


        public override int Product()
        {
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Z = {Z}";
        }
    }
}
