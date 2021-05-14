
namespace Lab1TamikaTaylor
{
    partial class LunchOrderingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LunchOrderingApp));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.radBtnSalad = new System.Windows.Forms.RadioButton();
            this.radBtnPizza = new System.Windows.Forms.RadioButton();
            this.radBtnHamburger = new System.Windows.Forms.RadioButton();
            this.gbAddOns = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.gbAddOns.SuspendLayout();
            this.gbOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.Color.LightSalmon;
            this.gbMain.Controls.Add(this.radBtnSalad);
            this.gbMain.Controls.Add(this.radBtnPizza);
            this.gbMain.Controls.Add(this.radBtnHamburger);
            this.gbMain.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold);
            this.gbMain.Location = new System.Drawing.Point(30, 51);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(400, 200);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Main Course";
            // 
            // radBtnSalad
            // 
            this.radBtnSalad.AutoSize = true;
            this.radBtnSalad.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnSalad.ForeColor = System.Drawing.Color.DarkGreen;
            this.radBtnSalad.Location = new System.Drawing.Point(35, 138);
            this.radBtnSalad.Name = "radBtnSalad";
            this.radBtnSalad.Size = new System.Drawing.Size(98, 33);
            this.radBtnSalad.TabIndex = 3;
            this.radBtnSalad.TabStop = true;
            this.radBtnSalad.Text = "Salad";
            this.radBtnSalad.UseVisualStyleBackColor = true;
            this.radBtnSalad.CheckedChanged += new System.EventHandler(this.radBtnSalad_CheckedChanged);
            // 
            // radBtnPizza
            // 
            this.radBtnPizza.AutoSize = true;
            this.radBtnPizza.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnPizza.ForeColor = System.Drawing.Color.Gold;
            this.radBtnPizza.Location = new System.Drawing.Point(35, 95);
            this.radBtnPizza.Name = "radBtnPizza";
            this.radBtnPizza.Size = new System.Drawing.Size(94, 33);
            this.radBtnPizza.TabIndex = 2;
            this.radBtnPizza.TabStop = true;
            this.radBtnPizza.Text = "Pizza";
            this.radBtnPizza.UseVisualStyleBackColor = true;
            this.radBtnPizza.CheckedChanged += new System.EventHandler(this.radBtnPizza_CheckedChanged);
            // 
            // radBtnHamburger
            // 
            this.radBtnHamburger.AutoSize = true;
            this.radBtnHamburger.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnHamburger.ForeColor = System.Drawing.Color.Brown;
            this.radBtnHamburger.Location = new System.Drawing.Point(35, 48);
            this.radBtnHamburger.Name = "radBtnHamburger";
            this.radBtnHamburger.Size = new System.Drawing.Size(161, 33);
            this.radBtnHamburger.TabIndex = 1;
            this.radBtnHamburger.TabStop = true;
            this.radBtnHamburger.Text = "Hamburger";
            this.radBtnHamburger.UseVisualStyleBackColor = true;
            this.radBtnHamburger.CheckedChanged += new System.EventHandler(this.radBtnHamburger_CheckedChanged);
            // 
            // gbAddOns
            // 
            this.gbAddOns.BackColor = System.Drawing.Color.Beige;
            this.gbAddOns.Controls.Add(this.checkBox3);
            this.gbAddOns.Controls.Add(this.checkBox2);
            this.gbAddOns.Controls.Add(this.checkBox1);
            this.gbAddOns.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold);
            this.gbAddOns.Location = new System.Drawing.Point(505, 51);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.Size = new System.Drawing.Size(400, 200);
            this.gbAddOns.TabIndex = 3;
            this.gbAddOns.TabStop = false;
            this.gbAddOns.Text = "Add- on items ";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(15, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(179, 33);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "French Fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(15, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(358, 33);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Ketchup, Mustard and Mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(352, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Lettuce,Tomato and Onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.BackColor = System.Drawing.Color.Khaki;
            this.gbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.lblSubTotal);
            this.gbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gbOrderTotal.Controls.Add(this.txtTax);
            this.gbOrderTotal.Controls.Add(this.txtSubTotal);
            this.gbOrderTotal.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold);
            this.gbOrderTotal.Location = new System.Drawing.Point(30, 340);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(400, 200);
            this.gbOrderTotal.TabIndex = 9;
            this.gbOrderTotal.TabStop = false;
            this.gbOrderTotal.Text = "Order Total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Location = new System.Drawing.Point(29, 150);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(140, 29);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.Text = "Order Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(29, 97);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(106, 29);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax (5%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(29, 46);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(110, 29);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtOrderTotal.Location = new System.Drawing.Point(222, 150);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(150, 36);
            this.txtOrderTotal.TabIndex = 2;
            this.txtOrderTotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTax.Location = new System.Drawing.Point(222, 92);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(150, 36);
            this.txtTax.TabIndex = 1;
            this.txtTax.TabStop = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSubTotal.Location = new System.Drawing.Point(222, 39);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(150, 36);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.TabStop = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.Location = new System.Drawing.Point(505, 340);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(400, 50);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(505, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(400, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.8F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(505, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(400, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LunchOrderingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.gbAddOns);
            this.Controls.Add(this.gbMain);
            this.DoubleBuffered = true;
            this.Name = "LunchOrderingApp";
            this.Text = "Lunch Order App";
            this.Load += new System.EventHandler(this.LunchOrderingApp_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbAddOns.ResumeLayout(false);
            this.gbAddOns.PerformLayout();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbAddOns;
        private System.Windows.Forms.GroupBox gbOrderTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radBtnSalad;
        private System.Windows.Forms.RadioButton radBtnPizza;
        private System.Windows.Forms.RadioButton radBtnHamburger;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}

