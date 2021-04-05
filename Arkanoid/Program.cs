using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
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
      GameModel game = new GameModel(1, 3);
      Application.Run(new Arkanoid(game) {ClientSize = new Size(1000, 700), Text = "Arkanoid"});
    }
  }
}
