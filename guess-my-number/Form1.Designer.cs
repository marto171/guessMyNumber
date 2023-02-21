namespace guess_my_number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureQuestMark = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblMaxPoint = new System.Windows.Forms.Label();
            this.lblCurResult = new System.Windows.Forms.Label();
            this.lblMaxResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestMark)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(28, 30);
            this.btnAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(136, 47);
            this.btnAgain.TabIndex = 0;
            this.btnAgain.Text = "Отначало!";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Между 1 и 20)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(288, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Познай числото!";
            // 
            // pictureQuestMark
            // 
            this.pictureQuestMark.Image = ((System.Drawing.Image)(resources.GetObject("pictureQuestMark.Image")));
            this.pictureQuestMark.Location = new System.Drawing.Point(292, 123);
            this.pictureQuestMark.Name = "pictureQuestMark";
            this.pictureQuestMark.Size = new System.Drawing.Size(155, 99);
            this.pictureQuestMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureQuestMark.TabIndex = 3;
            this.pictureQuestMark.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(472, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(197, 58);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Започнете играта...";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(472, 345);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(57, 20);
            this.lblPoint.TabIndex = 6;
            this.lblPoint.Text = "Точки:";
            // 
            // lblMaxPoint
            // 
            this.lblMaxPoint.AutoSize = true;
            this.lblMaxPoint.Location = new System.Drawing.Point(472, 378);
            this.lblMaxPoint.Name = "lblMaxPoint";
            this.lblMaxPoint.Size = new System.Drawing.Size(103, 20);
            this.lblMaxPoint.TabIndex = 7;
            this.lblMaxPoint.Text = "Макс. точки:";
            // 
            // lblCurResult
            // 
            this.lblCurResult.Location = new System.Drawing.Point(535, 345);
            this.lblCurResult.Name = "lblCurResult";
            this.lblCurResult.Size = new System.Drawing.Size(88, 20);
            this.lblCurResult.TabIndex = 8;
            this.lblCurResult.Text = "20";
            // 
            // lblMaxResult
            // 
            this.lblMaxResult.Location = new System.Drawing.Point(581, 378);
            this.lblMaxResult.Name = "lblMaxResult";
            this.lblMaxResult.Size = new System.Drawing.Size(51, 20);
            this.lblMaxResult.TabIndex = 9;
            this.lblMaxResult.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Въведи число:";
            // 
            // txtBxNumber
            // 
            this.txtBxNumber.Location = new System.Drawing.Point(172, 286);
            this.txtBxNumber.Name = "txtBxNumber";
            this.txtBxNumber.Size = new System.Drawing.Size(125, 26);
            this.txtBxNumber.TabIndex = 11;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(28, 338);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(269, 47);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Провери!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вашето число беше:";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(644, 312);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(30, 20);
            this.lblNumber.TabIndex = 14;
            this.lblNumber.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaxResult);
            this.Controls.Add(this.lblCurResult);
            this.Controls.Add(this.lblMaxPoint);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureQuestMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Познай числото";
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureQuestMark;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblMaxPoint;
        private System.Windows.Forms.Label lblCurResult;
        private System.Windows.Forms.Label lblMaxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumber;
    }
}

