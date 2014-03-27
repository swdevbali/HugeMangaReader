namespace HugeMangaReader
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdPath = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numVol = new System.Windows.Forms.NumericUpDown();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comic Pages URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(112, 2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(432, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://hugemanga.com/mangas/New Kungfu Boy/Vol ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Save Pages to ";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(112, 78);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(432, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "http://hugemanga.com/mangas/New Kungfu Boy/Vol ";
            // 
            // cmdPath
            // 
            this.cmdPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPath.Location = new System.Drawing.Point(550, 78);
            this.cmdPath.Name = "cmdPath";
            this.cmdPath.Size = new System.Drawing.Size(32, 20);
            this.cmdPath.TabIndex = 1;
            this.cmdPath.Text = "...";
            this.cmdPath.UseVisualStyleBackColor = true;
            // 
            // txtClose
            // 
            this.txtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose.Location = new System.Drawing.Point(12, 218);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(59, 25);
            this.txtClose.TabIndex = 2;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Page";
            // 
            // numVol
            // 
            this.numVol.Location = new System.Drawing.Point(112, 104);
            this.numVol.Name = "numVol";
            this.numVol.Size = new System.Drawing.Size(38, 20);
            this.numVol.TabIndex = 8;
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(112, 135);
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(38, 20);
            this.numPage.TabIndex = 9;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 255);
            this.ControlBox = false;
            this.Controls.Add(this.numPage);
            this.Controls.Add(this.numVol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.cmdPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button cmdPath;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numVol;
        private System.Windows.Forms.NumericUpDown numPage;
    }
}