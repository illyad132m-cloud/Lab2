using lab_2_task_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Демонстрація роботи застосунку бібліотеки");
Catalog catalog = new Catalog();

catalog.AddItem(new Book("Гаррі Поттер", "Дж. Роулінг"));
catalog.AddItem(new Magazine("Наука і життя", 12));
catalog.AddItem(new Newspaper("The New York Times"));

Librarian librarian = new Librarian("Олександр");
LibraryMember member1 = new LibraryMember("Іван");
LibraryMember member2 = new LibraryMember("Марія");

LibraryItem Booksearch = catalog.Search("Гаррі Поттер");
if (Booksearch != null)
{
	librarian.addBook(Booksearch, member1);
	librarian.addBook(Booksearch, member2);

	librarian.returnBook(Booksearch);

}

Console.ReadLine();