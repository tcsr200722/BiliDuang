﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace BiliDuang.UI
{
    public partial class EditSession : MaterialForm
    {
        public EditSession()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            Other.RefreshColorSceme();

            materialSingleLineTextField1.Text = User.cookie;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            User.cookie = materialSingleLineTextField1.Text;
            User.SaveUserInfo();
            User.RefreshUserInfo();
            Close();
            Dispose();
        }
    }
}
