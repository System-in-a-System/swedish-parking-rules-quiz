using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace swedish_parking_rules_quiz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Initialize a dictionary for quiz text - quiz answer pairs
        IDictionary<string, string> dic = new Dictionary<string, string>()

        {
            {"Ett fordon får inte stannas eller parkeras " +
                "på eller inom ett avstånd av ... meter före ett övergångsställe, en cykelpassage eller en cykelöverfart", "tio"},
            {"Ett fordon får inte stannas eller parkeras " +
                "i en vägkorsning eller inom ett avstånd av ... meter från en korsande körbanas närmaste ytterkant", "tio"},
            {"Ett fordon får inte stannas eller parkeras " +
                "på eller inom ett avstånd av ... meter före en korsande cykelbana eller gångbana", "tio"},
            {"Ett fordon får inte stannas eller parkeras " +
                "längs en heldragen linje som anger gräns mellan körfält, " +
                "om avståndet mellan fordonet och linjen är mindre än ... meter, " +
                "såvida inte en streckad linje löper mellan fordonet och den heldragna linjen", "tre"},
            {"Ett fordon får inte stannas eller parkeras " +
                "... meter före och fem meter efter märket E22, busshållplats", "tjugo"},
            {"Ett fordon får inte stannas eller parkeras " +
                "på en väg inom ett avstånd av ... meter från en plankorsning", "trettio"},
            {"Inom vägområde för allmän väg får fordon parkeras högst ... timmar i följd på vardagar, utom vardag före sön- och helgdag.", "24"},
        };

        // Initialize a random "picker"
        Random picker = new Random();

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Enable the answer field and the send button
            answerField.IsEnabled = true;
            sendButton.IsEnabled = true;

            // Load quiz text to the text field using random picker to pick from the dictionary
            quizText.Text = dic.ElementAt(picker.Next(0, dic.Count)).Key;
        }
    }
}
