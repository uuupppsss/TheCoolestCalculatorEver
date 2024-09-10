namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private string _currentEntry=string.Empty;
        private string _operator = string.Empty;
        private double _value = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            _currentEntry=_currentEntry.Remove(_currentEntry.Length - 1);
            Display.Text=_currentEntry;
        }

        private void CE_ButtonClicked(object sender, EventArgs e)
        {

        }

        private void C_ButtonClicked(object sender, EventArgs e)
        {
            _currentEntry= string.Empty;
            _operator= string.Empty;
            Display.Text=string.Empty;
        }

        private void PlusMinusButtonClicked(object sender, EventArgs e)
        {
            if (_currentEntry != "")
            {
                double result = double.Parse(_currentEntry) * (-1);
                _currentEntry = result.ToString();
                Display.Text = result.ToString();
            }
            
        }

        private void SquareButtonClicked(object sender, EventArgs e)
        {
            double result = Math.Sqrt(double.Parse(_currentEntry));
            Display.Text = result.ToString();
            _currentEntry = result.ToString();
        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {
           var button= sender as Button;
            _currentEntry += button.Text;
            Display.Text = _currentEntry;
           
        }

        private void EqualsButtonClicked(object sender, EventArgs e)
        {
            double result = 0;
            double second_value = double.Parse(_currentEntry);
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

        private void XButtonClicked(object sender, EventArgs e)
        {
            double result = 1/double.Parse(_currentEntry);
            Display.Text = result.ToString();
            _currentEntry = result.ToString();
        }

        private void PercentButtonClicked(object sender, EventArgs e)
        {
            
        }

        private void OperatorButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            _value = double.Parse(_currentEntry);
            _operator = button.Text;
            _currentEntry = string.Empty;
        }
    }

}
