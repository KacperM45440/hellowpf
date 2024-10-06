using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button newButton;
        private WrapPanel buttonPanel;
        private TextBlock buttonText;
        public MainWindow()
        {
            newButton = new();
            buttonPanel = new();
            buttonText = new();

            InitializeComponent();
            SubscribeToEvents();
            CreateButton();
        }

        private void SubscribeToEvents()
        {
            gridMain.MouseUp += new MouseButtonEventHandler(gridMain_MouseUp);
            gridMain.MouseDown += new MouseButtonEventHandler(gridMain_MouseDown);
        }

        private void CreateButton()
        {
            newButton.FontWeight = FontWeights.Bold;
            newButton.Margin = new Thickness(440, 300, 160, 50);

            for (int i=0; i<3; i++)
            {
                buttonText = new();
                switch(i)
                {
                    case 0:
                        buttonText.Text = "Multi";
                        buttonText.Foreground = Brushes.Blue;
                        break;
                    case 1:
                        buttonText.Text = "Color";
                        buttonText.Foreground = Brushes.Red;
                        break;
                    case 2:
                        buttonText.Text = "C#Button";
                        break;
                }
                buttonPanel.Children.Add(buttonText);
            }

            newButton.Content = buttonPanel;
            gridMain.Children.Add(newButton);
        }

        private void gridMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }

        private void gridMain_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}