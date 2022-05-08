
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMainDesktop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelMainTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnBack);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnStorage);
            this.panelMenu.Controls.Add(this.btnAddCar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 723);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 104);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMainTitle.Controls.Add(this.lblTitle);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.Location = new System.Drawing.Point(250, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMainTitle.Size = new System.Drawing.Size(910, 104);
            this.panelMainTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bauhaus 93", 16.2F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(374, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Parking Lot";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(8341, 4551);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(2916, 1454);
            this.panelDesktop.TabIndex = 4;
            // 
            // panelMainDesktop
            // 
            this.panelMainDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainDesktop.Location = new System.Drawing.Point(250, 104);
            this.panelMainDesktop.Name = "panelMainDesktop";
            this.panelMainDesktop.Size = new System.Drawing.Size(910, 619);
            this.panelMainDesktop.TabIndex = 5;
            this.panelMainDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainDesktop_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_64__1_;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 634);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 89);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_garage_50__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 274);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inventory";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStorage
            // 
            this.btnStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorage.FlatAppearance.BorderSize = 0;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.Font = new System.Drawing.Font("Bauhaus 93", 16.2F);
            this.btnStorage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStorage.Image = global::WindowsFormsApp1.Properties.Resources.icons8_motorcycle_50__1_;
            this.btnStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.Location = new System.Drawing.Point(0, 189);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStorage.Size = new System.Drawing.Size(250, 85);
            this.btnStorage.TabIndex = 2;
            this.btnStorage.Text = "Motorcycle";
            this.btnStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCar.Image = global::WindowsFormsApp1.Properties.Resources.icons8_car_50__1_;
            this.btnAddCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.Location = new System.Drawing.Point(0, 104);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddCar.Size = new System.Drawing.Size(250, 85);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Car";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 723);
            this.Controls.Add(this.panelMainDesktop);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMainTitle);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Panel panelMainTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMainDesktop;
        private System.Windows.Forms.Button btnBack;
    }
}

