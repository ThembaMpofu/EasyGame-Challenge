namespace Challange
{
    partial class Transactions
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
            this.btncontinue = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncontinue
            // 
            this.btncontinue.BackColor = System.Drawing.Color.White;
            this.btncontinue.FlatAppearance.BorderSize = 0;
            this.btncontinue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinue.Location = new System.Drawing.Point(59, 320);
            this.btncontinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(110, 43);
            this.btncontinue.TabIndex = 0;
            this.btncontinue.Text = "Continue";
            this.btncontinue.UseVisualStyleBackColor = false;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(13, 78);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(213, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(13, 128);
            this.txtamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(213, 26);
            this.txtamount.TabIndex = 1;
            // 
            // txttype
            // 
            this.txttype.Enabled = false;
            this.txttype.Location = new System.Drawing.Point(13, 179);
            this.txttype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttype.Multiline = true;
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(213, 26);
            this.txttype.TabIndex = 1;
            // 
            // txtclient
            // 
            this.txtclient.Enabled = false;
            this.txtclient.Location = new System.Drawing.Point(13, 229);
            this.txtclient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtclient.Multiline = true;
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(213, 26);
            this.txtclient.TabIndex = 1;
            // 
            // txtcomment
            // 
            this.txtcomment.Location = new System.Drawing.Point(13, 280);
            this.txtcomment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcomment.Multiline = true;
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(213, 26);
            this.txtcomment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Client Name ,Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Transaction";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 369);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcomment);
            this.Controls.Add(this.txtclient);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btncontinue);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.TextBox txtcomment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}