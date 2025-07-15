using Demo.Encapsulation;

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

            #region new Kayword Between Class and Struct
            // new
            /// // new with Class =>
            /// //       new_step1 => CLR Will Allocate the Requard Numbers of bytes of the Object in HEAP
            /// //       new_step2 => Will Initialized with the Default Value of "int" = 0
            /// //       new_step3 => Call User Define Constructor
            /// //       new_step4 => Return the Address of Allocated object in HEAP to Reference in STACK
            /// 
            /// // new with Struct => is just for Constructor Selectrion that
            /// //                     will Initialize the Struct Object Attributes.
            #endregion

            /// Point p1;
            /// // Declare for Object of type "Point".
            /// // CLR Alocate 8 UnInitialized Bytes in STACK.
            /// 
            /// p1 = new Point(1, 2);
            /// 
            /// Console.WriteLine(p1); // That will make Boxing becouse this will retrun object
            /// Console.WriteLine(p1.ToString());
            /// // ToString => Namespace.DatatypeMame "Demo.Point"
            #endregion

            #region OOP Pillars
            //OOP

            //1. Encapsulation >> Fields should to be private
            //                      >> separate data Defination from it Used
            //2. Inheritance   >> single inherit >> Dog is an Animal, Doctor is a Person NOT Another
            //                      >> just support with Class becouse (Memory mecanizme of class)
            //                      >> to make like realy, Don't Repeat the code
            //3. PolyMarphism       >> overloads , override(Should have inheritance)
            //4. Absraction    >>  
            #endregion

            #region Encapsulation
            /// Employee employee = new Employee(1001, "Mena Erian", 10_000)
            /// {
            ///     Name = "Ahmad Mahmoud"
            /// };
            /// 
            /// //employee.id = 1002;   // SET id through the Field itself
            /// //Console.WriteLine(employee.id); // GET id through the Field itself
            /// 
            /// employee.SetId(1002);
            /// employee.Name = "Mina";
            /// 
            /// 
            /// Console.WriteLine(employee.GetId());
            /// Console.WriteLine(employee.Name);
            /// 
            /// 
            /// Console.WriteLine(employee);
            #endregion

        }
    }
}
