namespace TangledShapeUI
{
    partial class FormBetweenLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // _lblResult
            //
            this._lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this._lblResult.Location = new System.Drawing.Point(0, 0);
            this._lblResult.Name = "_lblResult";
            this._lblResult.Size = new System.Drawing.Size(800, 450);
            this._lblResult.TabIndex = 0;
            this._lblResult.Text = "Placeholder";
            this._lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // FormBetweenLevel
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblResult);
            this.Name = "FormBetweenLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Niveau Suivant";
            this.Load += new System.EventHandler(this.FormLoaded);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _lblResult;

        #endregion
    }
}

