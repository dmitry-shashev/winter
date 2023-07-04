namespace Winter.Models.Adapters;

public static class LibraryAdapters
{
  public static LibraryResponseDto AsResponseDto(
    this Library library
  )
  {
    return new LibraryResponseDto(
      library.Id,
      library.Address
    );
  }
}
