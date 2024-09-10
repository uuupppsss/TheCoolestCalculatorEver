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

        }

        private void CE_ButtonClicked(object sender, EventArgs e)
        {

        }

        private void C_ButtonClicked(object sender, EventArgs e)
        {

        }

        private void PlusMinusButtonClicked(object sender, EventArgs e)
        {

        }

        private void SquareButtonClicked(object sender, EventArgs e)
        {

        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {
           var button= sender as Button;
            _currentEntry += button.Text;
            Display.Text = _currentEntry;
           
        }

        private void CommaButtonClicked(object sender, EventArgs e)
        {

        }

        private void EqualsButtonClicked(object sender, EventArgs e)
        {
            double result = 0;
            double second_value = double.Parse(_currentEntry);
            switch (_operator)
            {
                case "+":
                    result=
                    break;
                case "-": break;
                case "/": break;
                case "*": break;
            }
        }

        private void XButtonClicked(object sender, EventArgs e)
        {

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
