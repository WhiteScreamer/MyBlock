namespace MyBlock.DateFormFolder
{
    partial class DateForm
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
            this.radioButtonTo = new System.Windows.Forms.RadioButton();
            this.radioButtonForever = new System.Windows.Forms.RadioButton();
            this.radioButtonFromTo = new System.Windows.Forms.RadioButton();
            this.dateTo = new MyBlock.Date();
            this.dateFromToFrom = new MyBlock.Date();
            this.dateFromToTo = new MyBlock.Date();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.myErrorProvider = new MyBlock.UI.MyErrorProvider();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonTo
            // 
            this.radioButtonTo.AutoSize = true;
            this.radioButtonTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTo.Location = new System.Drawing.Point(3, 28);
            this.radioButtonTo.Name = "radioButtonTo";
            this.radioButtonTo.Size = new System.Drawing.Size(66, 30);
            this.radioButtonTo.TabIndex = 14;
            this.radioButtonTo.Text = "To:";
            this.radioButtonTo.UseVisualStyleBackColor = true;
            // 
            // radioButtonForever
            // 
            this.radioButtonForever.AutoSize = true;
            this.radioButtonForever.Checked = true;
            this.radioButtonForever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonForever.Location = new System.Drawing.Point(3, 3);
            this.radioButtonForever.Name = "radioButtonForever";
            this.radioButtonForever.Size = new System.Drawing.Size(66, 19);
            this.radioButtonForever.TabIndex = 13;
            this.radioButtonForever.TabStop = true;
            this.radioButtonForever.Text = "Forever";
            this.radioButtonForever.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromTo
            // 
            this.radioButtonFromTo.AutoSize = true;
            this.radioButtonFromTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonFromTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonFromTo.Location = new System.Drawing.Point(3, 64);
            this.radioButtonFromTo.Name = "radioButtonFromTo";
            this.radioButtonFromTo.Size = new System.Drawing.Size(66, 30);
            this.radioButtonFromTo.TabIndex = 15;
            this.radioButtonFromTo.Text = "From:";
            this.radioButtonFromTo.UseVisualStyleBackColor = true;
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTo.Location = new System.Drawing.Point(75, 28);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(154, 30);
            this.dateTo.TabIndex = 16;
            this.dateTo.Value = new System.DateTime(2022, 7, 7, 15, 51, 0, 0);
            // 
            // dateFromToFrom
            // 
            this.dateFromToFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateFromToFrom.Location = new System.Drawing.Point(75, 64);
            this.dateFromToFrom.Name = "dateFromToFrom";
            this.dateFromToFrom.Size = new System.Drawing.Size(154, 30);
            this.dateFromToFrom.TabIndex = 17;
            this.dateFromToFrom.Value = new System.DateTime(2022, 7, 7, 15, 51, 0, 0);
            // 
            // dateFromToTo
            // 
            this.dateFromToTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateFromToTo.Location = new System.Drawing.Point(291, 64);
            this.dateFromToTo.Name = "dateFromToTo";
            this.dateFromToTo.Size = new System.Drawing.Size(154, 30);
            this.dateFromToTo.TabIndex = 18;
            this.dateFromToTo.Value = new System.DateTime(2022, 7, 7, 15, 51, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(243, 61);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(22, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "To:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonForever, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateFromToTo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonTo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFromTo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateFromToFrom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 97);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(337, 129);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(418, 129);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 22;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // myErrorProvider
            // 
            this.myErrorProvider.ContainerControl = this;
            // 
            // DateForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(521, 164);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "DateForm";
            this.Text = "Set Forbidden Time";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonTo;
        private System.Windows.Forms.RadioButton radioButtonForever;
        private System.Windows.Forms.RadioButton radioButtonFromTo;
        private Date dateTo;
        private Date dateFromToFrom;
        private Date dateFromToTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private UI.MyErrorProvider myErrorProvider;
    }
}