﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Raul_Paniti_Ejercicio_2
{
    public partial class MenuVegano : Form
    {
        Bebida[] bebidas = { new Bebida("Café", 1.2f), new Bebida("Agua", 1f), new Bebida("Zumo/Refresco", 1.5f),
            new Bebida("Vino", 1.2f) };
        public MenuVegano()
        {
            InitializeComponent();
        }
    }
}
