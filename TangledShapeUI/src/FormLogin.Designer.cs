namespace TangledShapeUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this._flpInfo = new System.Windows.Forms.FlowLayoutPanel();
            this._flpFirstName = new System.Windows.Forms.FlowLayoutPanel();
            this._lblFirstName = new System.Windows.Forms.Label();
            this._tbxFirstName = new System.Windows.Forms.TextBox();
            this._flpName = new System.Windows.Forms.FlowLayoutPanel();
            this._lblName = new System.Windows.Forms.Label();
            this._tbxName = new System.Windows.Forms.TextBox();
            this._flpBirthDate = new System.Windows.Forms.FlowLayoutPanel();
            this._lblBirthDate = new System.Windows.Forms.Label();
            this._dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this._btnStart = new System.Windows.Forms.Button();
            this._flpInfo.SuspendLayout();
            this._flpFirstName.SuspendLayout();
            this._flpName.SuspendLayout();
            this._flpBirthDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flpInfo
            // 
            this._flpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._flpInfo.Controls.Add(this._flpFirstName);
            this._flpInfo.Controls.Add(this._flpName);
            this._flpInfo.Controls.Add(this._flpBirthDate);
            this._flpInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flpInfo.Location = new System.Drawing.Point(219, 83);
            this._flpInfo.Name = "_flpInfo";
            this._flpInfo.Size = new System.Drawing.Size(345, 115);
            this._flpInfo.TabIndex = 0;
            // 
            // _flpFirstName
            // 
            this._flpFirstName.Controls.Add(this._lblFirstName);
            this._flpFirstName.Controls.Add(this._tbxFirstName);
            this._flpFirstName.Location = new System.Drawing.Point(3, 3);
            this._flpFirstName.Name = "_flpFirstName";
            this._flpFirstName.Size = new System.Drawing.Size(342, 35);
            this._flpFirstName.TabIndex = 0;
            // 
            // _lblFirstName
            // 
            this._lblFirstName.Location = new System.Drawing.Point(3, 0);
            this._lblFirstName.Name = "_lblFirstName";
            this._lblFirstName.Size = new System.Drawing.Size(100, 23);
            this._lblFirstName.TabIndex = 0;
            this._lblFirstName.Text = "Prénom";
            this._lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblFirstName.Click += new System.EventHandler(this.LblClicked);
            // 
            // _tbxFirstName
            // 
            this._tbxFirstName.Location = new System.Drawing.Point(109, 3);
            this._tbxFirstName.Name = "_tbxFirstName";
            this._tbxFirstName.Size = new System.Drawing.Size(200, 20);
            this._tbxFirstName.TabIndex = 0;
            // 
            // _flpName
            // 
            this._flpName.Controls.Add(this._lblName);
            this._flpName.Controls.Add(this._tbxName);
            this._flpName.Location = new System.Drawing.Point(3, 44);
            this._flpName.Name = "_flpName";
            this._flpName.Size = new System.Drawing.Size(342, 29);
            this._flpName.TabIndex = 1;
            // 
            // _lblName
            // 
            this._lblName.Location = new System.Drawing.Point(3, 0);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(100, 23);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Nom";
            this._lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblName.Click += new System.EventHandler(this.LblClicked);
            // 
            // _tbxName
            // 
            this._tbxName.Location = new System.Drawing.Point(109, 3);
            this._tbxName.Name = "_tbxName";
            this._tbxName.Size = new System.Drawing.Size(200, 20);
            this._tbxName.TabIndex = 0;
            // 
            // _flpBirthDate
            // 
            this._flpBirthDate.Controls.Add(this._lblBirthDate);
            this._flpBirthDate.Controls.Add(this._dtpBirthDate);
            this._flpBirthDate.Location = new System.Drawing.Point(3, 79);
            this._flpBirthDate.Name = "_flpBirthDate";
            this._flpBirthDate.Size = new System.Drawing.Size(342, 32);
            this._flpBirthDate.TabIndex = 2;
            // 
            // _lblBirthDate
            // 
            this._lblBirthDate.Location = new System.Drawing.Point(3, 0);
            this._lblBirthDate.Name = "_lblBirthDate";
            this._lblBirthDate.Size = new System.Drawing.Size(100, 23);
            this._lblBirthDate.TabIndex = 0;
            this._lblBirthDate.Text = "Date de naissance";
            this._lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblBirthDate.Click += new System.EventHandler(this.LblClicked);
            // 
            // _dtpBirthDate
            // 
            this._dtpBirthDate.Location = new System.Drawing.Point(109, 3);
            this._dtpBirthDate.Name = "_dtpBirthDate";
            this._dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this._dtpBirthDate.TabIndex = 0;
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(331, 301);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(126, 38);
            this._btnStart.TabIndex = 3;
            this._btnStart.Text = "Démarrer";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this.BtnStartClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._flpInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de connexion";
            this._flpInfo.ResumeLayout(false);
            this._flpFirstName.ResumeLayout(false);
            this._flpFirstName.PerformLayout();
            this._flpName.ResumeLayout(false);
            this._flpName.PerformLayout();
            this._flpBirthDate.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.TextBox _tbxName;
        private System.Windows.Forms.Label _lblBirthDate;
        private System.Windows.Forms.DateTimePicker _dtpBirthDate;
        private System.Windows.Forms.Label _lblFirstName;
        private System.Windows.Forms.TextBox _tbxFirstName;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.FlowLayoutPanel _flpBirthDate;
        private System.Windows.Forms.FlowLayoutPanel _flpFirstName;
        private System.Windows.Forms.FlowLayoutPanel _flpName;
        private System.Windows.Forms.FlowLayoutPanel _flpInfo;

        #endregion
    }
}
