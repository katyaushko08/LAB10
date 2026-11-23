namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string result = "";

            if (checkBoxNotifications.Checked)
                result += "уведомления; ";

            if (checkBoxSound.Checked)
                result += "звуковые эффекты; ";

            if (checkBoxDarkTheme.Checked)
                result += "тёмная тема; ";

            if (result == "")
            {
                labelSetting.Text = "Ничего не выбрано";
            }
            else
            {
                labelSetting.Text = "Включено: " + result;
            }
    }
    }
}
