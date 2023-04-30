namespace THA_W8_Cevin
{
    partial class Form2
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
            this.cbPlayerData = new System.Windows.Forms.ComboBox();
            this.cbChoosePlayer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbPlayerData
            // 
            this.cbPlayerData.FormattingEnabled = true;
            this.cbPlayerData.Location = new System.Drawing.Point(12, 12);
            this.cbPlayerData.Name = "cbPlayerData";
            this.cbPlayerData.Size = new System.Drawing.Size(129, 24);
            this.cbPlayerData.TabIndex = 1;
            this.cbPlayerData.SelectedIndexChanged += new System.EventHandler(this.cbPlayerData_SelectedIndexChanged_1);
            // 
            // cbChoosePlayer
            // 
            this.cbChoosePlayer.Enabled = false;
            this.cbChoosePlayer.FormattingEnabled = true;
            this.cbChoosePlayer.Location = new System.Drawing.Point(165, 12);
            this.cbChoosePlayer.Name = "cbChoosePlayer";
            this.cbChoosePlayer.Size = new System.Drawing.Size(129, 24);
            this.cbChoosePlayer.TabIndex = 2;
            this.cbChoosePlayer.SelectedIndexChanged += new System.EventHandler(this.cbChoosePlayer_SelectedIndexChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1162, 568);
            this.ControlBox = false;
            this.Controls.Add(this.cbChoosePlayer);
            this.Controls.Add(this.cbPlayerData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayerData;
        private System.Windows.Forms.ComboBox cbChoosePlayer;
    }
}