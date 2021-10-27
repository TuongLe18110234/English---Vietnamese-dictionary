namespace PJ_Dictionary
{
    partial class Form3
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
            this.lb_mean = new System.Windows.Forms.Label();
            this.lb_wordType = new System.Windows.Forms.Label();
            this.lb_pronunciation = new System.Windows.Forms.Label();
            this.lb_word = new System.Windows.Forms.Label();
            this.btn_updateFile = new System.Windows.Forms.Button();
            this.btn_andNewTree = new System.Windows.Forms.Button();
            this.tbx_mean1 = new System.Windows.Forms.TextBox();
            this.tbx_mean4 = new System.Windows.Forms.TextBox();
            this.tbx_mean5 = new System.Windows.Forms.TextBox();
            this.tbx_mean2 = new System.Windows.Forms.TextBox();
            this.tbx_mean3 = new System.Windows.Forms.TextBox();
            this.tbx_pronunciation = new System.Windows.Forms.TextBox();
            this.tbx_wordType = new System.Windows.Forms.TextBox();
            this.tbx_word = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_mean
            // 
            this.lb_mean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_mean.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lb_mean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_mean.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mean.Location = new System.Drawing.Point(153, 361);
            this.lb_mean.Name = "lb_mean";
            this.lb_mean.Size = new System.Drawing.Size(92, 27);
            this.lb_mean.TabIndex = 23;
            this.lb_mean.Text = "Nghĩa:";
            this.lb_mean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_wordType
            // 
            this.lb_wordType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_wordType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lb_wordType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_wordType.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_wordType.Location = new System.Drawing.Point(153, 303);
            this.lb_wordType.Name = "lb_wordType";
            this.lb_wordType.Size = new System.Drawing.Size(92, 27);
            this.lb_wordType.TabIndex = 22;
            this.lb_wordType.Text = "Từ loại:";
            this.lb_wordType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pronunciation
            // 
            this.lb_pronunciation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_pronunciation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lb_pronunciation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_pronunciation.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pronunciation.Location = new System.Drawing.Point(154, 244);
            this.lb_pronunciation.Name = "lb_pronunciation";
            this.lb_pronunciation.Size = new System.Drawing.Size(92, 27);
            this.lb_pronunciation.TabIndex = 20;
            this.lb_pronunciation.Text = "Phát âm:";
            this.lb_pronunciation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_word
            // 
            this.lb_word.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_word.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lb_word.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_word.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_word.Location = new System.Drawing.Point(154, 189);
            this.lb_word.Name = "lb_word";
            this.lb_word.Size = new System.Drawing.Size(92, 27);
            this.lb_word.TabIndex = 21;
            this.lb_word.Text = "Từ:";
            this.lb_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_updateFile
            // 
            this.btn_updateFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_updateFile.AutoSize = true;
            this.btn_updateFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_updateFile.FlatAppearance.BorderSize = 2;
            this.btn_updateFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_updateFile.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateFile.Location = new System.Drawing.Point(619, 244);
            this.btn_updateFile.Name = "btn_updateFile";
            this.btn_updateFile.Size = new System.Drawing.Size(168, 33);
            this.btn_updateFile.TabIndex = 19;
            this.btn_updateFile.Text = "Cập nhật vào file...";
            this.btn_updateFile.UseVisualStyleBackColor = false;
            this.btn_updateFile.Click += new System.EventHandler(this.Btn_updateFile_Click);
            // 
            // btn_andNewTree
            // 
            this.btn_andNewTree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_andNewTree.AutoSize = true;
            this.btn_andNewTree.BackColor = System.Drawing.Color.Transparent;
            this.btn_andNewTree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_andNewTree.FlatAppearance.BorderSize = 2;
            this.btn_andNewTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_andNewTree.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_andNewTree.Location = new System.Drawing.Point(619, 188);
            this.btn_andNewTree.Name = "btn_andNewTree";
            this.btn_andNewTree.Size = new System.Drawing.Size(169, 33);
            this.btn_andNewTree.TabIndex = 18;
            this.btn_andNewTree.Text = "Thêm từ vào cây...";
            this.btn_andNewTree.UseVisualStyleBackColor = false;
            this.btn_andNewTree.Click += new System.EventHandler(this.Btn_andNewTree_Click);
            // 
            // tbx_mean1
            // 
            this.tbx_mean1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_mean1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mean1.Location = new System.Drawing.Point(270, 361);
            this.tbx_mean1.Name = "tbx_mean1";
            this.tbx_mean1.Size = new System.Drawing.Size(245, 28);
            this.tbx_mean1.TabIndex = 17;
            // 
            // tbx_mean4
            // 
            this.tbx_mean4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_mean4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mean4.Location = new System.Drawing.Point(270, 489);
            this.tbx_mean4.Name = "tbx_mean4";
            this.tbx_mean4.Size = new System.Drawing.Size(245, 28);
            this.tbx_mean4.TabIndex = 15;
            // 
            // tbx_mean5
            // 
            this.tbx_mean5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_mean5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mean5.Location = new System.Drawing.Point(270, 531);
            this.tbx_mean5.Name = "tbx_mean5";
            this.tbx_mean5.Size = new System.Drawing.Size(245, 28);
            this.tbx_mean5.TabIndex = 13;
            // 
            // tbx_mean2
            // 
            this.tbx_mean2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_mean2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mean2.Location = new System.Drawing.Point(270, 403);
            this.tbx_mean2.Name = "tbx_mean2";
            this.tbx_mean2.Size = new System.Drawing.Size(245, 28);
            this.tbx_mean2.TabIndex = 16;
            // 
            // tbx_mean3
            // 
            this.tbx_mean3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_mean3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mean3.Location = new System.Drawing.Point(270, 445);
            this.tbx_mean3.Name = "tbx_mean3";
            this.tbx_mean3.Size = new System.Drawing.Size(245, 28);
            this.tbx_mean3.TabIndex = 14;
            // 
            // tbx_pronunciation
            // 
            this.tbx_pronunciation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_pronunciation.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_pronunciation.Location = new System.Drawing.Point(271, 244);
            this.tbx_pronunciation.Name = "tbx_pronunciation";
            this.tbx_pronunciation.Size = new System.Drawing.Size(245, 28);
            this.tbx_pronunciation.TabIndex = 10;
            // 
            // tbx_wordType
            // 
            this.tbx_wordType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_wordType.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_wordType.Location = new System.Drawing.Point(270, 304);
            this.tbx_wordType.Name = "tbx_wordType";
            this.tbx_wordType.Size = new System.Drawing.Size(245, 28);
            this.tbx_wordType.TabIndex = 12;
            // 
            // tbx_word
            // 
            this.tbx_word.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_word.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_word.Location = new System.Drawing.Point(271, 188);
            this.tbx_word.Name = "tbx_word";
            this.tbx_word.Size = new System.Drawing.Size(245, 28);
            this.tbx_word.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PJ_Dictionary.Properties.Resources.update;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 618);
            this.Controls.Add(this.lb_mean);
            this.Controls.Add(this.lb_wordType);
            this.Controls.Add(this.lb_pronunciation);
            this.Controls.Add(this.lb_word);
            this.Controls.Add(this.btn_updateFile);
            this.Controls.Add(this.btn_andNewTree);
            this.Controls.Add(this.tbx_mean1);
            this.Controls.Add(this.tbx_mean4);
            this.Controls.Add(this.tbx_mean5);
            this.Controls.Add(this.tbx_mean2);
            this.Controls.Add(this.tbx_mean3);
            this.Controls.Add(this.tbx_pronunciation);
            this.Controls.Add(this.tbx_wordType);
            this.Controls.Add(this.tbx_word);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_mean;
        public System.Windows.Forms.Label lb_wordType;
        public System.Windows.Forms.Label lb_pronunciation;
        public System.Windows.Forms.Label lb_word;
        public System.Windows.Forms.Button btn_updateFile;
        public System.Windows.Forms.Button btn_andNewTree;
        public System.Windows.Forms.TextBox tbx_mean1;
        public System.Windows.Forms.TextBox tbx_mean4;
        public System.Windows.Forms.TextBox tbx_mean5;
        public System.Windows.Forms.TextBox tbx_mean2;
        public System.Windows.Forms.TextBox tbx_mean3;
        public System.Windows.Forms.TextBox tbx_pronunciation;
        public System.Windows.Forms.TextBox tbx_wordType;
        public System.Windows.Forms.TextBox tbx_word;
    }
}