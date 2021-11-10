
namespace _180104005_Assignment2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Button();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 303);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Let\'s Begin";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.HintForeColor = System.Drawing.Color.Empty;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.username.LineIdleColor = System.Drawing.Color.Silver;
            this.username.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(256, 54);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(207, 44);
            this.username.TabIndex = 37;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label19.Location = new System.Drawing.Point(156, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 21);
            this.label19.TabIndex = 38;
            this.label19.Text = "Username";
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.LOGIN.FlatAppearance.BorderSize = 0;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOGIN.Location = new System.Drawing.Point(257, 213);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(142, 40);
            this.LOGIN.TabIndex = 41;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.password.LineIdleColor = System.Drawing.Color.Silver;
            this.password.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(259, 125);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(206, 44);
            this.password.TabIndex = 42;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(156, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Password";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_180104005_Assignment2.Properties.Resources.pass;
            this.pictureBox4.Location = new System.Drawing.Point(256, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_180104005_Assignment2.Properties.Resources.male;
            this.pictureBox2.Location = new System.Drawing.Point(256, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_180104005_Assignment2.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(456, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_180104005_Assignment2.Properties.Resources.name;
            this.pictureBox1.Location = new System.Drawing.Point(31, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 303);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button LOGIN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}