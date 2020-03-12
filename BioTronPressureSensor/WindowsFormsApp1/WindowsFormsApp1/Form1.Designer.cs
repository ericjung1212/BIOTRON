namespace WindowsFormsApp1
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
            this.sensor1 = new System.Windows.Forms.PictureBox();
            this.sensor2 = new System.Windows.Forms.PictureBox();
            this.sensor3 = new System.Windows.Forms.PictureBox();
            this.sensor4 = new System.Windows.Forms.PictureBox();
            this.sensor5 = new System.Windows.Forms.PictureBox();
            this.sensor6 = new System.Windows.Forms.PictureBox();
            this.sensor7 = new System.Windows.Forms.PictureBox();
            this.sensor8 = new System.Windows.Forms.PictureBox();
            this.sensor9 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor9)).BeginInit();
            this.SuspendLayout();
            // 
            // sensor1
            // 
            this.sensor1.BackColor = System.Drawing.Color.Yellow;
            this.sensor1.Location = new System.Drawing.Point(12, 27);
            this.sensor1.Name = "sensor1";
            this.sensor1.Size = new System.Drawing.Size(100, 100);
            this.sensor1.TabIndex = 0;
            this.sensor1.TabStop = false;
            // 
            // sensor2
            // 
            this.sensor2.BackColor = System.Drawing.Color.Yellow;
            this.sensor2.Location = new System.Drawing.Point(360, 27);
            this.sensor2.Name = "sensor2";
            this.sensor2.Size = new System.Drawing.Size(100, 100);
            this.sensor2.TabIndex = 1;
            this.sensor2.TabStop = false;
            // 
            // sensor3
            // 
            this.sensor3.BackColor = System.Drawing.Color.Yellow;
            this.sensor3.Location = new System.Drawing.Point(703, 27);
            this.sensor3.Name = "sensor3";
            this.sensor3.Size = new System.Drawing.Size(100, 100);
            this.sensor3.TabIndex = 2;
            this.sensor3.TabStop = false;
            // 
            // sensor4
            // 
            this.sensor4.BackColor = System.Drawing.Color.Yellow;
            this.sensor4.Location = new System.Drawing.Point(12, 193);
            this.sensor4.Name = "sensor4";
            this.sensor4.Size = new System.Drawing.Size(100, 100);
            this.sensor4.TabIndex = 3;
            this.sensor4.TabStop = false;
            // 
            // sensor5
            // 
            this.sensor5.BackColor = System.Drawing.Color.Yellow;
            this.sensor5.Location = new System.Drawing.Point(360, 193);
            this.sensor5.Name = "sensor5";
            this.sensor5.Size = new System.Drawing.Size(100, 100);
            this.sensor5.TabIndex = 4;
            this.sensor5.TabStop = false;
            // 
            // sensor6
            // 
            this.sensor6.BackColor = System.Drawing.Color.Yellow;
            this.sensor6.Location = new System.Drawing.Point(703, 193);
            this.sensor6.Name = "sensor6";
            this.sensor6.Size = new System.Drawing.Size(100, 100);
            this.sensor6.TabIndex = 5;
            this.sensor6.TabStop = false;
            // 
            // sensor7
            // 
            this.sensor7.BackColor = System.Drawing.Color.Yellow;
            this.sensor7.Location = new System.Drawing.Point(12, 356);
            this.sensor7.Name = "sensor7";
            this.sensor7.Size = new System.Drawing.Size(100, 100);
            this.sensor7.TabIndex = 6;
            this.sensor7.TabStop = false;
            // 
            // sensor8
            // 
            this.sensor8.BackColor = System.Drawing.Color.Yellow;
            this.sensor8.Location = new System.Drawing.Point(360, 356);
            this.sensor8.Name = "sensor8";
            this.sensor8.Size = new System.Drawing.Size(100, 100);
            this.sensor8.TabIndex = 7;
            this.sensor8.TabStop = false;
            // 
            // sensor9
            // 
            this.sensor9.BackColor = System.Drawing.Color.Yellow;
            this.sensor9.Location = new System.Drawing.Point(703, 356);
            this.sensor9.Name = "sensor9";
            this.sensor9.Size = new System.Drawing.Size(100, 100);
            this.sensor9.TabIndex = 8;
            this.sensor9.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 468);
            this.Controls.Add(this.sensor9);
            this.Controls.Add(this.sensor8);
            this.Controls.Add(this.sensor7);
            this.Controls.Add(this.sensor6);
            this.Controls.Add(this.sensor5);
            this.Controls.Add(this.sensor4);
            this.Controls.Add(this.sensor3);
            this.Controls.Add(this.sensor2);
            this.Controls.Add(this.sensor1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sensor1;
        private System.Windows.Forms.PictureBox sensor2;
        private System.Windows.Forms.PictureBox sensor3;
        private System.Windows.Forms.PictureBox sensor4;
        private System.Windows.Forms.PictureBox sensor5;
        private System.Windows.Forms.PictureBox sensor6;
        private System.Windows.Forms.PictureBox sensor7;
        private System.Windows.Forms.PictureBox sensor8;
        private System.Windows.Forms.PictureBox sensor9;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

