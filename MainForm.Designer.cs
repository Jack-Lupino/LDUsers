﻿namespace LDUsers
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PCNameL = new System.Windows.Forms.Label();
            this.PCNameTBox = new System.Windows.Forms.TextBox();
            this.PCNameButton = new System.Windows.Forms.Button();
            this.PCGBox = new System.Windows.Forms.GroupBox();
            this.PCipL = new System.Windows.Forms.Label();
            this.ADGBox = new System.Windows.Forms.GroupBox();
            this.FNameButton = new System.Windows.Forms.Button();
            this.ADNameButton = new System.Windows.Forms.Button();
            this.ADNameTBox = new System.Windows.Forms.TextBox();
            this.ADfnL = new System.Windows.Forms.Label();
            this.ADNameL = new System.Windows.Forms.Label();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.TabVeiksmai = new System.Windows.Forms.TabPage();
            this.PCGBox.SuspendLayout();
            this.ADGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCNameL
            // 
            this.PCNameL.AutoSize = true;
            this.PCNameL.Location = new System.Drawing.Point(23, 48);
            this.PCNameL.Name = "PCNameL";
            this.PCNameL.Size = new System.Drawing.Size(60, 25);
            this.PCNameL.TabIndex = 0;
            this.PCNameL.Text = "PC: -";
            // 
            // PCNameTBox
            // 
            this.PCNameTBox.Location = new System.Drawing.Point(28, 124);
            this.PCNameTBox.Name = "PCNameTBox";
            this.PCNameTBox.Size = new System.Drawing.Size(230, 31);
            this.PCNameTBox.TabIndex = 1;
            this.PCNameTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PCNameTBox_KeyDown);
            // 
            // PCNameButton
            // 
            this.PCNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCNameButton.Location = new System.Drawing.Point(28, 161);
            this.PCNameButton.Name = "PCNameButton";
            this.PCNameButton.Size = new System.Drawing.Size(131, 44);
            this.PCNameButton.TabIndex = 2;
            this.PCNameButton.Text = "Įvesti";
            this.PCNameButton.UseVisualStyleBackColor = true;
            this.PCNameButton.Click += new System.EventHandler(this.PCNameButton_Click);
            // 
            // PCGBox
            // 
            this.PCGBox.Controls.Add(this.PCipL);
            this.PCGBox.Controls.Add(this.PCNameL);
            this.PCGBox.Controls.Add(this.PCNameButton);
            this.PCGBox.Controls.Add(this.PCNameTBox);
            this.PCGBox.Location = new System.Drawing.Point(12, 263);
            this.PCGBox.Name = "PCGBox";
            this.PCGBox.Size = new System.Drawing.Size(300, 274);
            this.PCGBox.TabIndex = 3;
            this.PCGBox.TabStop = false;
            this.PCGBox.Text = "Kompiuteris";
            // 
            // PCipL
            // 
            this.PCipL.AutoSize = true;
            this.PCipL.Location = new System.Drawing.Point(23, 73);
            this.PCipL.Name = "PCipL";
            this.PCipL.Size = new System.Drawing.Size(50, 25);
            this.PCipL.TabIndex = 3;
            this.PCipL.Text = "IP: -";
            // 
            // ADGBox
            // 
            this.ADGBox.Controls.Add(this.FNameButton);
            this.ADGBox.Controls.Add(this.ADNameButton);
            this.ADGBox.Controls.Add(this.ADNameTBox);
            this.ADGBox.Controls.Add(this.ADfnL);
            this.ADGBox.Controls.Add(this.ADNameL);
            this.ADGBox.Location = new System.Drawing.Point(318, 263);
            this.ADGBox.Name = "ADGBox";
            this.ADGBox.Size = new System.Drawing.Size(446, 274);
            this.ADGBox.TabIndex = 4;
            this.ADGBox.TabStop = false;
            this.ADGBox.Text = "Vartotojas";
            // 
            // FNameButton
            // 
            this.FNameButton.Location = new System.Drawing.Point(246, 161);
            this.FNameButton.Name = "FNameButton";
            this.FNameButton.Size = new System.Drawing.Size(167, 44);
            this.FNameButton.TabIndex = 4;
            this.FNameButton.Text = "Pagal vardą";
            this.FNameButton.UseVisualStyleBackColor = true;
            this.FNameButton.Click += new System.EventHandler(this.FNameButton_Click);
            // 
            // ADNameButton
            // 
            this.ADNameButton.Location = new System.Drawing.Point(26, 161);
            this.ADNameButton.Name = "ADNameButton";
            this.ADNameButton.Size = new System.Drawing.Size(144, 44);
            this.ADNameButton.TabIndex = 3;
            this.ADNameButton.Text = "Įvesti";
            this.ADNameButton.UseVisualStyleBackColor = true;
            this.ADNameButton.Click += new System.EventHandler(this.ADNameButton_Click);
            // 
            // ADNameTBox
            // 
            this.ADNameTBox.Location = new System.Drawing.Point(26, 124);
            this.ADNameTBox.Name = "ADNameTBox";
            this.ADNameTBox.Size = new System.Drawing.Size(250, 31);
            this.ADNameTBox.TabIndex = 2;
            // 
            // ADfnL
            // 
            this.ADfnL.AutoSize = true;
            this.ADfnL.Location = new System.Drawing.Point(21, 73);
            this.ADfnL.Name = "ADfnL";
            this.ADfnL.Size = new System.Drawing.Size(99, 25);
            this.ADfnL.TabIndex = 1;
            this.ADfnL.Text = "Vardas: -";
            // 
            // ADNameL
            // 
            this.ADNameL.AutoSize = true;
            this.ADNameL.Location = new System.Drawing.Point(21, 48);
            this.ADNameL.Name = "ADNameL";
            this.ADNameL.Size = new System.Drawing.Size(60, 25);
            this.ADNameL.TabIndex = 0;
            this.ADNameL.Text = "AD: -";
            // 
            // LogoPBox
            // 
            this.LogoPBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPBox.BackgroundImage")));
            this.LogoPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPBox.InitialImage = null;
            this.LogoPBox.Location = new System.Drawing.Point(12, 13);
            this.LogoPBox.Name = "LogoPBox";
            this.LogoPBox.Size = new System.Drawing.Size(752, 244);
            this.LogoPBox.TabIndex = 5;
            this.LogoPBox.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabInfo);
            this.TabControl.Controls.Add(this.TabVeiksmai);
            this.TabControl.Location = new System.Drawing.Point(12, 543);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(752, 402);
            this.TabControl.TabIndex = 6;
            // 
            // TabInfo
            // 
            this.TabInfo.Location = new System.Drawing.Point(8, 39);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfo.Size = new System.Drawing.Size(736, 355);
            this.TabInfo.TabIndex = 0;
            this.TabInfo.Text = "Informacija";
            this.TabInfo.UseVisualStyleBackColor = true;
            // 
            // TabVeiksmai
            // 
            this.TabVeiksmai.Location = new System.Drawing.Point(8, 39);
            this.TabVeiksmai.Name = "TabVeiksmai";
            this.TabVeiksmai.Padding = new System.Windows.Forms.Padding(3);
            this.TabVeiksmai.Size = new System.Drawing.Size(736, 355);
            this.TabVeiksmai.TabIndex = 1;
            this.TabVeiksmai.Text = "Veiksmai";
            this.TabVeiksmai.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 956);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LogoPBox);
            this.Controls.Add(this.ADGBox);
            this.Controls.Add(this.PCGBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LD Jūzeriai";
            this.PCGBox.ResumeLayout(false);
            this.PCGBox.PerformLayout();
            this.ADGBox.ResumeLayout(false);
            this.ADGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PCNameL;
        private System.Windows.Forms.TextBox PCNameTBox;
        private System.Windows.Forms.Button PCNameButton;
        private System.Windows.Forms.GroupBox PCGBox;
        private System.Windows.Forms.Label PCipL;
        private System.Windows.Forms.GroupBox ADGBox;
        private System.Windows.Forms.Label ADfnL;
        private System.Windows.Forms.Label ADNameL;
        private System.Windows.Forms.Button ADNameButton;
        private System.Windows.Forms.TextBox ADNameTBox;
        private System.Windows.Forms.Button FNameButton;
        private System.Windows.Forms.PictureBox LogoPBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabInfo;
        private System.Windows.Forms.TabPage TabVeiksmai;
    }
}

