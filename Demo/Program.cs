namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Struct

            #region Some Notes
            // Class Can be DataType or Another But, Struct it Just DataType
            // To Choose between those we should see Memory Alcoation Macanizme
            // if Size small => may be should to be struct and if size more => Class
            // if you want dataAccebalty faster => struct
            #endregion


            Point p1;
            // Declare for Object of type "Point".
            // CLR Alocate 8 UnInitialized Bytes in STACK.

            // new
            /// // new with Class =>
            /// //       new_step1 => CLR Will Allocate the Requard Numbers of bytes of the Object in HEAP
            /// //       new_step2 => Will Initialized with the Default Value of "int" = 0
            /// //       new_step3 => Call User Define Constructor
            /// //       new_step4 => Return the Address of Allocated object in HEAP to Reference in STACK
            /// 
            /// // new with Struct => is just for Constructor Selectrion that
            /// //                     will Initialize the Struct Object Attributes.

            p1 = new Point(1, 2);

            
            Console.WriteLine(p1); // That will make Boxing becouse this will retrun object
            Console.WriteLine(p1.ToString());

            // ToString => Namespace.DatatypeMame "Demo.Point"


            #endregion
        }
    }
}
