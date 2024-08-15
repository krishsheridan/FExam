namespace FExam.Pages;

public partial class AboutMe : ContentPage
{
    public AboutMe()
    {

            {
                InitializeComponent();
            }

            void OnBooksPageButtonClicked(object sender, EventArgs e)
            {
                Navigation.PushAsync(new BooksPage());
            }
        }
    }

   