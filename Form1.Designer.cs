
namespace _180104005_Assignment2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currencyType = new Bunifu.Framework.UI.BunifuDropdown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.customerId = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.totalPriceBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuMaterialTextbox12 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox11 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product1UnitPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product1Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.product2Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.product2UnitPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.product3Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.product3UnitPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.product4Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.product4UnitPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.product5Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.product5UnitPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 616);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.currencyType);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.customerId);
            this.panel2.Controls.Add(this.customerName);
            this.panel2.Controls.Add(this.totalPriceBtn);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label60);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 616);
            this.panel2.TabIndex = 37;
            // 
            // currencyType
            // 
            this.currencyType.BackColor = System.Drawing.Color.Transparent;
            this.currencyType.BorderRadius = 3;
            this.currencyType.ForeColor = System.Drawing.Color.White;
            this.currencyType.Items = new string[] {
        "Rupee",
        "US Dollar",
        "Canadian Dollar",
        "Japanese Yen"};
            this.currencyType.Location = new System.Drawing.Point(186, 388);
            this.currencyType.Name = "currencyType";
            this.currencyType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.currencyType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.currencyType.selectedIndex = -1;
            this.currencyType.Size = new System.Drawing.Size(161, 38);
            this.currencyType.TabIndex = 42;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_180104005_Assignment2.Properties.Resources.box;
            this.pictureBox5.Location = new System.Drawing.Point(132, 114);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 101);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.customerId.ForeColor = System.Drawing.Color.Black;
            this.customerId.Location = new System.Drawing.Point(210, 325);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(95, 22);
            this.customerId.TabIndex = 41;
            this.customerId.Text = "Customer";
            this.customerId.Click += new System.EventHandler(this.label19_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.customerName.ForeColor = System.Drawing.Color.Black;
            this.customerName.Location = new System.Drawing.Point(210, 247);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(95, 22);
            this.customerName.TabIndex = 40;
            this.customerName.Text = "Customer";
            // 
            // totalPriceBtn
            // 
            this.totalPriceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.totalPriceBtn.FlatAppearance.BorderSize = 0;
            this.totalPriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPriceBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalPriceBtn.Location = new System.Drawing.Point(120, 493);
            this.totalPriceBtn.Name = "totalPriceBtn";
            this.totalPriceBtn.Size = new System.Drawing.Size(142, 40);
            this.totalPriceBtn.TabIndex = 39;
            this.totalPriceBtn.Text = "Total Price";
            this.totalPriceBtn.UseVisualStyleBackColor = false;
            this.totalPriceBtn.Click += new System.EventHandler(this.totalPriceBtn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(26, 395);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 22);
            this.label20.TabIndex = 38;
            this.label20.Text = "Curreny Type : ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(29, 324);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(133, 22);
            this.label29.TabIndex = 36;
            this.label29.Text = "Customer ID : ";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label60.ForeColor = System.Drawing.Color.Black;
            this.label60.Location = new System.Drawing.Point(29, 247);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(169, 22);
            this.label60.TabIndex = 34;
            this.label60.Text = "Customer Name : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_180104005_Assignment2.Properties.Resources.asset1;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(376, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuMaterialTextbox12
            // 
            this.bunifuMaterialTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox12.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox12.HintText = "";
            this.bunifuMaterialTextbox12.isPassword = false;
            this.bunifuMaterialTextbox12.LineFocusedColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox12.LineIdleColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox12.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(81)))), ((int)(((byte)(101)))));
            this.bunifuMaterialTextbox12.LineThickness = 3;
            this.bunifuMaterialTextbox12.Location = new System.Drawing.Point(171, 265);
            this.bunifuMaterialTextbox12.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox12.Name = "bunifuMaterialTextbox12";
            this.bunifuMaterialTextbox12.Size = new System.Drawing.Size(173, 44);
            this.bunifuMaterialTextbox12.TabIndex = 35;
            this.bunifuMaterialTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox12.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox12_OnValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.Location = new System.Drawing.Point(27, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 19);
            this.label17.TabIndex = 36;
            this.label17.Text = "Customer ID : ";
            this.label17.Click += new System.EventHandler(this.label17_Click_1);
            // 
            // bunifuMaterialTextbox11
            // 
            this.bunifuMaterialTextbox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox11.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox11.HintText = "";
            this.bunifuMaterialTextbox11.isPassword = false;
            this.bunifuMaterialTextbox11.LineFocusedColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox11.LineIdleColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox11.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(81)))), ((int)(((byte)(101)))));
            this.bunifuMaterialTextbox11.LineThickness = 3;
            this.bunifuMaterialTextbox11.Location = new System.Drawing.Point(171, 188);
            this.bunifuMaterialTextbox11.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox11.Name = "bunifuMaterialTextbox11";
            this.bunifuMaterialTextbox11.Size = new System.Drawing.Size(173, 44);
            this.bunifuMaterialTextbox11.TabIndex = 33;
            this.bunifuMaterialTextbox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.Location = new System.Drawing.Point(27, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 19);
            this.label16.TabIndex = 34;
            this.label16.Text = "Customer Name : ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_180104005_Assignment2.Properties.Resources.asset1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // product1UnitPrice
            // 
            this.product1UnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product1UnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product1UnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product1UnitPrice.HintForeColor = System.Drawing.Color.Empty;
            this.product1UnitPrice.HintText = "";
            this.product1UnitPrice.isPassword = false;
            this.product1UnitPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product1UnitPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.product1UnitPrice.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product1UnitPrice.LineThickness = 3;
            this.product1UnitPrice.Location = new System.Drawing.Point(524, 100);
            this.product1UnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.product1UnitPrice.Name = "product1UnitPrice";
            this.product1UnitPrice.Size = new System.Drawing.Size(49, 44);
            this.product1UnitPrice.TabIndex = 5;
            this.product1UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product1UnitPrice.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.product1UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(430, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unit Price : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(601, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // product1Amount
            // 
            this.product1Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product1Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product1Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product1Amount.HintForeColor = System.Drawing.Color.Empty;
            this.product1Amount.HintText = "";
            this.product1Amount.isPassword = false;
            this.product1Amount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product1Amount.LineIdleColor = System.Drawing.Color.Silver;
            this.product1Amount.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product1Amount.LineThickness = 3;
            this.product1Amount.Location = new System.Drawing.Point(686, 100);
            this.product1Amount.Margin = new System.Windows.Forms.Padding(4);
            this.product1Amount.Name = "product1Amount";
            this.product1Amount.Size = new System.Drawing.Size(49, 44);
            this.product1Amount.TabIndex = 10;
            this.product1Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product1Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(601, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Amount : ";
            // 
            // product2Amount
            // 
            this.product2Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product2Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product2Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product2Amount.HintForeColor = System.Drawing.Color.Empty;
            this.product2Amount.HintText = "";
            this.product2Amount.isPassword = false;
            this.product2Amount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product2Amount.LineIdleColor = System.Drawing.Color.Silver;
            this.product2Amount.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product2Amount.LineThickness = 3;
            this.product2Amount.Location = new System.Drawing.Point(686, 184);
            this.product2Amount.Margin = new System.Windows.Forms.Padding(4);
            this.product2Amount.Name = "product2Amount";
            this.product2Amount.Size = new System.Drawing.Size(49, 44);
            this.product2Amount.TabIndex = 15;
            this.product2Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product2Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(430, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unit Price : ";
            // 
            // product2UnitPrice
            // 
            this.product2UnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product2UnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product2UnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product2UnitPrice.HintForeColor = System.Drawing.Color.Empty;
            this.product2UnitPrice.HintText = "";
            this.product2UnitPrice.isPassword = false;
            this.product2UnitPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product2UnitPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.product2UnitPrice.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product2UnitPrice.LineThickness = 3;
            this.product2UnitPrice.Location = new System.Drawing.Point(524, 184);
            this.product2UnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.product2UnitPrice.Name = "product2UnitPrice";
            this.product2UnitPrice.Size = new System.Drawing.Size(49, 44);
            this.product2UnitPrice.TabIndex = 13;
            this.product2UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product2UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(601, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Amount : ";
            // 
            // product3Amount
            // 
            this.product3Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product3Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product3Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product3Amount.HintForeColor = System.Drawing.Color.Empty;
            this.product3Amount.HintText = "";
            this.product3Amount.isPassword = false;
            this.product3Amount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product3Amount.LineIdleColor = System.Drawing.Color.Silver;
            this.product3Amount.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product3Amount.LineThickness = 3;
            this.product3Amount.Location = new System.Drawing.Point(686, 272);
            this.product3Amount.Margin = new System.Windows.Forms.Padding(4);
            this.product3Amount.Name = "product3Amount";
            this.product3Amount.Size = new System.Drawing.Size(49, 44);
            this.product3Amount.TabIndex = 20;
            this.product3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product3Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(430, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Unit Price : ";
            // 
            // product3UnitPrice
            // 
            this.product3UnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product3UnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product3UnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product3UnitPrice.HintForeColor = System.Drawing.Color.Empty;
            this.product3UnitPrice.HintText = "";
            this.product3UnitPrice.isPassword = false;
            this.product3UnitPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product3UnitPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.product3UnitPrice.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product3UnitPrice.LineThickness = 3;
            this.product3UnitPrice.Location = new System.Drawing.Point(524, 272);
            this.product3UnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.product3UnitPrice.Name = "product3UnitPrice";
            this.product3UnitPrice.Size = new System.Drawing.Size(49, 44);
            this.product3UnitPrice.TabIndex = 18;
            this.product3UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product3UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Product 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(601, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Amount : ";
            // 
            // product4Amount
            // 
            this.product4Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product4Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product4Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product4Amount.HintForeColor = System.Drawing.Color.Empty;
            this.product4Amount.HintText = "";
            this.product4Amount.isPassword = false;
            this.product4Amount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product4Amount.LineIdleColor = System.Drawing.Color.Silver;
            this.product4Amount.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product4Amount.LineThickness = 3;
            this.product4Amount.Location = new System.Drawing.Point(686, 365);
            this.product4Amount.Margin = new System.Windows.Forms.Padding(4);
            this.product4Amount.Name = "product4Amount";
            this.product4Amount.Size = new System.Drawing.Size(49, 44);
            this.product4Amount.TabIndex = 25;
            this.product4Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product4Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(430, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Unit Price : ";
            // 
            // product4UnitPrice
            // 
            this.product4UnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product4UnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product4UnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product4UnitPrice.HintForeColor = System.Drawing.Color.Empty;
            this.product4UnitPrice.HintText = "";
            this.product4UnitPrice.isPassword = false;
            this.product4UnitPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product4UnitPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.product4UnitPrice.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product4UnitPrice.LineThickness = 3;
            this.product4UnitPrice.Location = new System.Drawing.Point(524, 365);
            this.product4UnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.product4UnitPrice.Name = "product4UnitPrice";
            this.product4UnitPrice.Size = new System.Drawing.Size(49, 44);
            this.product4UnitPrice.TabIndex = 23;
            this.product4UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product4UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(430, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Product 4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(601, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Amount : ";
            // 
            // product5Amount
            // 
            this.product5Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product5Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product5Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product5Amount.HintForeColor = System.Drawing.Color.Empty;
            this.product5Amount.HintText = "";
            this.product5Amount.isPassword = false;
            this.product5Amount.LineFocusedColor = System.Drawing.Color.DimGray;
            this.product5Amount.LineIdleColor = System.Drawing.Color.Silver;
            this.product5Amount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product5Amount.LineThickness = 3;
            this.product5Amount.Location = new System.Drawing.Point(686, 451);
            this.product5Amount.Margin = new System.Windows.Forms.Padding(4);
            this.product5Amount.Name = "product5Amount";
            this.product5Amount.Size = new System.Drawing.Size(49, 44);
            this.product5Amount.TabIndex = 30;
            this.product5Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product5Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(430, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Unit Price : ";
            // 
            // product5UnitPrice
            // 
            this.product5UnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product5UnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.product5UnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product5UnitPrice.HintForeColor = System.Drawing.Color.Empty;
            this.product5UnitPrice.HintText = "";
            this.product5UnitPrice.isPassword = false;
            this.product5UnitPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.product5UnitPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.product5UnitPrice.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.product5UnitPrice.LineThickness = 3;
            this.product5UnitPrice.Location = new System.Drawing.Point(524, 451);
            this.product5UnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.product5UnitPrice.Name = "product5UnitPrice";
            this.product5UnitPrice.Size = new System.Drawing.Size(49, 44);
            this.product5UnitPrice.TabIndex = 28;
            this.product5UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product5UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(433, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Product 5";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.totalPriceLabel.Location = new System.Drawing.Point(551, 539);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(188, 19);
            this.totalPriceLabel.TabIndex = 40;
            this.totalPriceLabel.Text = "Not Calculated";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_180104005_Assignment2.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(727, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_180104005_Assignment2.Properties.Resources.asset2;
            this.pictureBox2.Location = new System.Drawing.Point(373, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(439, 541);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 19);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Total Price : ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(552, 562);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(188, 4);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 616);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.product5Amount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.product5UnitPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.product4Amount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.product4UnitPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.product3Amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.product3UnitPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.product2Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.product2UnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product1Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product1UnitPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product1UnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product1Amount;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product2Amount;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product2UnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product3Amount;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product3UnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product4Amount;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product4UnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product5Amount;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product5UnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button totalPriceBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel totalPriceLabel;
        private System.Windows.Forms.Label customerId;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuDropdown currencyType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}

