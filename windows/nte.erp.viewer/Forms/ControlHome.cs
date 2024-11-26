using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nte.erp.viewer
{
  public partial class ControlHome : UserControl
  {
    public ControlHome()
    {
      InitializeComponent();
    }

    #region Export Event 
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
      ThresholdReached?.Invoke(this, e);
    }
    public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);
    public class ThresholdReachedEventArgs : EventArgs
    {
      public int Threshold { get; set; }
      public DateTime TimeReached { get; set; }
    }
    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      ThresholdReached?.Invoke(this, e);
    }
  }
}
