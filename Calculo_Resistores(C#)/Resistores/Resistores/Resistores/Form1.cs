using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistores
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0;
        double serie = 0,paralelo = 0;
        double acumula;

        double i, v, r;

        public Form1()
        {
            InitializeComponent();
            resultado.ReadOnly = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            R1.ReadOnly = false;
            R1.Clear();
            R2.Clear();
            R3.Clear();
            R4.Clear();
            resultado.Clear();
        }

        private void checkBoxI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxI.Checked == true)
            {
                intensidade.Clear();
                intensidade.ReadOnly = true;
                checkBoxR.Enabled = false;
                checkBoxT.Enabled = false;
            }
            else
            {
                intensidade.ReadOnly = false;
                checkBoxR.Enabled = true;
                checkBoxT.Enabled = true;
            }
        }

        private void checkBoxT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxT.Checked == true)
            {
                ddp.Clear();
                ddp.ReadOnly = true;
                checkBoxR.Enabled = false;
                checkBoxI.Enabled = false;
            }
            else
            {
                ddp.ReadOnly = false;
                checkBoxR.Enabled = true;
                checkBoxI.Enabled = true;
            }
        }

        private void checkBoxR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxR.Checked == true)
            {
                resistencia.Clear();
                resistencia.ReadOnly = true;
                checkBoxI.Enabled = false;
                checkBoxT.Enabled = false;
            }
            else
            {
                resistencia.ReadOnly = false;
                checkBoxI.Enabled = true;
                checkBoxT.Enabled = true;
            }
        }

        private void btnAcumula_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                acumula = double.Parse(resultado.Text);
                R1.ReadOnly = true;
                R1.Text = acumula.ToString("0.00");
                R2.Clear();
                R3.Clear();
                R4.Clear();
            }
            else
            {
                MessageBox.Show("\"Resultado\" vazio");
            }
        }

        private void bntTensao_Click(object sender, EventArgs e)
        {
            double i = double.Parse(pot1.Text);
            double k = double.Parse(pot2.Text);
            if (i >= k)
            {
                ddp.Text = (i - k).ToString("0.00");
            }
            else
            {
                ddp.Text = (k - i).ToString("0.00");
            }
        }

        private void ddp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void resistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void intensidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void R1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void R2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void pot1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void pot2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void R3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void R4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (checkBoxI.Checked == true)
            {
                if(ddp.Text == "" || resistencia.Text == "")
                {
                    MessageBox.Show("Falta Tensão e/ou Resistência", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    v = double.Parse(ddp.Text);
                    r = double.Parse(resistencia.Text);
                    if (v == 0)
                    {
                        MessageBox.Show("Como a tensão é igual a 0, não há corrente elétrica!");
                    }
                    else
                    {
                        i = v / r;
                        intensidade.Text = i.ToString("0.00");
                    }
                }
            }
            if(checkBoxR.Checked == true)
            {
                if(ddp.Text == "" || intensidade.Text == "")
                {
                    MessageBox.Show("Falta Tensão e/ou Intensidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    v = double.Parse(ddp.Text);
                    i = double.Parse(intensidade.Text);
                    if (v == 0)
                    {
                        MessageBox.Show("Como a tensão é igual a 0, não há corrente elétrica!");
                    }
                    else
                    {
                        r = v / i;
                        resistencia.Text = r.ToString("0.00");
                    }
                }
            }
            if(checkBoxT.Checked == true)
            {
                if(intensidade.Text == "" || resistencia.Text == "")
                {
                    MessageBox.Show("Falta Intensidade e/ou Resistencia", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    r = double.Parse(resistencia.Text);
                    i = double.Parse(intensidade.Text);
                    v = r * i;
                    ddp.Text = v.ToString("0.00");
                }
            }
            if (checkBoxI.Checked == false && checkBoxR.Checked == false && checkBoxT.Checked == false)
            {
                MessageBox.Show("Selecione um dos Itens [Intensidade,Tensão,Resistência]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            checkBoxT.Checked = false;
            checkBoxT.Enabled = true;

            checkBoxR.Checked = false;
            checkBoxR.Enabled = true;

            checkBoxI.Checked = false;
            checkBoxI.Enabled = true;

            pot1.Clear();
            pot2.Clear();

            intensidade.Text = "";
            intensidade.ReadOnly = false;

            resistencia.Text = "";
            resistencia.ReadOnly = false;

            ddp.Text = "";
            ddp.ReadOnly = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            paralelo = 0;

            if (R1.Text != "")
            {
                paralelo += 1 / (double.Parse(R1.Text));
            }
            if (R2.Text != "")
            {
                paralelo += 1 / (double.Parse(R2.Text));
            }
            if (R3.Text != "")
            {
                paralelo += 1 / (double.Parse(R3.Text));
            }
            if (R4.Text != "")
            {
                paralelo += 1 / (double.Parse(R4.Text));
            }

            if (paralelo == 0) resultado.Text = "Ø";
            else resultado.Text = (1 / paralelo).ToString("0.00");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            serie = 0;
            
            if (R1.Text != "")
            {
                serie += double.Parse(R1.Text);
            }
            if (R2.Text != "")
            {
                serie += double.Parse(R2.Text);
            }
            if (R3.Text != "")
            {
                serie += double.Parse(R3.Text);
            }
            if (R4.Text != "")
            {
                serie += double.Parse(R4.Text);
            }

            if (serie == 0) resultado.Text = "Ø";
            else resultado.Text = serie.ToString("0.00");
        }
    }
}
