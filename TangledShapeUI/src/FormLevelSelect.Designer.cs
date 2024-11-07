namespace TangledShapeUI
{
    partial class FormLevelSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevelSelect));
            this._flpStandardTests = new System.Windows.Forms.FlowLayoutPanel();
            this._btnLevel1 = new System.Windows.Forms.Button();
            this._btnLevel2 = new System.Windows.Forms.Button();
            this._btnLevel3 = new System.Windows.Forms.Button();
            this._btnLevel4 = new System.Windows.Forms.Button();
            this._btnLevel5 = new System.Windows.Forms.Button();
            this._flpMemoryTests = new System.Windows.Forms.FlowLayoutPanel();
            this._btnLevel6 = new System.Windows.Forms.Button();
            this._btnLevel7 = new System.Windows.Forms.Button();
            this._lblStandardTest = new System.Windows.Forms.Label();
            this._lblMemoryTest = new System.Windows.Forms.Label();
            this._pbxPreview = new System.Windows.Forms.PictureBox();
            this._flpStandardTests.SuspendLayout();
            this._flpMemoryTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // _flpStandardTests
            // 
            this._flpStandardTests.Controls.Add(this._btnLevel1);
            this._flpStandardTests.Controls.Add(this._btnLevel2);
            this._flpStandardTests.Controls.Add(this._btnLevel3);
            this._flpStandardTests.Controls.Add(this._btnLevel4);
            this._flpStandardTests.Controls.Add(this._btnLevel5);
            this._flpStandardTests.Location = new System.Drawing.Point(244, 230);
            this._flpStandardTests.Name = "_flpStandardTests";
            this._flpStandardTests.Size = new System.Drawing.Size(326, 89);
            this._flpStandardTests.TabIndex = 0;
            // 
            // _btnLevel1
            // 
            this._btnLevel1.Location = new System.Drawing.Point(3, 3);
            this._btnLevel1.Name = "_btnLevel1";
            this._btnLevel1.Size = new System.Drawing.Size(156, 23);
            this._btnLevel1.TabIndex = 0;
            this._btnLevel1.Text = "Seulement 6 propositions";
            this._btnLevel1.UseVisualStyleBackColor = true;
            this._btnLevel1.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _btnLevel2
            // 
            this._btnLevel2.Location = new System.Drawing.Point(165, 3);
            this._btnLevel2.Name = "_btnLevel2";
            this._btnLevel2.Size = new System.Drawing.Size(156, 23);
            this._btnLevel2.TabIndex = 1;
            this._btnLevel2.Text = "On passe à 9 !";
            this._btnLevel2.UseVisualStyleBackColor = true;
            this._btnLevel2.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _btnLevel3
            // 
            this._btnLevel3.Location = new System.Drawing.Point(3, 32);
            this._btnLevel3.Name = "_btnLevel3";
            this._btnLevel3.Size = new System.Drawing.Size(156, 23);
            this._btnLevel3.TabIndex = 2;
            this._btnLevel3.Text = "Avec de thèmes communs";
            this._btnLevel3.UseVisualStyleBackColor = true;
            this._btnLevel3.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _btnLevel4
            // 
            this._btnLevel4.Location = new System.Drawing.Point(165, 32);
            this._btnLevel4.Name = "_btnLevel4";
            this._btnLevel4.Size = new System.Drawing.Size(156, 23);
            this._btnLevel4.TabIndex = 3;
            this._btnLevel4.Text = "Un seul thème";
            this._btnLevel4.UseVisualStyleBackColor = true;
            this._btnLevel4.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _btnLevel5
            // 
            this._btnLevel5.Location = new System.Drawing.Point(3, 61);
            this._btnLevel5.Name = "_btnLevel5";
            this._btnLevel5.Size = new System.Drawing.Size(318, 23);
            this._btnLevel5.TabIndex = 4;
            this._btnLevel5.Text = "Images abstraites";
            this._btnLevel5.UseVisualStyleBackColor = true;
            this._btnLevel5.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _flpMemoryTests
            // 
            this._flpMemoryTests.Controls.Add(this._btnLevel6);
            this._flpMemoryTests.Controls.Add(this._btnLevel7);
            this._flpMemoryTests.Location = new System.Drawing.Point(244, 383);
            this._flpMemoryTests.Name = "_flpMemoryTests";
            this._flpMemoryTests.Size = new System.Drawing.Size(326, 30);
            this._flpMemoryTests.TabIndex = 1;
            // 
            // _btnLevel6
            // 
            this._btnLevel6.Location = new System.Drawing.Point(3, 3);
            this._btnLevel6.Name = "_btnLevel6";
            this._btnLevel6.Size = new System.Drawing.Size(156, 23);
            this._btnLevel6.TabIndex = 0;
            this._btnLevel6.Text = "Memoire à 9!";
            this._btnLevel6.UseVisualStyleBackColor = true;
            this._btnLevel6.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _btnLevel7
            // 
            this._btnLevel7.Location = new System.Drawing.Point(165, 3);
            this._btnLevel7.Name = "_btnLevel7";
            this._btnLevel7.Size = new System.Drawing.Size(156, 23);
            this._btnLevel7.TabIndex = 1;
            this._btnLevel7.Text = "Un seul thème";
            this._btnLevel7.UseVisualStyleBackColor = true;
            this._btnLevel7.Click += new System.EventHandler(this.BtnLevelClicked);
            // 
            // _lblStandardTest
            // 
            this._lblStandardTest.Location = new System.Drawing.Point(355, 204);
            this._lblStandardTest.Name = "_lblStandardTest";
            this._lblStandardTest.Size = new System.Drawing.Size(100, 23);
            this._lblStandardTest.TabIndex = 0;
            this._lblStandardTest.Text = "Tests Standards";
            this._lblStandardTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblMemoryTest
            // 
            this._lblMemoryTest.Location = new System.Drawing.Point(355, 357);
            this._lblMemoryTest.Name = "_lblMemoryTest";
            this._lblMemoryTest.Size = new System.Drawing.Size(100, 23);
            this._lblMemoryTest.TabIndex = 0;
            this._lblMemoryTest.Text = "Tests Mémoriels";
            this._lblMemoryTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _pbxPreview
            // 
            this._pbxPreview.Location = new System.Drawing.Point(244, 12);
            this._pbxPreview.Name = "_pbxPreview";
            this._pbxPreview.Size = new System.Drawing.Size(326, 178);
            this._pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pbxPreview.TabIndex = 2;
            this._pbxPreview.TabStop = false;
            // 
            // FormLevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._pbxPreview);
            this.Controls.Add(this._lblMemoryTest);
            this.Controls.Add(this._lblStandardTest);
            this.Controls.Add(this._flpMemoryTests);
            this.Controls.Add(this._flpStandardTests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLevelSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sélection de niveau";
            this._flpStandardTests.ResumeLayout(false);
            this._flpMemoryTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbxPreview)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox _pbxPreview;
        private System.Windows.Forms.Label _lblStandardTest;
        private System.Windows.Forms.Label _lblMemoryTest;
        private System.Windows.Forms.FlowLayoutPanel _flpStandardTests;
        private System.Windows.Forms.FlowLayoutPanel _flpMemoryTests;
        private System.Windows.Forms.Button _btnLevel1;
        private System.Windows.Forms.Button _btnLevel2;
        private System.Windows.Forms.Button _btnLevel3;
        private System.Windows.Forms.Button _btnLevel4;
        private System.Windows.Forms.Button _btnLevel5;
        private System.Windows.Forms.Button _btnLevel6;
        private System.Windows.Forms.Button _btnLevel7;

        #endregion
    }
}

