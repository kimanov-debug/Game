namespace Game
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kart1 = new Button();
            kart2 = new Button();
            kart3 = new Button();
            kart4 = new Button();
            kart5 = new Button();
            kart6 = new Button();
            kart7 = new Button();
            kart8 = new Button();
            lblXal = new Label();
            lblNetice = new Label();
            btnYeniOyun = new Button();
            btnCixis = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            kart1.BackColor = Color.Gainsboro;
            kart1.FlatAppearance.BorderSize = 0;
            kart1.FlatStyle = FlatStyle.Flat;
            kart1.Location = new Point(126, 47);
            kart1.Name = "kart1";
            kart1.Size = new Size(176, 188);
            kart1.TabIndex = 0;
            kart1.UseVisualStyleBackColor = false;
            kart1.Click += kart_Click;
            kart2.BackColor = Color.Gainsboro;
            kart2.FlatAppearance.BorderSize = 0;
            kart2.FlatStyle = FlatStyle.Flat;
            kart2.Location = new Point(412, 47);
            kart2.Name = "kart2";
            kart2.Size = new Size(176, 188);
            kart2.TabIndex = 1;
            kart2.UseVisualStyleBackColor = false;
            kart2.Click += kart_Click;
            kart3.BackColor = Color.Gainsboro;
            kart3.FlatAppearance.BorderSize = 0;
            kart3.FlatStyle = FlatStyle.Flat;
            kart3.Location = new Point(715, 47);
            kart3.Name = "kart3";
            kart3.Size = new Size(176, 188);
            kart3.TabIndex = 2;
            kart3.UseVisualStyleBackColor = false;
            kart3.Click += kart_Click;
            kart4.BackColor = Color.Gainsboro;
            kart4.FlatAppearance.BorderSize = 0;
            kart4.FlatStyle = FlatStyle.Flat;
            kart4.Location = new Point(998, 47);
            kart4.Name = "kart4";
            kart4.Size = new Size(176, 188);
            kart4.TabIndex = 3;
            kart4.UseVisualStyleBackColor = false;
            kart4.Click += kart_Click;
            kart5.BackColor = Color.Gainsboro;
            kart5.FlatAppearance.BorderSize = 0;
            kart5.FlatStyle = FlatStyle.Flat;
            kart5.Location = new Point(126, 366);
            kart5.Name = "kart5";
            kart5.Size = new Size(176, 188);
            kart5.TabIndex = 4;
            kart5.UseVisualStyleBackColor = false;
            kart5.Click += kart_Click;
            kart6.BackColor = Color.Gainsboro;
            kart6.FlatAppearance.BorderSize = 0;
            kart6.FlatStyle = FlatStyle.Flat;
            kart6.Location = new Point(412, 366);
            kart6.Name = "kart6";
            kart6.Size = new Size(176, 188);
            kart6.TabIndex = 5;
            kart6.UseVisualStyleBackColor = false;
            kart6.Click += kart_Click;
            kart7.BackColor = Color.Gainsboro;
            kart7.FlatAppearance.BorderSize = 0;
            kart7.FlatStyle = FlatStyle.Flat;
            kart7.Location = new Point(715, 366);
            kart7.Name = "kart7";
            kart7.Size = new Size(176, 188);
            kart7.TabIndex = 6;
            kart7.UseVisualStyleBackColor = false;
            kart7.Click += kart_Click;
            kart8.BackColor = Color.Gainsboro;
            kart8.FlatAppearance.BorderSize = 0;
            kart8.FlatStyle = FlatStyle.Flat;
            kart8.Location = new Point(998, 366);
            kart8.Name = "kart8";
            kart8.Size = new Size(176, 188);
            kart8.TabIndex = 7;
            kart8.UseVisualStyleBackColor = false;
            kart8.Click += kart_Click;
            lblXal.AutoSize = true;
            lblXal.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblXal.ForeColor = Color.White;
            lblXal.Location = new Point(110, 610);
            lblXal.Name = "lblXal";
            lblXal.Size = new Size(150, 60);
            lblXal.TabIndex = 8;
            lblXal.Text = "Xal: 0";
            lblNetice.AutoSize = true;
            lblNetice.Font = new Font("Segoe UI Emoji", 36F);
            lblNetice.ForeColor = Color.White;
            lblNetice.Location = new Point(420, 600);
            lblNetice.Name = "lblNetice";
            lblNetice.Size = new Size(0, 65);
            lblNetice.TabIndex = 9;
            btnYeniOyun.BackColor = Color.Black;
            btnYeniOyun.FlatAppearance.BorderColor = Color.White;
            btnYeniOyun.FlatAppearance.BorderSize = 2;
            btnYeniOyun.FlatStyle = FlatStyle.Flat;
            btnYeniOyun.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnYeniOyun.ForeColor = Color.White;
            btnYeniOyun.Location = new Point(715, 620);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(176, 54);
            btnYeniOyun.TabIndex = 10;
            btnYeniOyun.Text = "Yeni oyun";
            btnYeniOyun.UseVisualStyleBackColor = false;
            btnYeniOyun.Click += btnYeniOyun_Click;
            btnCixis.BackColor = Color.Black;
            btnCixis.FlatAppearance.BorderColor = Color.White;
            btnCixis.FlatAppearance.BorderSize = 2;
            btnCixis.FlatStyle = FlatStyle.Flat;
            btnCixis.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCixis.ForeColor = Color.White;
            btnCixis.Location = new Point(998, 620);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(176, 54);
            btnCixis.TabIndex = 11;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = false;
            btnCixis.Click += btnCixis_Click;
            timer1.Interval = 900;
            timer1.Tick += timer1_Tick;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 720);
            Controls.Add(kart1);
            Controls.Add(kart2);
            Controls.Add(kart3);
            Controls.Add(kart4);
            Controls.Add(kart5);
            Controls.Add(kart6);
            Controls.Add(kart7);
            Controls.Add(kart8);
            Controls.Add(lblXal);
            Controls.Add(lblNetice);
            Controls.Add(btnYeniOyun);
            Controls.Add(btnCixis);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kart1;
        private Button kart2;
        private Button kart3;
        private Button kart4;
        private Button kart5;
        private Button kart6;
        private Button kart7;
        private Button kart8;
        private Label lblXal;
        private Label lblNetice;
        private Button btnYeniOyun;
        private Button btnCixis;
        private System.Windows.Forms.Timer timer1;
    }
}