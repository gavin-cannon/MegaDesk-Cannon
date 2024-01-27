namespace MegaDesk_Cannon
{
    partial class AddQuote
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
            this.FullName = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.DesktopMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.DesktopMaterial = new System.Windows.Forms.ComboBox();
            this.RushOrder = new System.Windows.Forms.ComboBox();
            this.WidthNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrawersNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddNewQuoteButton = new System.Windows.Forms.Button();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(12, 89);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(162, 26);
            this.FullName.TabIndex = 0;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(12, 63);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(80, 20);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name";
            this.FullNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(12, 124);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(110, 20);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Width (inches)";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(12, 186);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(113, 20);
            this.DepthLabel.TabIndex = 5;
            this.DepthLabel.Text = "Depth (inches)";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(12, 251);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(68, 20);
            this.DrawersLabel.TabIndex = 7;
            this.DrawersLabel.Text = "Drawers";
            // 
            // DesktopMaterialLabel
            // 
            this.DesktopMaterialLabel.AutoSize = true;
            this.DesktopMaterialLabel.Location = new System.Drawing.Point(12, 316);
            this.DesktopMaterialLabel.Name = "DesktopMaterialLabel";
            this.DesktopMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.DesktopMaterialLabel.TabIndex = 9;
            this.DesktopMaterialLabel.Text = "Desktop Material";
            this.DesktopMaterialLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Location = new System.Drawing.Point(12, 381);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(91, 20);
            this.RushOrderLabel.TabIndex = 11;
            this.RushOrderLabel.Text = "Rush Order";
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.FormattingEnabled = true;
            this.DesktopMaterial.Items.AddRange(new object[] {
            "Oak: $200",
            "Laminate: $100",
            "Pine: $50",
            "Rosewood: $300",
            "Veneer: $125"});
            this.DesktopMaterial.Location = new System.Drawing.Point(12, 339);
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.Size = new System.Drawing.Size(162, 28);
            this.DesktopMaterial.TabIndex = 12;
            // 
            // RushOrder
            // 
            this.RushOrder.FormattingEnabled = true;
            this.RushOrder.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushOrder.Location = new System.Drawing.Point(12, 404);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(162, 28);
            this.RushOrder.TabIndex = 13;
            // 
            // WidthNumberUpDown
            // 
            this.WidthNumberUpDown.Location = new System.Drawing.Point(12, 147);
            this.WidthNumberUpDown.Name = "WidthNumberUpDown";
            this.WidthNumberUpDown.Size = new System.Drawing.Size(162, 26);
            this.WidthNumberUpDown.TabIndex = 14;
            this.WidthNumberUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.WidthNumberUpDown_Validating);
            // 
            // DepthNumberUpDown
            // 
            this.DepthNumberUpDown.Location = new System.Drawing.Point(12, 209);
            this.DepthNumberUpDown.Name = "DepthNumberUpDown";
            this.DepthNumberUpDown.Size = new System.Drawing.Size(162, 26);
            this.DepthNumberUpDown.TabIndex = 15;
            this.DepthNumberUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthNumberUpDown_KeyPress);
            this.DepthNumberUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.DepthNumberUpDown_Validating);
            // 
            // DrawersNumberUpDown
            // 
            this.DrawersNumberUpDown.Location = new System.Drawing.Point(16, 274);
            this.DrawersNumberUpDown.Name = "DrawersNumberUpDown";
            this.DrawersNumberUpDown.Size = new System.Drawing.Size(162, 26);
            this.DrawersNumberUpDown.TabIndex = 16;
            // 
            // AddNewQuoteButton
            // 
            this.AddNewQuoteButton.Location = new System.Drawing.Point(12, 453);
            this.AddNewQuoteButton.Name = "AddNewQuoteButton";
            this.AddNewQuoteButton.Size = new System.Drawing.Size(157, 39);
            this.AddNewQuoteButton.TabIndex = 17;
            this.AddNewQuoteButton.Text = "Add New Quote";
            this.AddNewQuoteButton.UseVisualStyleBackColor = true;
            this.AddNewQuoteButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.CausesValidation = false;
            this.BackToMainMenu.Location = new System.Drawing.Point(10, 12);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(149, 31);
            this.BackToMainMenu.TabIndex = 18;
            this.BackToMainMenu.Text = "← Back To Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = true;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 523);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 26);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 561);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.AddNewQuoteButton);
            this.Controls.Add(this.DrawersNumberUpDown);
            this.Controls.Add(this.DepthNumberUpDown);
            this.Controls.Add(this.WidthNumberUpDown);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.DesktopMaterial);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.DesktopMaterialLabel);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.FullName);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label DesktopMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.ComboBox DesktopMaterial;
        private System.Windows.Forms.ComboBox RushOrder;
        private System.Windows.Forms.NumericUpDown WidthNumberUpDown;
        private System.Windows.Forms.NumericUpDown DepthNumberUpDown;
        private System.Windows.Forms.NumericUpDown DrawersNumberUpDown;
        private System.Windows.Forms.Button AddNewQuoteButton;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

