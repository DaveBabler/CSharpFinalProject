using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Reflection;

/*color pallete information comes from 
 * http://paletton.com/#uid=75a1b0kwi++bu++hX++++rd++kX
 * & http://paletton.com/#uid=75a1b0kuiiUvNtru4nlwudexs7O */

namespace MadonnaChecker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
      

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadScreen());
        }
    }
}
/*C# Levenshtein Distance - Dot Net Perls. (n.d.). Retrieved April 21, 2018, from https://www.dotnetperls.com/levenshtein
Etienne Rached. (2009, November 17). Connect C# to MySQL - CodeProject. Retrieved April 21, 2018, from https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
How to: Create and Execute an SQL Statement that Returns Rows. (n.d.). Retrieved April 21, 2018, from https://msdn.microsoft.com/en-us/library/fksx3b4f.aspx
Jan Bodnar. (2018). Object-oriented programming II in C#. Retrieved April 21, 2018, from http://zetcode.com/lang/csharp/oopii/
Jon Skeet. (2011, January 29). c# - Array initialization with default constructor - Stack Overflow. Retrieved April 21, 2018, from https://stackoverflow.com/questions/4839470/array-initialization-with-default-constructor
Kreator. (2018, March 20). c# - Visual Studio - Failed to link MySql database table to DataSet - Stack Overflow. Retrieved April 21, 2018, from https://stackoverflow.com/questions/49393375/visual-studio-failed-to-link-mysql-database-table-to-dataset?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
Max. (n.d.). c# - Playing a MP3 file in a WinForm application - Stack Overflow. Retrieved April 21, 2018, from https://stackoverflow.com/questions/15025626/playing-a-mp3-file-in-a-winform-application
Michael Gilleland. (n.d.). Levenshtein Distance. Retrieved April 21, 2018, from https://people.cs.pitt.edu/~kirk/cs1501/Pruhs/Spring2006/assignments/editdistance/Levenshtein%20Distance.htm
Microsoft Visual C#: an Introduction to Object-oriented Programming. (2017). Cengage Learning.
Sarthak Munshi. (n.d.). Minimum Edit Distance - Explained ! - Stanford University. Retrieved from https://www.youtube.com/watch?v=Xxx0b7djCrs
Sarwar Erfan. (n.d.). Connecting to a mySQL database using asp.net - Stack Overflow. Retrieved April 21, 2018, from https://stackoverflow.com/questions/5054430/connecting-to-a-mysql-database-using-asp-net?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
Steve Drake. (2015, April 26). Pause the while loop until the button is pressed w/o using event handler C# - Stack Overflow. Retrieved April 21, 2018, from https://stackoverflow.com/questions/29880362/pause-the-while-loop-until-the-button-is-pressed-w-o-using-event-handler-c-sharp?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
*/
