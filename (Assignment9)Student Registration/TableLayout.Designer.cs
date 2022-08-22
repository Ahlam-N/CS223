namespace Student_Registration
{
    partial class TableLayout
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customCard1 = new Student_Registration.CustomCard();
            this.customCard2 = new Student_Registration.CustomCard();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.customCard1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customCard2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 705);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // customCard1
            // 
            this.customCard1.ADDRESS = null;
            this.customCard1.FIRSTNAME = null;
            this.customCard1.GENDER = null;
            this.customCard1.ID = null;
            this.customCard1.LASTNAME = null;
            this.customCard1.Location = new System.Drawing.Point(3, 3);
            this.customCard1.Name = "customCard1";
            this.customCard1.SCHOOLYEAR = null;
            this.customCard1.Size = new System.Drawing.Size(580, 346);
            this.customCard1.TabIndex = 0;
            // 
            // customCard2
            // 
            this.customCard2.ADDRESS = null;
            this.customCard2.FIRSTNAME = null;
            this.customCard2.GENDER = null;
            this.customCard2.ID = null;
            this.customCard2.LASTNAME = null;
            this.customCard2.Location = new System.Drawing.Point(589, 3);
            this.customCard2.Name = "customCard2";
            this.customCard2.SCHOOLYEAR = null;
            this.customCard2.Size = new System.Drawing.Size(581, 346);
            this.customCard2.TabIndex = 1;
            // 
            // TableLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableLayout";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TableLayout_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomCard customCard1;
        private CustomCard customCard2;
    }
}