using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTutorial
{
    class MyDocumentsFolder
    {
        public static void Main()
        {
            MessageBox.Show(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "My Documents Folder"
                );
        }
    }
}
