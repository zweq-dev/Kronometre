namespace WindowsFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.saatLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.stopBtn = new Guna.UI2.WinForms.Guna2Button();
            this.resetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(723, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.DarkRed;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 33);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.BackColor = System.Drawing.Color.Transparent;
            this.saatLbl.Font = new System.Drawing.Font("Roboto Bk", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saatLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.saatLbl.Location = new System.Drawing.Point(62, 157);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(647, 129);
            this.saatLbl.TabIndex = 1;
            this.saatLbl.Text = "00:00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "dakika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(403, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "saniye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(562, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "salise";
            // 
            // startBtn
            // 
            this.startBtn.Animated = true;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.CheckedState.Parent = this.startBtn;
            this.startBtn.CustomImages.Parent = this.startBtn;
            this.startBtn.FillColor = System.Drawing.Color.Green;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.HoverState.Parent = this.startBtn;
            this.startBtn.Location = new System.Drawing.Point(507, 358);
            this.startBtn.Name = "startBtn";
            this.startBtn.ShadowDecoration.Parent = this.startBtn;
            this.startBtn.Size = new System.Drawing.Size(180, 45);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Başlat";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.CheckedState.Parent = this.stopBtn;
            this.stopBtn.CustomImages.Parent = this.stopBtn;
            this.stopBtn.FillColor = System.Drawing.Color.Crimson;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.HoverState.Parent = this.stopBtn;
            this.stopBtn.Location = new System.Drawing.Point(294, 358);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.ShadowDecoration.Parent = this.stopBtn;
            this.stopBtn.Size = new System.Drawing.Size(180, 45);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Durdur";
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.CheckedState.Parent = this.resetBtn;
            this.resetBtn.CustomImages.Parent = this.resetBtn;
            this.resetBtn.FillColor = System.Drawing.Color.CornflowerBlue;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.HoverState.Parent = this.resetBtn;
            this.resetBtn.Location = new System.Drawing.Point(81, 358);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.ShadowDecoration.Parent = this.resetBtn;
            this.resetBtn.Size = new System.Drawing.Size(180, 45);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Sıfırla";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kronometre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources.osym_symbol;
            this.pictureBox1.Location = new System.Drawing.Point(181, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saatLbl);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kronometre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button resetBtn;
        private Guna.UI2.WinForms.Guna2Button stopBtn;
        private Guna.UI2.WinForms.Guna2Button startBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

