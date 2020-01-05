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
    public partial class EplanForm : Form
    {
        public DockContent tree;
        public DockContent editor;
        public EplanForm()
        {
            InitializeComponent();
            InitLayOut();
        }

        public void InitLayOut()
        {
           
            tree = new Tree(dockPanel1);
            editor = new Edictor(dockPanel1);
     
        }
    }
}
