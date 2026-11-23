namespace LAB10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxNotifications = new CheckBox();
            checkBoxSound = new CheckBox();
            checkBoxDarkTheme = new CheckBox();
            btnAccept = new Button();
            labelSetting = new Label();
            SuspendLayout();
            // 
            // checkBoxNotifications
            // 
            checkBoxNotifications.AutoSize = true;
            checkBoxNotifications.Location = new Point(28, 30);
            checkBoxNotifications.Name = "checkBoxNotifications";
            checkBoxNotifications.Size = new Size(126, 24);
            checkBoxNotifications.TabIndex = 0;
            checkBoxNotifications.Text = "Уведомления";
            checkBoxNotifications.UseVisualStyleBackColor = true;
            // 
            // checkBoxSound
            // 
            checkBoxSound.AutoSize = true;
            checkBoxSound.Location = new Point(28, 79);
            checkBoxSound.Name = "checkBoxSound";
            checkBoxSound.Size = new Size(160, 24);
            checkBoxSound.TabIndex = 1;
            checkBoxSound.Text = "Звуковые эффекты";
            checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // checkBoxDarkTheme
            // 
            checkBoxDarkTheme.AutoSize = true;
            checkBoxDarkTheme.Location = new Point(28, 134);
            checkBoxDarkTheme.Name = "checkBoxDarkTheme";
            checkBoxDarkTheme.Size = new Size(120, 24);
            checkBoxDarkTheme.TabIndex = 2;
            checkBoxDarkTheme.Text = "Тёмная тема";
            checkBoxDarkTheme.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(28, 194);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(120, 29);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Применить";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // labelSetting
            // 
            labelSetting.AutoSize = true;
            labelSetting.Location = new Point(28, 250);
            labelSetting.Name = "labelSetting";
            labelSetting.Size = new Size(0, 20);
            labelSetting.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSetting);
            Controls.Add(btnAccept);
            Controls.Add(checkBoxDarkTheme);
            Controls.Add(checkBoxSound);
            Controls.Add(checkBoxNotifications);
            Name = "Form1";
            Text = "Знакомство с Windows Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxNotifications;
        private CheckBox checkBoxSound;
        private CheckBox checkBoxDarkTheme;
        private Button btnAccept;
        private Label labelSetting;
    }
}
