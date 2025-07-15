
namespace Demo
{
    internal struct Point
    {
        #region Fields
        // Attributes or Fields Should to be Private =>(Encapsolation)
        private int x;  // 4 Bytes
        private int y;  // 4 Bytes 
        #endregion

        #region Constructors
        /// // Constructor : is a Special Funciton
        /// //                  1. Named always with the same Name of its Class or Struct
        /// //                  2. Has No Return
        /// 
        /// // Class Constructor Access Modifire Should to be NOT `private` 
        /// //                   Except for this Case Onle => Singlty Design Pattern
        /// 
        /// // Struct Constructor Access Modifire Should to be NOT `private`

        /// // in Struct, Compiler Will Always Generate Parameterless Constructor
        /// // This Constructor Will Initialize each and every struct object attribute with its default Value
        /// public Point()
        /// {
        ///     // Befor [C# 10.0 .NET 6] we was can't write Parameterless Constructor
        ///     x = default;
        ///     y = default;
        /// }


        public Point()
        {
            x = default;
            y = default;
        }
        public Point(int number)
        {
            this.x = this.y = number;
        }
        public Point(int x, int y)
        {
            /// His have The responsibility to Initilize The Fields
            /// if you don't Initilize it, it will be Initilize it with the default value
            /// And this Feature is start with [C# 7.0 or 11.0]
            /// x = default;
            /// y = default;

            this.x = x;
            this.y = y;
        } 
        #endregion

        #region Methods
        public override string ToString()
        {
            //return base.ToString();
            return $"({this.x}, {this.y})";
        } 
        #endregion
    }
    /*
     
     
     */
}