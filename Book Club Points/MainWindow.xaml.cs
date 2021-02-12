using System.Windows;

namespace Book_Club_Points
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int MIN_POINTS = 0;
        const int LOW_POINTS = 5;
        const int AVERAGE_POINTS = 15;
        const int HIGH_POINTS = 30;
        const int MAX_POINTS = 60;

        const int MIN_BOOKS = 0;
        const int LOW_BOOKS = 1;
        const int AVERAGE_BOOKS = 2;
        const int HIGH_BOOKS = 3;
        const int MAX_BOOKS = 4;

        public MainWindow()
        {
            InitializeComponent();
        }

        private int CalculatePoints(int NumberOfBooks)
        {
            int Points = 0;
            if (NumberOfBooks == MIN_BOOKS)
            {
                Points = MIN_POINTS;
            }
            else if (NumberOfBooks == LOW_BOOKS)
            {
                Points = LOW_POINTS;
            }
            else if (NumberOfBooks == AVERAGE_BOOKS)
            {
                Points = AVERAGE_POINTS;
            }
            else if(NumberOfBooks == HIGH_BOOKS)
            {
                Points = HIGH_POINTS;
            }
            else if(NumberOfBooks >= MAX_BOOKS)
            {
                Points = MAX_POINTS;
            }
            return Points;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int BooksPurchased = int.Parse(InputTextBox.Text);
                int PointsEarned = CalculatePoints(BooksPurchased);
                PointsEarnedLabel.Content = PointsEarned;
            }
            catch
            {
                InputTextBox.Text = "";
                ErrorWindow E = new ErrorWindow();
                E.Show();
            }
        }
    }
}
