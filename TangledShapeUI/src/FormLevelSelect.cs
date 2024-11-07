using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TangledShapeUI
{
    public partial class FormLevelSelect : Form
    {
        public FormLevelSelect()
        {
            this.InitializeComponent();
#if DEBUG
            this._pbxPreview.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
#endif
        }

        private void BtnLevelClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
