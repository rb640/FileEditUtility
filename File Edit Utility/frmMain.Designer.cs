namespace FilePropertyModifier
{
    partial class frmMain
    {
        /// <summary>
        /// Test
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpAccessTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpModifyTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.Location = new System.Drawing.Point(82, 22);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(372, 20);
            this.dtpCreateTime.TabIndex = 0;
            this.dtpCreateTime.ValueChanged += new System.EventHandler(this.dtpCreateTime_ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(382, 212);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 42);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "GO";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(10, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChooseFile.Location = new System.Drawing.Point(368, 11);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(86, 42);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "BROWSE";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(21, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnChooseFile);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " PATH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpAccessTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpModifyTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpCreateTime);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EDITABLE TIMES";
            // 
            // dtpAccessTime
            // 
            this.dtpAccessTime.Location = new System.Drawing.Point(82, 82);
            this.dtpAccessTime.Name = "dtpAccessTime";
            this.dtpAccessTime.Size = new System.Drawing.Size(372, 20);
            this.dtpAccessTime.TabIndex = 5;
            this.dtpAccessTime.ValueChanged += new System.EventHandler(this.dtpAccessTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "ACCESED";
            // 
            // dtpModifyTime
            // 
            this.dtpModifyTime.Location = new System.Drawing.Point(82, 53);
            this.dtpModifyTime.Name = "dtpModifyTime";
            this.dtpModifyTime.Size = new System.Drawing.Size(372, 20);
            this.dtpModifyTime.TabIndex = 3;
            this.dtpModifyTime.ValueChanged += new System.EventHandler(this.dtpModifyTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "MODDED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREATED";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "EDIT UTILITY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       

        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpAccessTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpModifyTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}