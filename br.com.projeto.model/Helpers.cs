using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Vendas.br.com.projeto.model;

public class Helpers
{
    public static void LimparTela(Control controle)
    {
        foreach (Control c in controle.Controls)
        {
            if (c is TextBoxBase text)
            {
                text.Clear();
            }
            else if (c is ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1;
            }
            else if (c is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }
            else if (c is RadioButton radioButton)
            {
                radioButton.Checked = false;
            }

            if (c.HasChildren)
            {
                LimparTela(c);
            }
        }
    }
}
