using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p25aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabMultiplic_Click(object sender, EventArgs e)
        {
            if(textBoxNumTab.Text == "") {

                lblRes.Text = "Informe um Número Para de Continuar!";

            } else {

                int lblNumTab;
                lblNumTab = Convert.ToInt32(textBoxNumTab.Text);

                for(var i = 0; i <= 10; i ++) {

                    listBoxMultiplic.Items.Add(lblNumTab + " X " + i + " = " + lblNumTab * i);
                }
            }
        }

        private void btnTabSomando_Click(object sender, EventArgs e)
        {
            if (textBoxNumTab.Text == "") {

                lblRes.Text = "Informe um Número Para de Continuar!";

            }
            else {

                int lblNumTab;
                lblNumTab = Convert.ToInt32(textBoxNumTab.Text);

                for (var i = 0; i <= 10; i++) {

                    listBoxSomar.Items.Add(lblNumTab + " + " + i + " = " + (lblNumTab + i));
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxNumTab.Clear();
            listBoxSomar.Items.Clear();
            listBoxMultiplic.Items.Clear();
            lblRes.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
