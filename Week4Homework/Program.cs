using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_01
{
    class Program
    {

        //Run the following code and step through it using breakpoints in order to understand what is happening
        static void Main(string[] args)
        {
            var a = new Item();
            var b = new Item();
            //using the break point on a and b shows that they are null (absent of values)
            a.Name = "Bob";
            b.Name = "Carly";
            //till the var are assigned a name using the class item public string
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            //Once it gets to this line the breakpoint moves onto the compareTo
            a.Name = "Carly";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Edward";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
        }
    }
    public class Item /*:*/ /*IComparable*/

        //The interface "IComparable" Can be commeted out without breaking the code
    {
        public string Name;

        public int CompareTo(object o)
        {
            Item that = o as Item;
            //The keyword "CompareTo" compares the current instance with another
            //object of the same type and returns an integer that indicates
            //whether the current instance precdes, follows, or occours in the same
            //position in the sort orders as the other object. This creates the values at the top.
            return this.Name.CompareTo(that.Name);
        }
    }
}