using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_CircleCalculation.UI
{
  public partial class CalcForm : Form
  {
    public CalcForm() {
      InitializeComponent();
    }

    private void edRadius_Leave(object sender, EventArgs e) {
      if(edRadius.Text.Length == 0) return;
      double r = 0.0;

      try {
        r = Double.Parse(edRadius.Text);
      } catch(FormatException fe) {
        MessageBox.Show("Wrong Numberformat\nPlease correct the input!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      double A = r * r * Math.PI;
      double C = 2 * r * Math.PI;

      edArea.Text = A.ToString("N6");
      edCircum.Text = C.ToString("N6");
    }
  }
}
