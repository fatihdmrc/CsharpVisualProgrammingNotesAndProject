namespace Görsel_Programlama_Hafta_4_Analog_Saat
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
            this.components = new System.ComponentModel.Container();
            this.pctrbxSaat = new System.Windows.Forms.PictureBox();
            this.pctrbxAkrep = new System.Windows.Forms.PictureBox();
            this.pctrbxYelkovan = new System.Windows.Forms.PictureBox();
            this.pctrbxSaniye = new System.Windows.Forms.PictureBox();
            this.pctrbxMiliSaniye = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxAkrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxYelkovan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxMiliSaniye)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxSaat
            // 
            this.pctrbxSaat.Image = global::Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.kadran;
            this.pctrbxSaat.Location = new System.Drawing.Point(2, -3);
            this.pctrbxSaat.Name = "pctrbxSaat";
            this.pctrbxSaat.Size = new System.Drawing.Size(500, 500);
            this.pctrbxSaat.TabIndex = 0;
            this.pctrbxSaat.TabStop = false;
            // 
            // pctrbxAkrep
            // 
            this.pctrbxAkrep.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxAkrep.Image = global::Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.akrep;
            this.pctrbxAkrep.Location = new System.Drawing.Point(220, 113);
            this.pctrbxAkrep.Name = "pctrbxAkrep";
            this.pctrbxAkrep.Size = new System.Drawing.Size(500, 500);
            this.pctrbxAkrep.TabIndex = 2;
            this.pctrbxAkrep.TabStop = false;
            // 
            // pctrbxYelkovan
            // 
            this.pctrbxYelkovan.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxYelkovan.Image = global::Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.yelkovan;
            this.pctrbxYelkovan.Location = new System.Drawing.Point(211, 257);
            this.pctrbxYelkovan.Name = "pctrbxYelkovan";
            this.pctrbxYelkovan.Size = new System.Drawing.Size(500, 500);
            this.pctrbxYelkovan.TabIndex = 3;
            this.pctrbxYelkovan.TabStop = false;
            // 
            // pctrbxSaniye
            // 
            this.pctrbxSaniye.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxSaniye.Image = global::Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.saniye;
            this.pctrbxSaniye.Location = new System.Drawing.Point(153, 301);
            this.pctrbxSaniye.Name = "pctrbxSaniye";
            this.pctrbxSaniye.Size = new System.Drawing.Size(500, 500);
            this.pctrbxSaniye.TabIndex = 4;
            this.pctrbxSaniye.TabStop = false;
            // 
            // pctrbxMiliSaniye
            // 
            this.pctrbxMiliSaniye.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxMiliSaniye.Image = global::Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.mili;
            this.pctrbxMiliSaniye.Location = new System.Drawing.Point(298, 384);
            this.pctrbxMiliSaniye.Name = "pctrbxMiliSaniye";
            this.pctrbxMiliSaniye.Size = new System.Drawing.Size(500, 500);
            this.pctrbxMiliSaniye.TabIndex = 5;
            this.pctrbxMiliSaniye.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(147, 517);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(185, 31);
            this.lblSaat.TabIndex = 6;
            this.lblSaat.Text = "00:00:00:000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 662);
            this.Controls.Add(this.pctrbxSaat);
            this.Controls.Add(this.pctrbxMiliSaniye);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.pctrbxSaniye);
            this.Controls.Add(this.pctrbxYelkovan);
            this.Controls.Add(this.pctrbxAkrep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxAkrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxYelkovan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxMiliSaniye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxSaat;
        private System.Windows.Forms.PictureBox pctrbxAkrep;
        private System.Windows.Forms.PictureBox pctrbxYelkovan;
        private System.Windows.Forms.PictureBox pctrbxSaniye;
        private System.Windows.Forms.PictureBox pctrbxMiliSaniye;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
    }
}

