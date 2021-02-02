using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMONIC_Airlines_4
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void addSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSurvey survey = new AddSurvey();
            survey.ShowDialog();        
        }

        private void viewResultSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultSummary result = new ResultSummary();
            result.ShowDialog();
        }

        private void viewDetailResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailResult detail = new DetailResult();
            detail.ShowDialog();
        }
    }
}
