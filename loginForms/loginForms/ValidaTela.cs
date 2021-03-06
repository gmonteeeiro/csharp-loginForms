﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loginForms
{
    public static class ValidaTela
    {
        public static bool CampoPreenchido(this TextBox obj, string campo)
        {
            //Se o campo está preenchido, retorna verdadeiro
            if (!string.IsNullOrEmpty(obj.Text)) return true;

            MessageBox.Show($"Campo '{campo}' não preenchido!");
            obj.Focus();
            return false;
        }
    }
}
