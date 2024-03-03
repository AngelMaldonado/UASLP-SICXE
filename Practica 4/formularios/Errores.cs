﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSICXE
{
    public partial class Errores : Form
    {
        //MUESTRA LOS ERRORES
        public Errores(List<string> errores)
        {
            InitializeComponent();
            Error.Text = String.Join("\n", errores);
        }
    }
}
