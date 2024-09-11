namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private string _currentOperation=string.Empty;
        private string _currentEntry=string.Empty;
        private string _operator = string.Empty;
        private double _value = 0;
        private int _operatorClickCount=0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void GetResultMethod()
        {
            double result = 0;
            if (double.TryParse(_currentEntry, out double second_value))
            {
                switch (_operator)
                {
                    case "+":
                        result = _value + second_value;
                        break;
                    case "-":
                        result = _value - second_value;
                        break;
                    case "/":
                        result = _value / second_value;
                        break;
                    case "*":
                        result = _value * second_value;
                        break;

                }
                Display.Text = result.ToString();
                _currentEntry = result.ToString();

            }
        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            _currentEntry=_currentEntry.Remove(_currentEntry.Length - 1);
            Display.Text=_currentEntry;
        }

        private void CE_ButtonClicked(object sender, EventArgs e)
        {
            string history = History.Text;
            
            _currentEntry = string.Empty;
            Display.Text = string.Empty;
        }

        private void C_ButtonClicked(object sender, EventArgs e)
        {
            _currentEntry= string.Empty;
            _operator= string.Empty;
            Display.Text=string.Empty;
            _currentOperation = string.Empty;
            History.Text = string.Empty;
        }

        private void PlusMinusButtonClicked(object sender, EventArgs e)
        {
            if (_currentEntry != "")
            {
                if (double.TryParse(_currentEntry, out double result))
                {
                    result = result * (-1);
                    _currentEntry = result.ToString();
                    Display.Text = result.ToString();
                }

            }

        }

        private void SquareButtonClicked(object sender, EventArgs e)
        {
            if (_currentEntry != "")
            {
                if (double.TryParse(_currentEntry, out double result))
                {
                    result = Math.Sqrt(result);
                    _currentEntry = result.ToString();
                    Display.Text = result.ToString();
                }

            }
        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {
           var button= sender as Button;
            _currentEntry += button.Text;
            Display.Text = _currentEntry;
            _currentOperation += button.Text;
            History.Text = _currentOperation;
           
        }

        private void EqualsButtonClicked(object sender, EventArgs e)
        {
           GetResultMethod();
            _currentOperation = string.Empty;
            History.Text = string.Empty;
            _operatorClickCount = 0;

        }

        private void XButtonClicked(object sender, EventArgs e)
        {
            if (_currentEntry != "")
            {
                if (double.TryParse(_currentEntry, out double result))
                {
                    result = 1 / result;
                    _currentEntry = result.ToString();
                    Display.Text = result.ToString();
                }

            }
        }

        private void PercentButtonClicked(object sender, EventArgs e)
        {
            if (_currentEntry != "")
            {
                if (double.TryParse(_currentEntry, out double result))
                {
                    result = result * 0.01;
                    _currentEntry = result.ToString();
                    Display.Text = result.ToString();
                }
               
            }
        }

        private void OperatorButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (_operatorClickCount > 0)
            {
                GetResultMethod();
            }

            if (double.TryParse(_currentEntry, out _value))
            {
                _operator = button.Text;
                _currentEntry = string.Empty;
                _currentOperation += _operator;
                History.Text = _currentOperation;
                _operatorClickCount++;
            }
           
        }
    }

}
