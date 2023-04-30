namespace THA_W8_Cevin
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
            this.cbShowMatch = new System.Windows.Forms.ComboBox();
            this.dgShowMatch = new System.Windows.Forms.DataGridView();
            this.btnShowDetail = new System.Windows.Forms.Button();
            this.dgPlayerDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShowMatch
            // 
            this.cbShowMatch.FormattingEnabled = true;
            this.cbShowMatch.Location = new System.Drawing.Point(12, 12);
            this.cbShowMatch.Name = "cbShowMatch";
            this.cbShowMatch.Size = new System.Drawing.Size(129, 24);
            this.cbShowMatch.TabIndex = 2;
            this.cbShowMatch.SelectedIndexChanged += new System.EventHandler(this.cbShowMatch_SelectedIndexChanged);
            // 
            // dgShowMatch
            // 
            this.dgShowMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowMatch.Location = new System.Drawing.Point(12, 58);
            this.dgShowMatch.Name = "dgShowMatch";
            this.dgShowMatch.RowHeadersWidth = 51;
            this.dgShowMatch.RowTemplate.Height = 24;
            this.dgShowMatch.Size = new System.Drawing.Size(1142, 378);
            this.dgShowMatch.TabIndex = 3;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Location = new System.Drawing.Point(170, 8);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(91, 31);
            this.btnShowDetail.TabIndex = 4;
            this.btnShowDetail.Text = "Show Detail";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Visible = false;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // dgPlayerDetail
            // 
            this.dgPlayerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayerDetail.Location = new System.Drawing.Point(12, 509);
            this.dgPlayerDetail.Name = "dgPlayerDetail";
            this.dgPlayerDetail.RowHeadersWidth = 51;
            this.dgPlayerDetail.RowTemplate.Height = 24;
            this.dgPlayerDetail.Size = new System.Drawing.Size(1142, 378);
            this.dgPlayerDetail.TabIndex = 5;
            this.dgPlayerDetail.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1180, 983);
            this.ControlBox = false;
            this.Controls.Add(this.dgPlayerDetail);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.dgShowMatch);
            this.Controls.Add(this.cbShowMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShowMatch;
        private System.Windows.Forms.DataGridView dgShowMatch;
        private System.Windows.Forms.Button btnShowDetail;
        private System.Windows.Forms.DataGridView dgPlayerDetail;
    }
}