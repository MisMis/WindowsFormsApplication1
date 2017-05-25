namespace WindowsFormsApplication1
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
            this.przycisk_polacz = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(177, 322);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(179, 50);
            this.przycisk_polacz.TabIndex = 0;
            this.przycisk_polacz.Text = "polacz";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 12);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(267, 20);
            this.adres.TabIndex = 1;
            this.adres.Text = "adres";
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(12, 38);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(529, 264);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(305, 12);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(236, 20);
            this.my_port.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 384);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.przycisk_polacz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk_polacz;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.NumericUpDown my_port;
    }
}

