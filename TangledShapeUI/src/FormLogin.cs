using System;
using System.Windows.Forms;

namespace TangledShapeUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            this.InitializeComponent();
            this._lblName.Tag = this._tbxName;
            this._lblFirstName.Tag = this._tbxFirstName;
            this._lblBirthDate.Tag = this._dtpBirthDate;
        }

        private void LblClicked(object sender, EventArgs e)
        {
            if (sender is not Label { Tag: Control target })
            {
                return;
            }

            target.Focus();
        }

        private void BtnStartClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
