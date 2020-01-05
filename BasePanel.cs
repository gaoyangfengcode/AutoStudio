using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AutoStudio
{
    public partial class BasePanel : DockContent
    {
        public DockWindow leftSon;
        public BasePanel()
        {
            
            InitializeComponent();
            
            
            
      }
    }

    public class Tree : BasePanel
    {
        public Tree(DockPanel master)
        {
            Show(master,DockState.DockLeft);
            
        }
    }

    public class Edictor : BasePanel
    {
        public Edictor(DockPanel master)
        {
            Show(master, DockState.Document);
        }
    }

}
