namespace LDUsers
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
            this.PCNameL = new System.Windows.Forms.Label();
            this.PCNameTBox = new System.Windows.Forms.TextBox();
            this.PCNameButton = new System.Windows.Forms.Button();
            this.PCGBox = new System.Windows.Forms.GroupBox();
            this.PCipL = new System.Windows.Forms.Label();
            this.ADGBox = new System.Windows.Forms.GroupBox();
            this.ADNameL = new System.Windows.Forms.Label();
            this.ADfnL = new System.Windows.Forms.Label();
            this.ADNameTBox = new System.Windows.Forms.TextBox();
            this.ADNameButton = new System.Windows.Forms.Button();
            this.FNameButton = new System.Windows.Forms.Button();
            this.PCGBox.SuspendLayout();
            this.ADGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCNameL
            // 
            this.PCNameL.AutoSize = true;
            this.PCNameL.Location = new System.Drawing.Point(6, 48);
            this.PCNameL.Name = "PCNameL";
            this.PCNameL.Size = new System.Drawing.Size(60, 25);
            this.PCNameL.TabIndex = 0;
            this.PCNameL.Text = "PC: -";
            // 
            // PCNameTBox
            // 
            this.PCNameTBox.Location = new System.Drawing.Point(6, 124);
            this.PCNameTBox.Name = "PCNameTBox";
            this.PCNameTBox.Size = new System.Drawing.Size(230, 31);
            this.PCNameTBox.TabIndex = 1;
            this.PCNameTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PCNameTBox_KeyDown);
            // 
            // PCNameButton
            // 
            this.PCNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCNameButton.Location = new System.Drawing.Point(6, 161);
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
            this.PCGBox.Location = new System.Drawing.Point(12, 12);
            this.PCGBox.Name = "PCGBox";
            this.PCGBox.Size = new System.Drawing.Size(346, 274);
            this.PCGBox.TabIndex = 3;
            this.PCGBox.TabStop = false;
            this.PCGBox.Text = "Kompiuteris";
            // 
            // PCipL
            // 
            this.PCipL.AutoSize = true;
            this.PCipL.Location = new System.Drawing.Point(6, 73);
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
            this.ADGBox.Location = new System.Drawing.Point(364, 12);
            this.ADGBox.Name = "ADGBox";
            this.ADGBox.Size = new System.Drawing.Size(413, 274);
            this.ADGBox.TabIndex = 4;
            this.ADGBox.TabStop = false;
            this.ADGBox.Text = "Vartotojas";
            // 
            // ADNameL
            // 
            this.ADNameL.AutoSize = true;
            this.ADNameL.Location = new System.Drawing.Point(6, 48);
            this.ADNameL.Name = "ADNameL";
            this.ADNameL.Size = new System.Drawing.Size(60, 25);
            this.ADNameL.TabIndex = 0;
            this.ADNameL.Text = "AD: -";
            // 
            // ADfnL
            // 
            this.ADfnL.AutoSize = true;
            this.ADfnL.Location = new System.Drawing.Point(6, 73);
            this.ADfnL.Name = "ADfnL";
            this.ADfnL.Size = new System.Drawing.Size(99, 25);
            this.ADfnL.TabIndex = 1;
            this.ADfnL.Text = "Vardas: -";
            // 
            // ADNameTBox
            // 
            this.ADNameTBox.Location = new System.Drawing.Point(0, 124);
            this.ADNameTBox.Name = "ADNameTBox";
            this.ADNameTBox.Size = new System.Drawing.Size(250, 31);
            this.ADNameTBox.TabIndex = 2;
            // 
            // ADNameButton
            // 
            this.ADNameButton.Location = new System.Drawing.Point(0, 161);
            this.ADNameButton.Name = "ADNameButton";
            this.ADNameButton.Size = new System.Drawing.Size(144, 44);
            this.ADNameButton.TabIndex = 3;
            this.ADNameButton.Text = "Įvesti";
            this.ADNameButton.UseVisualStyleBackColor = true;
            this.ADNameButton.Click += new System.EventHandler(this.ADNameButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 393);
            this.Controls.Add(this.ADGBox);
            this.Controls.Add(this.PCGBox);
            this.Name = "MainForm";
            this.Text = "LD Jūzeriai";
            this.PCGBox.ResumeLayout(false);
            this.PCGBox.PerformLayout();
            this.ADGBox.ResumeLayout(false);
            this.ADGBox.PerformLayout();
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
    }
}

