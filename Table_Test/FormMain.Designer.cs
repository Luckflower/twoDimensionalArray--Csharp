namespace Table_Test
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.panTable = new System.Windows.Forms.Panel();
            this.tmRandom = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行：";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(48, 10);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 21);
            this.txtRow.TabIndex = 1;
            this.txtRow.Text = "10";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(189, 10);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(100, 21);
            this.txtColumn.TabIndex = 3;
            this.txtColumn.Text = "9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "列：";
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(295, 8);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(75, 23);
            this.btnGenerator.TabIndex = 4;
            this.btnGenerator.Text = "生成";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(376, 8);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "随机累加";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // panTable
            // 
            this.panTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTable.Location = new System.Drawing.Point(13, 41);
            this.panTable.Name = "panTable";
            this.panTable.Size = new System.Drawing.Size(649, 372);
            this.panTable.TabIndex = 6;
            // 
            // tmRandom
            // 
            this.tmRandom.Tick += new System.EventHandler(this.tmRandom_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(587, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 425);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.panTable);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "二维数组";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Panel panTable;
        private System.Windows.Forms.Timer tmRandom;
        private System.Windows.Forms.Button btnPause;
    }
}

