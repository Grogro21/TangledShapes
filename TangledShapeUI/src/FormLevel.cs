using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TangledShapeUI
{
    public partial class FormLevel : Form
    {
        public FormLevel()
        {
            this.InitializeComponent();
#if DEBUG
            this.Text = string.Format(this.Text, "Debug");
            this._pbxQuestion.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer1.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer2.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer3.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer4.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer5.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer6.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer7.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer8.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));
            this._pbxAnswer9.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!,
                "assets/placeholder.jpg"));

            this._pbxAnswer1.Tag = true;
            this._pbxAnswer2.Tag = true;
            this._pbxAnswer3.Tag = true;
            this._pbxAnswer4.Tag = false;
            this._pbxAnswer5.Tag = false;
            this._pbxAnswer6.Tag = false;
            this._pbxAnswer7.Tag = false;
            this._pbxAnswer8.Tag = false;
            this._pbxAnswer9.Tag = false;
#endif
        }

        private void PbxAnswerClicked(object sender, EventArgs e)
        {
            if (sender is not PictureBox { Tag: bool isValid } pbxAnswer)
            {
                return;
            }

            ControlPaint.DrawBorder(
                pbxAnswer.CreateGraphics(),
                pbxAnswer.ClientRectangle,
                isValid ? Color.Green : Color.Red,
                ButtonBorderStyle.Solid
            );
            pbxAnswer.Click -= this.PbxAnswerClicked;
        }
    }
}
