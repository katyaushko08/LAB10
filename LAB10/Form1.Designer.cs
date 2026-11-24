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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            comboBoxEvent = new ComboBox();
            label3 = new Label();
            radioButtonOffline = new RadioButton();
            radioButtonOnline = new RadioButton();
            label4 = new Label();
            checkBoxNotify = new CheckBox();
            buttonSubmit = new Button();
            buttonClear = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 83);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Возраст: ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(128, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 2;
            textBoxName.Text = "Ма";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(128, 80);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 3;
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Location = new Point(151, 131);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(151, 28);
            comboBoxEvent.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 134);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 5;
            label3.Text = "Мероприятие: ";
            // 
            // radioButtonOffline
            // 
            radioButtonOffline.AutoSize = true;
            radioButtonOffline.Location = new Point(32, 237);
            radioButtonOffline.Name = "radioButtonOffline";
            radioButtonOffline.Size = new Size(67, 24);
            radioButtonOffline.TabIndex = 6;
            radioButtonOffline.TabStop = true;
            radioButtonOffline.Text = "Очно";
            radioButtonOffline.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnline
            // 
            radioButtonOnline.AutoSize = true;
            radioButtonOnline.Location = new Point(32, 267);
            radioButtonOnline.Name = "radioButtonOnline";
            radioButtonOnline.Size = new Size(84, 24);
            radioButtonOnline.TabIndex = 7;
            radioButtonOnline.TabStop = true;
            radioButtonOnline.Text = "Онлайн";
            radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 204);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 8;
            label4.Text = "Формат участия:";
            // 
            // checkBoxNotify
            // 
            checkBoxNotify.AutoSize = true;
            checkBoxNotify.Location = new Point(32, 317);
            checkBoxNotify.Name = "checkBoxNotify";
            checkBoxNotify.Size = new Size(259, 24);
            checkBoxNotify.TabIndex = 9;
            checkBoxNotify.Text = "Согласен получать уведомления";
            checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(32, 364);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(196, 29);
            buttonSubmit.TabIndex = 10;
            buttonSubmit.Text = "Отправить анкету";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(279, 364);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(503, 37);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubmit);
            Controls.Add(checkBoxNotify);
            Controls.Add(label4);
            Controls.Add(radioButtonOnline);
            Controls.Add(radioButtonOffline);
            Controls.Add(label3);
            Controls.Add(comboBoxEvent);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Знакомство с Windows Forms";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private ComboBox comboBoxEvent;
        private Label label3;
        private RadioButton radioButtonOffline;
        private RadioButton radioButtonOnline;
        private Label label4;
        private CheckBox checkBoxNotify;
        private Button buttonSubmit;
        private Button buttonClear;
        private Label labelResult;
    }
}
