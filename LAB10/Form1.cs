namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxEvent.Items.Add("Конференция");
            comboBoxEvent.Items.Add("Семинар");
            comboBoxEvent.Items.Add("Форум");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))    //проверка имени
            {
                MessageBox.Show(
                    "Введите имя участника.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxAge.Text, out int age) || age < 0 || age > 120)   //проверка возраста
            {
                MessageBox.Show(
                    "Введите корректный возраст (целое число от 0 до 120). ",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxEvent.SelectedItem == null)       //проверка мероприятия
            {
                MessageBox.Show(
                    "Выберите мероприятие.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string format;
            if (radioButtonOffline.Checked)
            {
                format = "Очно";
            }
            else if (radioButtonOnline.Checked)
            {
                format = "Онлайн";
            }
            else
            {
                MessageBox.Show(
                   "Укажите формат участия.",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            string notify;
            if (checkBoxNotify.Checked)
            {
                notify = "Да";
            }
            else
            {
                notify = "Нет";
            }

            labelResult.Text = $"Имя: {textBoxName.Text}\n" +
                       $"Возраст: {age}\n" +
                       $"Мероприятие: {comboBoxEvent.SelectedItem}\n" +
                       $"Формат: {format}\n" +
                       $"Уведомления: {notify}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            comboBoxEvent.SelectedIndex = -1;          // Сбрасываем выбор в списке
            radioButtonOffline.Checked = false;
            radioButtonOnline.Checked = false;
            checkBoxNotify.Checked = false;
            labelResult.Text = "";
        }
    }
}
