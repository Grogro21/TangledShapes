using System;
using System.Windows.Forms;

namespace TangledShapeUI
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            this.InitializeComponent();
#if DEBUG
            this._lblName.Text = string.Format(this._lblName.Text, "Bob", "Marley");
            this._lblRate.Text = string.Format(this._lblRate.Text, 75.0f);
            this._lblTime.Text = string.Format(
                this._lblTime.Text,
                TimeSpan.FromMinutes(1.75d).ToString(@"m'min 'ss's'")
            );
#endif
        }

        private void BtnBackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
