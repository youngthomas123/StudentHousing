﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingApp
{
    public partial class Form8 : Form
    {
        private readonly Building building;
        public Form8(Building building)
        {
            InitializeComponent();
            this.building = building;
        }
    }
}
