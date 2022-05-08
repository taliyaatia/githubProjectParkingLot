
namespace WindowsFormsApp1
{
    partial class Car
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbColor = new System.Windows.Forms.TextBox();
            this.txtbKm = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbModel = new System.Windows.Forms.TextBox();
            this.txtbYear = new System.Windows.Forms.TextBox();
            this.txtbManufaturer = new System.Windows.Forms.TextBox();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtbColor);
            this.panel1.Controls.Add(this.txtbKm);
            this.panel1.Controls.Add(this.txtbPrice);
            this.panel1.Controls.Add(this.txtbModel);
            this.panel1.Controls.Add(this.txtbYear);
            this.panel1.Controls.Add(this.txtbManufaturer);
            this.panel1.Controls.Add(this.lblCarDetails);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 459);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(102, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add To Inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbColor
            // 
            this.txtbColor.Location = new System.Drawing.Point(213, 323);
            this.txtbColor.Name = "txtbColor";
            this.txtbColor.Size = new System.Drawing.Size(160, 22);
            this.txtbColor.TabIndex = 6;
            // 
            // txtbKm
            // 
            this.txtbKm.Location = new System.Drawing.Point(214, 259);
            this.txtbKm.Name = "txtbKm";
            this.txtbKm.Size = new System.Drawing.Size(160, 22);
            this.txtbKm.TabIndex = 5;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(214, 196);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(160, 22);
            this.txtbPrice.TabIndex = 4;
            // 
            // txtbModel
            // 
            this.txtbModel.Location = new System.Drawing.Point(214, 71);
            this.txtbModel.Name = "txtbModel";
            this.txtbModel.Size = new System.Drawing.Size(160, 22);
            this.txtbModel.TabIndex = 3;
            // 
            // txtbYear
            // 
            this.txtbYear.Location = new System.Drawing.Point(214, 133);
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.Size = new System.Drawing.Size(160, 22);
            this.txtbYear.TabIndex = 2;
            // 
            // txtbManufaturer
            // 
            this.txtbManufaturer.Location = new System.Drawing.Point(214, 8);
            this.txtbManufaturer.Name = "txtbManufaturer";
            this.txtbManufaturer.Size = new System.Drawing.Size(160, 22);
            this.txtbManufaturer.TabIndex = 1;
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCarDetails.Font = new System.Drawing.Font("Bauhaus 93", 16.2F);
            this.lblCarDetails.Location = new System.Drawing.Point(0, 0);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(195, 352);
            this.lblCarDetails.TabIndex = 0;
            this.lblCarDetails.Text = "Manufacturer:\r\n\r\nModel:\r\n\r\nYear:\r\n\r\nPrice:\r\n\r\nKilomerage:\r\n\r\nColor:\r\n";
            this.lblCarDetails.Click += new System.EventHandler(this.lblManuFacturer_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 613);
            this.Controls.Add(this.panel1);
            this.Name = "Car";
            this.Text = "Car";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.TextBox txtbColor;
        private System.Windows.Forms.TextBox txtbKm;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbModel;
        private System.Windows.Forms.TextBox txtbYear;
        private System.Windows.Forms.TextBox txtbManufaturer;
        private System.Windows.Forms.Button btnAdd;
    }
}