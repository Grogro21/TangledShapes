using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TangledShapeUI
{
    public partial class FormBetweenLevel : Form
    {
        public FormBetweenLevel(bool isPreviousLevelSuccess = false)
        {
            this.InitializeComponent();

            this._lblResult.Text = isPreviousLevelSuccess ? "Bravo!" : "Dommage!";
        }

        private async void FormLoaded(object sender, EventArgs e)
        {
            await Task.Delay(5_000);

            throw new NotImplementedException();
        }
    }
}
