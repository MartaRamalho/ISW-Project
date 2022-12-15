﻿using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class MagazineISWFormBase : Form
    {
        private IMagazineISWService service;
        public MagazineISWFormBase()
        {
            InitializeComponent();
        }
        public MagazineISWFormBase(IMagazineISWService service) : this()
        {
            this.service = service;
        }
    }
}
