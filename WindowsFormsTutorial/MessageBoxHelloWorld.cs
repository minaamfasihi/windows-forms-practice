using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTutorial
{
    class MessageBoxHelloWorld
    {
        public void PlayingWithWindowsForms()
        {
            //MessageBox.Show("Hello World");
            //MessageBox.Show("Hello, World!", "MessageBoxHelloWorld");
            //MessageBox.Show("Hi there", "MessageBoxHelloWorld", MessageBoxButtons.OKCancel);
            //MessageBox.Show("Hi there", "MessageBoxHelloWorld", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            DialogResult dr = MessageBox.Show("Hi there", "MessageBoxHelloWorld", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            switch (dr)
            {
                case DialogResult.OK:
                    Console.WriteLine("Yoohooo");
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        //static void Main(string[] args)
        //{
            
        //}
    }
}
