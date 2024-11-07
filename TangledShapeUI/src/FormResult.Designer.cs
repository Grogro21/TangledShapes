namespace TangledShapeUI
{
    partial class FormResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this._flpResult = new System.Windows.Forms.FlowLayoutPanel();
            this._lblName = new System.Windows.Forms.Label();
            this._lblRate = new System.Windows.Forms.Label();
            this._lblTime = new System.Windows.Forms.Label();
            this._btnBack = new System.Windows.Forms.Button();
            this._flpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flpResult
            // 
            this._flpResult.Controls.Add(this._lblName);
            this._flpResult.Controls.Add(this._lblRate);
            this._flpResult.Controls.Add(this._lblTime);
            this._flpResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flpResult.Location = new System.Drawing.Point(162, 72);
            this._flpResult.Name = "_flpResult";
            this._flpResult.Size = new System.Drawing.Size(426, 218);
            this._flpResult.TabIndex = 0;
            // 
            // _lblName
            // 
            this._lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblName.Location = new System.Drawing.Point(3, 0);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(423, 69);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Bravo {0} {1} !";
            this._lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblRate
            // 
            this._lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRate.Location = new System.Drawing.Point(3, 69);
            this._lblRate.Name = "_lblRate";
            this._lblRate.Size = new System.Drawing.Size(423, 71);
            this._lblRate.TabIndex = 1;
            this._lblRate.Text = "Taux de réussite : {0}%";
            this._lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblTime
            // 
            this._lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTime.Location = new System.Drawing.Point(3, 140);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(423, 78);
            this._lblTime.TabIndex = 2;
            this._lblTime.Text = "Temps Ecoulé : {0}";
            this._lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnBack
            // 
            this._btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBack.Location = new System.Drawing.Point(221, 318);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(321, 42);
            this._btnBack.TabIndex = 1;
            this._btnBack.Text = "Revenir à la sélection";
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this.BtnBackClicked);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnBack);
            this.Controls.Add(this._flpResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Résultats";
            this._flpResult.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.Label _lblRate;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.FlowLayoutPanel _flpResult;

        #endregion
    }
}

