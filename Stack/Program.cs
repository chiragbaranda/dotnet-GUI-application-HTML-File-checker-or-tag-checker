
/// Author: Chirag Baranda
/// 000759867
/// Date:   23 November 2018
/// I, Chirag Baranda, 000759867 certify that this material is my original work. No other person's work has been used without due acknowledgement.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
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
      Application.Run(new Form1());
    }
  }
}
