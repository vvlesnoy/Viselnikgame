﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: Закоммитить последние изменения
// TODO: Написать комментарии по коду
namespace ViselnikGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }
      private  void newForm() {
         

          Form2 f2 = new Form2();
          this.Hide();
          f2.Show();
        }

      private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
      {
          newForm();
      }



    }
}
