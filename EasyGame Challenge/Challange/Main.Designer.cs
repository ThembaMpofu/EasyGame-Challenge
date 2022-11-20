namespace Challange
{
    partial class Main
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
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.dgvalldata = new System.Windows.Forms.DataGridView();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btncredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipdebit = new System.Windows.Forms.ToolTip(this.components);
            this.datagrid = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.updatehelp = new System.Windows.Forms.HelpProvider();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(6, 21);
            this.comboClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(233, 23);
            this.comboClient.TabIndex = 0;
            this.comboClient.SelectedIndexChanged += new System.EventHandler(this.comboClient_SelectedIndexChanged);
            this.comboClient.DropDownClosed += new System.EventHandler(this.comboClient_DropDownClosed);
            // 
            // dgvalldata
            // 
            this.dgvalldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatehelp.SetHelpString(this.dgvalldata, " click on the comment tab and change the comment then when changing client it wil" +
        "l save");
            this.dgvalldata.Location = new System.Drawing.Point(5, 95);
            this.dgvalldata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvalldata.Name = "dgvalldata";
            this.dgvalldata.RowHeadersWidth = 51;
            this.dgvalldata.RowTemplate.Height = 24;
            this.updatehelp.SetShowHelp(this.dgvalldata, true);
            this.dgvalldata.Size = new System.Drawing.Size(558, 206);
            this.dgvalldata.TabIndex = 1;
            this.tooltipdebit.SetToolTip(this.dgvalldata, "if you want to change the comment click on the cell double click till you can typ" +
        "e type and change the client it will then save ");
            this.dgvalldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalldata_CellContentClick);
            this.dgvalldata.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalldata_leave);
            this.dgvalldata.Leave += new System.EventHandler(this.dgvalldata_leave);
            // 
            // btnDebit
            // 
            this.btnDebit.BackColor = System.Drawing.Color.White;
            this.btnDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnDebit.Location = new System.Drawing.Point(457, 44);
            this.btnDebit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(106, 34);
            this.btnDebit.TabIndex = 2;
            this.btnDebit.Text = "Debit";
            this.tooltipdebit.SetToolTip(this.btnDebit, "Make sure you select a client to Debit there account");
            this.btnDebit.UseVisualStyleBackColor = false;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btncredit
            // 
            this.btncredit.BackColor = System.Drawing.Color.White;
            this.btncredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncredit.Location = new System.Drawing.Point(337, 44);
            this.btncredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(106, 34);
            this.btncredit.TabIndex = 2;
            this.btncredit.Text = "Credit";
            this.credit.SetToolTip(this.btncredit, "make sure you selected a client to credit there account");
            this.btncredit.UseVisualStyleBackColor = false;
            this.btncredit.Click += new System.EventHandler(this.btncredit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(239, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Easy Games ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Challange.Properties.Resources.images;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(470, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 53);
            this.button1.TabIndex = 5;
            this.datagrid.SetToolTip(this.button1, "After change the comment in the data grid click here pls");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboClient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Cliect";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncredit);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.dgvalldata);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Easy Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.DataGridView dgvalldata;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btncredit;
        private System.Windows.Forms.ToolTip tooltipdebit;
        private System.Windows.Forms.ToolTip credit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip datagrid;
        private System.Windows.Forms.HelpProvider updatehelp;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

