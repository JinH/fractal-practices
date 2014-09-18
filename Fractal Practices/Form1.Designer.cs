namespace Fractal_Practices
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtDrawLine = new System.Windows.Forms.TextBox();
            this.PBFractal = new System.Windows.Forms.PictureBox();
            this.lblDrawLine = new System.Windows.Forms.Label();
            this.lblEllipse = new System.Windows.Forms.Label();
            this.txtDrawEllipse = new System.Windows.Forms.TextBox();
            this.GBFeatures = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrawLineTree = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttShow = new System.Windows.Forms.ToolTip(this.components);
            this.ttExit = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.ttClear = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBFractal)).BeginInit();
            this.GBFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(9, 197);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(185, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.ttShow.SetToolTip(this.btnShow, "Click to project fractals.");
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtDrawLine
            // 
            this.txtDrawLine.Location = new System.Drawing.Point(94, 37);
            this.txtDrawLine.Name = "txtDrawLine";
            this.txtDrawLine.Size = new System.Drawing.Size(100, 20);
            this.txtDrawLine.TabIndex = 0;
            // 
            // PBFractal
            // 
            this.PBFractal.Location = new System.Drawing.Point(233, 12);
            this.PBFractal.Name = "PBFractal";
            this.PBFractal.Size = new System.Drawing.Size(610, 610);
            this.PBFractal.TabIndex = 2;
            this.PBFractal.TabStop = false;
            // 
            // lblDrawLine
            // 
            this.lblDrawLine.AutoSize = true;
            this.lblDrawLine.Location = new System.Drawing.Point(6, 44);
            this.lblDrawLine.Name = "lblDrawLine";
            this.lblDrawLine.Size = new System.Drawing.Size(52, 13);
            this.lblDrawLine.TabIndex = 3;
            this.lblDrawLine.Text = "DrawLine";
            // 
            // lblEllipse
            // 
            this.lblEllipse.AutoSize = true;
            this.lblEllipse.Location = new System.Drawing.Point(6, 98);
            this.lblEllipse.Name = "lblEllipse";
            this.lblEllipse.Size = new System.Drawing.Size(62, 13);
            this.lblEllipse.TabIndex = 4;
            this.lblEllipse.Text = "DrawEllipse";
            // 
            // txtDrawEllipse
            // 
            this.txtDrawEllipse.Location = new System.Drawing.Point(94, 91);
            this.txtDrawEllipse.Name = "txtDrawEllipse";
            this.txtDrawEllipse.Size = new System.Drawing.Size(100, 20);
            this.txtDrawEllipse.TabIndex = 1;
            // 
            // GBFeatures
            // 
            this.GBFeatures.Controls.Add(this.btnClear);
            this.GBFeatures.Controls.Add(this.btnExit);
            this.GBFeatures.Controls.Add(this.label1);
            this.GBFeatures.Controls.Add(this.txtDrawLineTree);
            this.GBFeatures.Controls.Add(this.btnShow);
            this.GBFeatures.Controls.Add(this.lblDrawLine);
            this.GBFeatures.Controls.Add(this.txtDrawLine);
            this.GBFeatures.Controls.Add(this.txtDrawEllipse);
            this.GBFeatures.Controls.Add(this.lblEllipse);
            this.GBFeatures.Location = new System.Drawing.Point(12, 12);
            this.GBFeatures.Name = "GBFeatures";
            this.GBFeatures.Size = new System.Drawing.Size(200, 297);
            this.GBFeatures.TabIndex = 6;
            this.GBFeatures.TabStop = false;
            this.GBFeatures.Text = "Features";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DrawLine Tree";
            // 
            // txtDrawLineTree
            // 
            this.txtDrawLineTree.Location = new System.Drawing.Point(94, 148);
            this.txtDrawLineTree.Name = "txtDrawLineTree";
            this.txtDrawLineTree.Size = new System.Drawing.Size(100, 20);
            this.txtDrawLineTree.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit ";
            this.ttExit.SetToolTip(this.btnExit, "Click to exit the application.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.ttClear.SetToolTip(this.btnClear, "Click to clear.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 656);
            this.Controls.Add(this.GBFeatures);
            this.Controls.Add(this.PBFractal);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal Practices";
            ((System.ComponentModel.ISupportInitialize)(this.PBFractal)).EndInit();
            this.GBFeatures.ResumeLayout(false);
            this.GBFeatures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtDrawLine;
        private System.Windows.Forms.PictureBox PBFractal;
        private System.Windows.Forms.Label lblDrawLine;
        private System.Windows.Forms.Label lblEllipse;
        private System.Windows.Forms.TextBox txtDrawEllipse;
        private System.Windows.Forms.GroupBox GBFeatures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrawLineTree;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip ttShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip ttClear;
        private System.Windows.Forms.ToolTip ttExit;
    }
}

