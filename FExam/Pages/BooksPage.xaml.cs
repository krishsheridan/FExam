using FExam.BusinessLogic;

namespace FExam.Pages;

public partial class BooksPage : ContentPage
{
        private BookManager _booksManager;

    public BooksPage()
    {
        InitializeComponent();
        _booksManager = new BookManager();
    }

    private void OnGetDataButtonClicked(object sender, EventArgs e)
    {
        List<Book> books = _booksManager.GetAllBooks();
        BooksListView.ItemsSource = books;
    }

    public void OnBookTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item != null)
        {
            var book = (Book)e.Item;
            Navigation.PushAsync(new DetailPage(book));
        }
    }
}

