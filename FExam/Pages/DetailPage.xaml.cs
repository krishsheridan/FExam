using FExam.BusinessLogic;

namespace FExam.Pages;

public partial class DetailPage  : ContentPage
{
     DetailPage(Book book)
    {
        InitializeComponent();
        TitleLabel.Text = $"Title: {book.Title}";
        AuthorLabel.Text = $"Author: {book.AuthorName}";
        GenreLabel.Text = $"Genre: {book.Genre}";
        YearLabel.Text = $"Published Year: {book.PublishedYear}";
        PriceLabel.Text = $"Price: {book.Price:C}";
    }
}

