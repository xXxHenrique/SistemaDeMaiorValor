using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRever.view
{
    public partial class TelaForm : Form
    {
        public TelaForm()
        {
            InitializeComponent();
        }

       private int NumeroMaior(int num, int num2, int num3)
        {
            int resultado = Math.Max(num,Math.Max(num2,num3));
            return resultado;
        }
        
        private void bnt_Calcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(text_valor1.Text);
            int num2 = Convert.ToInt32(text_valor2.Text);
            int num3 = Convert.ToInt32(text_valor3.Text);

            lbl_Resultado.Text = "O maior valor é " + Math.Max(num,Math.Max(num2,num3));
        }

        private void lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void bnt_Limpar_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = string.Empty;
        }
    }
}
