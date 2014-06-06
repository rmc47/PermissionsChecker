using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermissionsChecker
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new MainForm());
        }
    }
}
