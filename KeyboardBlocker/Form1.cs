using Gma.System.MouseKeyHook;
using System.ComponentModel;

namespace KeyboardBlocker
{
    public partial class Form1 : Form
    {
        ComponentResourceManager resources = new(typeof(Form1));
        private IKeyboardMouseEvents _globalHook;
        private bool _isBlocking;

        public Form1()
        {
            InitializeComponent();
            _isBlocking = false;
        }

        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isBlocking)
            {
                // Если блокировка активна, отменяем действие по умолчанию
                e.Handled = true;

                // Обработка нажатия клавиш, например, выводим их в текстовое поле
                textBoxKeyboard.AppendText(e.KeyCode.ToString() + Environment.NewLine);
            }
        }

        private void buttonActions_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !_isBlocking;
            _isBlocking = !_isBlocking; // Переключаем состояние блокировки
            buttonActions.Text = _isBlocking ? "Unblock Keys" : "Block Keys";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация глобального перехватчика клавиатуры
            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += GlobalHook_KeyDown;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Освобождаем ресурсы при закрытии формы
            _globalHook.KeyDown -= GlobalHook_KeyDown;
            _globalHook.Dispose();
        }
    }
}
