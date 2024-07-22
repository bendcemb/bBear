namespace bBear_v2
{
    partial class usctrRecordBy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOther = new System.Windows.Forms.Button();
            this.btnReciept = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnAddPeriod = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.addInvoice1 = new bBear_v2.AddInvoice();
            this.addReciept1 = new bBear_v2.AddReciept();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOther
            // 
            this.btnOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.ForeColor = System.Drawing.Color.White;
            this.btnOther.Location = new System.Drawing.Point(529, 4);
            this.btnOther.Margin = new System.Windows.Forms.Padding(4);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(167, 41);
            this.btnOther.TabIndex = 3;
            this.btnOther.Text = "บันทึก อื่นๆ";
            this.btnOther.UseVisualStyleBackColor = false;
            // 
            // btnReciept
            // 
            this.btnReciept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReciept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReciept.FlatAppearance.BorderSize = 0;
            this.btnReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciept.ForeColor = System.Drawing.Color.White;
            this.btnReciept.Location = new System.Drawing.Point(354, 4);
            this.btnReciept.Margin = new System.Windows.Forms.Padding(4);
            this.btnReciept.Name = "btnReciept";
            this.btnReciept.Size = new System.Drawing.Size(167, 41);
            this.btnReciept.TabIndex = 2;
            this.btnReciept.Text = "บันทึก ใบเสร็จรับเงิน";
            this.btnReciept.UseVisualStyleBackColor = false;
            this.btnReciept.Click += new System.EventHandler(this.btnReciept_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(179, 4);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(167, 41);
            this.btnInvoice.TabIndex = 1;
            this.btnInvoice.Text = "บันทึก ใบแจ้งค่าใช้จ่าย";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnAddPeriod
            // 
            this.btnAddPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPeriod.FlatAppearance.BorderSize = 0;
            this.btnAddPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeriod.ForeColor = System.Drawing.Color.White;
            this.btnAddPeriod.Location = new System.Drawing.Point(4, 4);
            this.btnAddPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPeriod.Name = "btnAddPeriod";
            this.btnAddPeriod.Size = new System.Drawing.Size(167, 41);
            this.btnAddPeriod.TabIndex = 0;
            this.btnAddPeriod.Text = "บันทึก ประจำงวด";
            this.btnAddPeriod.UseVisualStyleBackColor = false;
            this.btnAddPeriod.Click += new System.EventHandler(this.btnAddPeriod_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnOther, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPeriod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReciept, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInvoice, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.addReciept1);
            this.panelContainer.Controls.Add(this.addInvoice1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 49);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1050, 725);
            this.panelContainer.TabIndex = 3;
            // 
            // addInvoice1
            // 
            this.addInvoice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addInvoice1.Location = new System.Drawing.Point(0, 0);
            this.addInvoice1.Name = "addInvoice1";
            this.addInvoice1.Size = new System.Drawing.Size(1050, 725);
            this.addInvoice1.TabIndex = 0;
            // 
            // addReciept1
            // 
            this.addReciept1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addReciept1.Location = new System.Drawing.Point(0, 0);
            this.addReciept1.Name = "addReciept1";
            this.addReciept1.Size = new System.Drawing.Size(1050, 725);
            this.addReciept1.TabIndex = 1;
            // 
            // usctrRecordBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usctrRecordBy";
            this.Size = new System.Drawing.Size(1050, 774);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddPeriod;
        private System.Windows.Forms.Button btnReciept;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContainer;
        private AddReciept addReciept1;
        private AddInvoice addInvoice1;
    }
}
