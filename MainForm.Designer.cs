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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PCNameL = new System.Windows.Forms.Label();
            this.PCNameTBox = new System.Windows.Forms.TextBox();
            this.PCNameButton = new System.Windows.Forms.Button();
            this.PCGBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PCipL = new System.Windows.Forms.Label();
            this.ADGBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FNameButton = new System.Windows.Forms.Button();
            this.ADNameButton = new System.Windows.Forms.Button();
            this.ADNameTBox = new System.Windows.Forms.TextBox();
            this.ADfnL = new System.Windows.Forms.Label();
            this.ADNameL = new System.Windows.Forms.Label();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.ADpassChBox = new System.Windows.Forms.CheckBox();
            this.DWipChBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TiaButton = new System.Windows.Forms.Button();
            this.DWButton = new System.Windows.Forms.Button();
            this.PshellButton = new System.Windows.Forms.Button();
            this.CmdButton = new System.Windows.Forms.Button();
            this.ADEnableButton = new System.Windows.Forms.Button();
            this.ADpassButton = new System.Windows.Forms.Button();
            this.ADUnlockButton = new System.Windows.Forms.Button();
            this.BOButton = new System.Windows.Forms.Button();
            this.AutoPButton = new System.Windows.Forms.Button();
            this.PCinfoTBox = new System.Windows.Forms.TextBox();
            this.ADInfoTBox = new System.Windows.Forms.TextBox();
            this.TabVeiksmai = new System.Windows.Forms.TabPage();
            this.TabExp = new System.Windows.Forms.TabPage();
            this.PCtoADButton = new System.Windows.Forms.Button();
            this.ADtoPCButton = new System.Windows.Forms.Button();
            this.TopCBox = new System.Windows.Forms.CheckBox();
            this.PCGBox.SuspendLayout();
            this.ADGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCNameL
            // 
            this.PCNameL.AutoSize = true;
            this.PCNameL.Location = new System.Drawing.Point(70, 49);
            this.PCNameL.Name = "PCNameL";
            this.PCNameL.Size = new System.Drawing.Size(19, 25);
            this.PCNameL.TabIndex = 0;
            this.PCNameL.Text = "-";
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
            this.PCGBox.Controls.Add(this.label2);
            this.PCGBox.Controls.Add(this.label1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "PC:";
            // 
            // PCipL
            // 
            this.PCipL.AutoSize = true;
            this.PCipL.Location = new System.Drawing.Point(70, 73);
            this.PCipL.Name = "PCipL";
            this.PCipL.Size = new System.Drawing.Size(19, 25);
            this.PCipL.TabIndex = 3;
            this.PCipL.Text = "-";
            // 
            // ADGBox
            // 
            this.ADGBox.Controls.Add(this.label4);
            this.ADGBox.Controls.Add(this.label3);
            this.ADGBox.Controls.Add(this.FNameButton);
            this.ADGBox.Controls.Add(this.ADNameButton);
            this.ADGBox.Controls.Add(this.ADNameTBox);
            this.ADGBox.Controls.Add(this.ADfnL);
            this.ADGBox.Controls.Add(this.ADNameL);
            this.ADGBox.Location = new System.Drawing.Point(508, 263);
            this.ADGBox.Name = "ADGBox";
            this.ADGBox.Size = new System.Drawing.Size(446, 274);
            this.ADGBox.TabIndex = 4;
            this.ADGBox.TabStop = false;
            this.ADGBox.Text = "Vartotojas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vardas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "AD:";
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
            this.ADNameTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ADNameBox_KeyDown);
            // 
            // ADfnL
            // 
            this.ADfnL.AutoSize = true;
            this.ADfnL.Location = new System.Drawing.Point(103, 74);
            this.ADfnL.Name = "ADfnL";
            this.ADfnL.Size = new System.Drawing.Size(19, 25);
            this.ADfnL.TabIndex = 1;
            this.ADfnL.Text = "-";
            // 
            // ADNameL
            // 
            this.ADNameL.AutoSize = true;
            this.ADNameL.Location = new System.Drawing.Point(103, 49);
            this.ADNameL.Name = "ADNameL";
            this.ADNameL.Size = new System.Drawing.Size(19, 25);
            this.ADNameL.TabIndex = 0;
            this.ADNameL.Text = "-";
            // 
            // LogoPBox
            // 
            this.LogoPBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPBox.BackgroundImage")));
            this.LogoPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPBox.InitialImage = null;
            this.LogoPBox.Location = new System.Drawing.Point(27, 12);
            this.LogoPBox.Name = "LogoPBox";
            this.LogoPBox.Size = new System.Drawing.Size(921, 244);
            this.LogoPBox.TabIndex = 5;
            this.LogoPBox.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabInfo);
            this.TabControl.Controls.Add(this.TabVeiksmai);
            this.TabControl.Controls.Add(this.TabExp);
            this.TabControl.Location = new System.Drawing.Point(12, 543);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(950, 475);
            this.TabControl.TabIndex = 6;
            // 
            // TabInfo
            // 
            this.TabInfo.Controls.Add(this.ADpassChBox);
            this.TabInfo.Controls.Add(this.DWipChBox);
            this.TabInfo.Controls.Add(this.button2);
            this.TabInfo.Controls.Add(this.button1);
            this.TabInfo.Controls.Add(this.TiaButton);
            this.TabInfo.Controls.Add(this.DWButton);
            this.TabInfo.Controls.Add(this.PshellButton);
            this.TabInfo.Controls.Add(this.CmdButton);
            this.TabInfo.Controls.Add(this.ADEnableButton);
            this.TabInfo.Controls.Add(this.ADpassButton);
            this.TabInfo.Controls.Add(this.ADUnlockButton);
            this.TabInfo.Controls.Add(this.BOButton);
            this.TabInfo.Controls.Add(this.AutoPButton);
            this.TabInfo.Controls.Add(this.PCinfoTBox);
            this.TabInfo.Controls.Add(this.ADInfoTBox);
            this.TabInfo.Location = new System.Drawing.Point(8, 39);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfo.Size = new System.Drawing.Size(934, 428);
            this.TabInfo.TabIndex = 0;
            this.TabInfo.Text = "Informacija";
            this.TabInfo.UseVisualStyleBackColor = true;
            // 
            // ADpassChBox
            // 
            this.ADpassChBox.AutoSize = true;
            this.ADpassChBox.Location = new System.Drawing.Point(572, 343);
            this.ADpassChBox.Name = "ADpassChBox";
            this.ADpassChBox.Size = new System.Drawing.Size(356, 29);
            this.ADpassChBox.TabIndex = 14;
            this.ADpassChBox.Text = "Must change pass on next logon";
            this.ADpassChBox.UseVisualStyleBackColor = true;
            // 
            // DWipChBox
            // 
            this.DWipChBox.AutoSize = true;
            this.DWipChBox.Location = new System.Drawing.Point(299, 343);
            this.DWipChBox.Name = "DWipChBox";
            this.DWipChBox.Size = new System.Drawing.Size(167, 29);
            this.DWipChBox.TabIndex = 13;
            this.DWipChBox.Text = "Jungtis su IP";
            this.DWipChBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Detali";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Detali";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TiaButton
            // 
            this.TiaButton.Location = new System.Drawing.Point(106, 343);
            this.TiaButton.Name = "TiaButton";
            this.TiaButton.Size = new System.Drawing.Size(73, 78);
            this.TiaButton.TabIndex = 10;
            this.TiaButton.Text = "TIA";
            this.TiaButton.UseVisualStyleBackColor = true;
            this.TiaButton.Click += new System.EventHandler(this.TiaButton_Click);
            // 
            // DWButton
            // 
            this.DWButton.Location = new System.Drawing.Point(299, 282);
            this.DWButton.Name = "DWButton";
            this.DWButton.Size = new System.Drawing.Size(153, 55);
            this.DWButton.TabIndex = 9;
            this.DWButton.Text = "Jungtis DW";
            this.DWButton.UseVisualStyleBackColor = true;
            this.DWButton.Click += new System.EventHandler(this.DWButton_Click);
            // 
            // PshellButton
            // 
            this.PshellButton.Location = new System.Drawing.Point(299, 218);
            this.PshellButton.Name = "PshellButton";
            this.PshellButton.Size = new System.Drawing.Size(153, 57);
            this.PshellButton.TabIndex = 8;
            this.PshellButton.Text = "PowerShell";
            this.PshellButton.UseVisualStyleBackColor = true;
            this.PshellButton.Click += new System.EventHandler(this.PshellButton_Click);
            // 
            // CmdButton
            // 
            this.CmdButton.Location = new System.Drawing.Point(299, 151);
            this.CmdButton.Name = "CmdButton";
            this.CmdButton.Size = new System.Drawing.Size(153, 60);
            this.CmdButton.TabIndex = 7;
            this.CmdButton.Text = "CMD";
            this.CmdButton.UseVisualStyleBackColor = true;
            this.CmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // ADEnableButton
            // 
            this.ADEnableButton.Location = new System.Drawing.Point(743, 149);
            this.ADEnableButton.Name = "ADEnableButton";
            this.ADEnableButton.Size = new System.Drawing.Size(170, 62);
            this.ADEnableButton.TabIndex = 6;
            this.ADEnableButton.Text = "Įgalinti\r\npaskyrą";
            this.ADEnableButton.UseVisualStyleBackColor = true;
            this.ADEnableButton.Click += new System.EventHandler(this.ADEnableButton_Click);
            // 
            // ADpassButton
            // 
            this.ADpassButton.Location = new System.Drawing.Point(743, 84);
            this.ADpassButton.Name = "ADpassButton";
            this.ADpassButton.Size = new System.Drawing.Size(170, 59);
            this.ADpassButton.TabIndex = 5;
            this.ADpassButton.Text = "Pakeisti\r\nslaptažodį";
            this.ADpassButton.UseVisualStyleBackColor = true;
            this.ADpassButton.Click += new System.EventHandler(this.ADpassButton_Click);
            // 
            // ADUnlockButton
            // 
            this.ADUnlockButton.Location = new System.Drawing.Point(743, 24);
            this.ADUnlockButton.Name = "ADUnlockButton";
            this.ADUnlockButton.Size = new System.Drawing.Size(170, 54);
            this.ADUnlockButton.TabIndex = 4;
            this.ADUnlockButton.Text = "Atrakinti";
            this.ADUnlockButton.UseVisualStyleBackColor = true;
            this.ADUnlockButton.Click += new System.EventHandler(this.ADUnlockButton_Click);
            // 
            // BOButton
            // 
            this.BOButton.Location = new System.Drawing.Point(299, 85);
            this.BOButton.Name = "BOButton";
            this.BOButton.Size = new System.Drawing.Size(153, 59);
            this.BOButton.TabIndex = 3;
            this.BOButton.Text = "Back Office";
            this.BOButton.UseVisualStyleBackColor = true;
            this.BOButton.Click += new System.EventHandler(this.BOButton_Click);
            // 
            // AutoPButton
            // 
            this.AutoPButton.Location = new System.Drawing.Point(299, 24);
            this.AutoPButton.Name = "AutoPButton";
            this.AutoPButton.Size = new System.Drawing.Size(153, 54);
            this.AutoPButton.TabIndex = 2;
            this.AutoPButton.Text = "Auto Pagalba";
            this.AutoPButton.UseVisualStyleBackColor = true;
            this.AutoPButton.Click += new System.EventHandler(this.AutoPButton_Click);
            // 
            // PCinfoTBox
            // 
            this.PCinfoTBox.Location = new System.Drawing.Point(7, 24);
            this.PCinfoTBox.Multiline = true;
            this.PCinfoTBox.Name = "PCinfoTBox";
            this.PCinfoTBox.Size = new System.Drawing.Size(285, 313);
            this.PCinfoTBox.TabIndex = 1;
            // 
            // ADInfoTBox
            // 
            this.ADInfoTBox.AcceptsReturn = true;
            this.ADInfoTBox.AcceptsTab = true;
            this.ADInfoTBox.Location = new System.Drawing.Point(473, 24);
            this.ADInfoTBox.Multiline = true;
            this.ADInfoTBox.Name = "ADInfoTBox";
            this.ADInfoTBox.ReadOnly = true;
            this.ADInfoTBox.Size = new System.Drawing.Size(257, 313);
            this.ADInfoTBox.TabIndex = 0;
            // 
            // TabVeiksmai
            // 
            this.TabVeiksmai.Location = new System.Drawing.Point(8, 39);
            this.TabVeiksmai.Name = "TabVeiksmai";
            this.TabVeiksmai.Padding = new System.Windows.Forms.Padding(3);
            this.TabVeiksmai.Size = new System.Drawing.Size(934, 428);
            this.TabVeiksmai.TabIndex = 1;
            this.TabVeiksmai.Text = "Veiksmai";
            this.TabVeiksmai.UseVisualStyleBackColor = true;
            // 
            // TabExp
            // 
            this.TabExp.Location = new System.Drawing.Point(8, 39);
            this.TabExp.Name = "TabExp";
            this.TabExp.Padding = new System.Windows.Forms.Padding(3);
            this.TabExp.Size = new System.Drawing.Size(934, 428);
            this.TabExp.TabIndex = 2;
            this.TabExp.Text = "Eksperimentalu";
            this.TabExp.UseVisualStyleBackColor = true;
            // 
            // PCtoADButton
            // 
            this.PCtoADButton.Location = new System.Drawing.Point(384, 312);
            this.PCtoADButton.Name = "PCtoADButton";
            this.PCtoADButton.Size = new System.Drawing.Size(55, 49);
            this.PCtoADButton.TabIndex = 7;
            this.PCtoADButton.Text = ">>";
            this.PCtoADButton.UseVisualStyleBackColor = true;
            this.PCtoADButton.Click += new System.EventHandler(this.PCtoADButton_Click);
            // 
            // ADtoPCButton
            // 
            this.ADtoPCButton.Location = new System.Drawing.Point(384, 368);
            this.ADtoPCButton.Name = "ADtoPCButton";
            this.ADtoPCButton.Size = new System.Drawing.Size(55, 50);
            this.ADtoPCButton.TabIndex = 8;
            this.ADtoPCButton.Text = "<<";
            this.ADtoPCButton.UseVisualStyleBackColor = true;
            this.ADtoPCButton.Click += new System.EventHandler(this.ADtoPCButton_Click);
            // 
            // TopCBox
            // 
            this.TopCBox.AutoSize = true;
            this.TopCBox.Location = new System.Drawing.Point(330, 263);
            this.TopCBox.Name = "TopCBox";
            this.TopCBox.Size = new System.Drawing.Size(109, 29);
            this.TopCBox.TabIndex = 9;
            this.TopCBox.Text = "OnTop";
            this.TopCBox.UseVisualStyleBackColor = true;
            this.TopCBox.CheckedChanged += new System.EventHandler(this.TopCBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(971, 1030);
            this.Controls.Add(this.TopCBox);
            this.Controls.Add(this.ADtoPCButton);
            this.Controls.Add(this.PCtoADButton);
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
            this.TabInfo.ResumeLayout(false);
            this.TabInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox ADInfoTBox;
        private System.Windows.Forms.Button ADUnlockButton;
        private System.Windows.Forms.Button BOButton;
        private System.Windows.Forms.Button AutoPButton;
        private System.Windows.Forms.TextBox PCinfoTBox;
        private System.Windows.Forms.Button ADEnableButton;
        private System.Windows.Forms.Button ADpassButton;
        private System.Windows.Forms.TabPage TabExp;
        private System.Windows.Forms.Button TiaButton;
        private System.Windows.Forms.Button DWButton;
        private System.Windows.Forms.Button PshellButton;
        private System.Windows.Forms.Button CmdButton;
        private System.Windows.Forms.CheckBox ADpassChBox;
        private System.Windows.Forms.CheckBox DWipChBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PCtoADButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ADtoPCButton;
        private System.Windows.Forms.CheckBox TopCBox;
    }
}

