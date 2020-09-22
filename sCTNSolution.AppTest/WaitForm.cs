using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sCTNSolution.AppTest
{
    public partial class WaitForm : Form
    {
        public Action _worker { get; set; }
        public WaitForm(Action worker)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            if(worker == null)
            {
                throw new ArgumentException();
            }
            _worker = worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(_worker).ContinueWith(t=> { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
