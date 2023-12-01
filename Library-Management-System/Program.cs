using Library_Management_System.Concrete;

Book book1 = new("Dune","Frank Herbert","İthaki Yayınları",712);
Journal journal1 = new("Science Journal", "Scientific Press", 100, 28, DateTime.Parse("2023-01-15"), 3);

OrdinaryPerson ordinaryPerson = new("", "");
UniversityStudent universityStudent = new(Universities.ESOGÜ, "Ömer", "YAVUZ");


Library.AddPublication(book1);
Library.AddPublication(journal1);

Library.AddMember(ordinaryPerson);
Library.AddMember(universityStudent);

Library.Borrow(ordinaryPerson, book1);
