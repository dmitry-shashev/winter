namespace Winter.Models.Adapters;

public static class BookAdapters
{
  public static BookResponseDto AsResponseDto(
    this Book book
  )
  {
    return new BookResponseDto(
      book.Id,
      book.Author,
      book.BookName
    );
  }
}
