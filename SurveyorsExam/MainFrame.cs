using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SurveyorsExam
{
    public partial class MainFrame : Form
    {
        FrmAnswer frmAnswer = new FrmAnswer();
        FrmTitle frmTitle = new FrmTitle();
        public MainFrame()
        {
            InitializeComponent();
        }

        private void ShowFrm(DockContent frm)
        {
            frm.CloseButton = false;
            frm.HideOnClose = true;
            frm.Show(this.dockPanel1);
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            ShowFrm(frmAnswer);
            ShowFrm(frmTitle);
        }
    }
}
