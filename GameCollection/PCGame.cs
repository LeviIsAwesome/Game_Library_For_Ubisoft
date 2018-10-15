﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollection
{
    public partial class pcGameUC : UserControl
    {
        private static pcGameUC _instance;
        public static pcGameUC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new pcGameUC();
                }
                return _instance;
            }
        }
        public pcGameUC()
        {
            InitializeComponent();
        }

        private void pcGameUC_Load(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
