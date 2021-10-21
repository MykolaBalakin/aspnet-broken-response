namespace AspNetBrokenResponse;

public record User(string FirstName, string LastName, string Description, Role[] Roles);

public record Role(string Name);

public class UserRepository
{
    public User[] GetAll()
    {
        return new[]
        {
            new User(
                "Donald",
                "Knuth",
                "Donald Ervin Knuth is an American computer scientist, mathematician, and professor emeritus at Stanford University. He is the 1974 recipient of the ACM Turing Award, informally considered the Nobel Prize of computer science. Knuth has been called the \"father of the analysis of algorithms\".",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Writer") }),
            new User(
                "Andrew",
                "Troelsen",
                "Andrew W. Troelsen is currently a technology manager at Thomson Reuters in the Enterprise Content Platform (ECP - Big Data) division. He is an author of several books in the Microsoft technology space including books on Microsoft (D)COM, ATL, .NET, C#, VB (4.0 - modern) and COM & .NET Interoperability. His latest edition of his C# book covers the .NET Core platform and each C# 7.0 update. He has over 18 years experience authoring software development (3-5 day) workshops for engineers on MS platform technologies.",
                new[] { new Role("Writer") }),
            new User(
                "Scott",
                "Hanselman",
                "Scott Hanselman works for Microsoft as Principal Community Architect for Web Platform and Tools, aiming to spread the good word about developing software, most often on the Microsoft stack. Before this he was the Chief Architect at Corillian Corporation, now a part of Checkfree, for 6+ years and before that he was a Principal Consultant at STEP Technology for nearly 7 years. He will speak about computers (and other passions) whenever someone will listen to him. He's written in a few books, most recently with Bill Evjen and Devin Rader on Professional ASP.NET. He blogs at http://www.hanselman.com for the last 10 years and podcasts weekly at http://www.hanselminutes.com and http://www.thisdeveloperslife.com.",
                new[] { new Role("Instructor"), new Role("Speaker") }),
            new User(
                "Martin",
                "Fowler",
                "Martin Fowler is an American-resident British software developer, author and international public speaker on software development, specialising in object-oriented analysis and design, UML, patterns, and agile software development methodologies, including extreme programming. His 1999 book Refactoring popularised the practice of code refactoring. In 2004 he introduced Presentation Model (PM), an architectural pattern.",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Developer"), new Role("Writer") }),
            new User(
                "Jeffrey",
                "Richter",
                "Jeffrey Richter is a Software Engineer on Microsoft’s Azure Hyper-Scale compute team. He is also a co-founder of Wintellect, a software consulting and training company. He is the author of several best-selling Windows and .NET Framework programming books including Windows Runtime via C#, CLR via C#, 4th Edition, and Windows via C/C++, 5th Edition. Jeffrey has also been a contributing editor to MSDN Magazine where he authored many feature articles and columns.",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Speaker"), new Role("Writer") }),
            new User(
                "Scott",
                "Hanselman",
                "Scott Hanselman works for Microsoft as Principal Community Architect for Web Platform and Tools, aiming to spread the good word about developing software, most often on the Microsoft stack. Before this he was the Chief Architect at Corillian Corporation, now a part of Checkfree, for 6+ years and before that he was a Principal Consultant at STEP Technology for nearly 7 years. He will speak about computers (and other passions) whenever someone will listen to him. He's written in a few books, most recently with Bill Evjen and Devin Rader on Professional ASP.NET. He blogs at http://www.hanselman.com for the last 10 years and podcasts weekly at http://www.hanselminutes.com and http://www.thisdeveloperslife.com.",
                new[] { new Role("Instructor"), new Role("Speaker") }),
            new User(
                "Andrew",
                "Troelsen",
                "Andrew W. Troelsen is currently a technology manager at Thomson Reuters in the Enterprise Content Platform (ECP - Big Data) division. He is an author of several books in the Microsoft technology space including books on Microsoft (D)COM, ATL, .NET, C#, VB (4.0 - modern) and COM & .NET Interoperability. His latest edition of his C# book covers the .NET Core platform and each C# 7.0 update. He has over 18 years experience authoring software development (3-5 day) workshops for engineers on MS platform technologies.",
                new[] { new Role("Writer") }),
            new User(
                "Scott",
                "Hanselman",
                "Scott Hanselman works for Microsoft as Principal Community Architect for Web Platform and Tools, aiming to spread the good word about developing software, most often on the Microsoft stack. Before this he was the Chief Architect at Corillian Corporation, now a part of Checkfree, for 6+ years and before that he was a Principal Consultant at STEP Technology for nearly 7 years. He will speak about computers (and other passions) whenever someone will listen to him. He's written in a few books, most recently with Bill Evjen and Devin Rader on Professional ASP.NET. He blogs at http://www.hanselman.com for the last 10 years and podcasts weekly at http://www.hanselminutes.com and http://www.thisdeveloperslife.com.",
                new[] { new Role("Instructor"), new Role("Speaker") }),
            new User(
                "Robert Cecil",
                "Martin",
                "Robert Cecil Martin (born 5 December 1952), colloquially called \"Uncle Bob\", is an American software engineer, instructor, and best-selling author. He is most recognized for developing many software design principles and for being a founder of the influential Agile Manifesto. Martin has authored many books and magazine articles. He was the editor-in-chief of C++ Report magazine and served as the first chairman of the Agile Alliance.",
                new[] { new Role("Professor"), new Role("Instructor") }),
            new User(
                "Scott",
                "Hanselman",
                "Scott Hanselman works for Microsoft as Principal Community Architect for Web Platform and Tools, aiming to spread the good word about developing software, most often on the Microsoft stack. Before this he was the Chief Architect at Corillian Corporation, now a part of Checkfree, for 6+ years and before that he was a Principal Consultant at STEP Technology for nearly 7 years. He will speak about computers (and other passions) whenever someone will listen to him. He's written in a few books, most recently with Bill Evjen and Devin Rader on Professional ASP.NET. He blogs at http://www.hanselman.com for the last 10 years and podcasts weekly at http://www.hanselminutes.com and http://www.thisdeveloperslife.com.",
                new[] { new Role("Instructor"), new Role("Speaker") }),
            new User(
                "Martin",
                "Fowler",
                "Martin Fowler is an American-resident British software developer, author and international public speaker on software development, specialising in object-oriented analysis and design, UML, patterns, and agile software development methodologies, including extreme programming. His 1999 book Refactoring popularised the practice of code refactoring. In 2004 he introduced Presentation Model (PM), an architectural pattern.",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Developer"), new Role("Writer") }),
            new User(
                "Jeffrey",
                "Richter",
                "Jeffrey Richter is a Software Engineer on Microsoft’s Azure Hyper-Scale compute team. He is also a co-founder of Wintellect, a software consulting and training company. He is the author of several best-selling Windows and .NET Framework programming books including Windows Runtime via C#, CLR via C#, 4th Edition, and Windows via C/C++, 5th Edition. Jeffrey has also been a contributing editor to MSDN Magazine where he authored many feature articles and columns.",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Speaker"), new Role("Writer") }),
            new User(
                "Donald",
                "Knuth",
                "Donald Ervin Knuth is an American computer scientist, mathematician, and professor emeritus at Stanford University. He is the 1974 recipient of the ACM Turing Award, informally considered the Nobel Prize of computer science. Knuth has been called the \"father of the analysis of algorithms\".",
                new Role[0]),
            new User(
                "Donald",
                "Knuth",
                "Donald Ervin Knuth is an American computer scientist, mathematician, and professor emeritus at Stanford University. He is the 1974 recipient of the ACM Turing Award, informally considered the Nobel Prize of computer science. Knuth has been called the \"father of the analysis of algorithms\".",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Writer") }),
            new User(
                "Martin",
                "Fowler",
                "Martin Fowler is an American-resident British software developer, author and international public speaker on software development, specialising in object-oriented analysis and design, UML, patterns, and agile software development methodologies, including extreme programming. His 1999 book Refactoring popularised the practice of code refactoring. In 2004 he introduced Presentation Model (PM), an architectural pattern.",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Developer"), new Role("Writer") }),
            new User(
                "Jeffrey",
                "Richter",
                "Jeffrey Richter is a Software Engineer on Microsoft’s Azure Hyper-Scale compute team. He is also a co-founder of Wintellect, a software consulting and training company. He is the author of several best-selling Windows and .NET Framework programming books including Windows Runtime via C#, CLR via C#, 4th Edition, and Windows via C/C++, 5th Edition. Jeffrey has also been a contributing editor to MSDN Magazine where he authored many feature articles and columns.",
                new[] { new Role("Professor"), new Role("Instructor"), new Role("Speaker"), new Role("Writer") }),
            new User(
                "Scott",
                "Hanselman",
                "Scott Hanselman works for Microsoft as Principal Community Architect for Web Platform and Tools, aiming to spread the good word about developing software, most often on the Microsoft stack. Before this he was the Chief Architect at Corillian Corporation, now a part of Checkfree, for 6+ years and before that he was a Principal Consultant at STEP Technology for nearly 7 years. He will speak about computers (and other passions) whenever someone will listen to him. He's written in a few books, most recently with Bill Evjen and Devin Rader on Professional ASP.NET. He blogs at http://www.hanselman.com for the last 10 years and podcasts weekly at http://www.hanselminutes.com and http://www.thisdeveloperslife.com.",
                new[] { new Role("Instructor"), new Role("Speaker") }),
            new User(
                "Robert Cecil",
                "Martin",
                "Robert Cecil Martin (born 5 December 1952), colloquially called \"Uncle Bob\", is an American software engineer, instructor, and best-selling author. He is most recognized for developing many software design principles and for being a founder of the influential Agile Manifesto. Martin has authored many books and magazine articles. He was the editor-in-chief of C++ Report magazine and served as the first chairman of the Agile Alliance.",
                new[] { new Role("Professor"), new Role("Instructor") }),
            new User(
                "Donald",
                "Knuth",
                "Donald Ervin Knuth is an American computer scientist, mathematician, and professor emeritus at Stanford University. He is the 1974 recipient of the ACM Turing Award, informally considered the Nobel Prize of computer science. Knuth has been called the \"father of the analysis of algorithms\".",
                new Role[0]),
            new User(
                "Jeffrey",
                "Richter",
                "Jeffrey Richter is a Software Engineer on Microsoft’s Azure Hyper-Scale compute team. He is also a co-founder of Wintellect, a software consulting and training company. He is the author of several best-selling Windows and .NET Framework programming books including Windows Runtime via C#, CLR via C#, 4th Edition, and Windows via C/C++, 5th Edition. Jeffrey has also been a contributing editor to MSDN Magazine where he authored many feature articles and columns.",
                null),
            new User(
                "Scott",
                "Hanselman",
                "Scott Hanselman works for Microsoft as Principal Community Architect for Web Platform and Tools, aiming to spread the good word about developing software, most often on the Microsoft stack. Before this he was the Chief Architect at Corillian Corporation, now a part of Checkfree, for 6+ years and before that he was a Principal Consultant at STEP Technology for nearly 7 years. He will speak about computers (and other passions) whenever someone will listen to him. He's written in a few books, most recently with Bill Evjen and Devin Rader on Professional ASP.NET. He blogs at http://www.hanselman.com for the last 10 years and podcasts weekly at http://www.hanselminutes.com and http://www.thisdeveloperslife.com.",
                new[] { new Role("Instructor"), new Role("Speaker") }),
            new User(
                "Andrew",
                "Troelsen",
                "Andrew W. Troelsen is currently a technology manager at Thomson Reuters in the Enterprise Content Platform (ECP - Big Data) division. He is an author of several books in the Microsoft technology space including books on Microsoft (D)COM, ATL, .NET, C#, VB (4.0 - modern) and COM & .NET Interoperability. His latest edition of his C# book covers the .NET Core platform and each C# 7.0 update. He has over 18 years experience authoring software development (3-5 day) workshops for engineers on MS platform technologies.",
                new[] { new Role("Writer") }),
            new User(
                "Robert Cecil",
                "Martin",
                "Robert Cecil Martin (born 5 December 1952), colloquially called \"Uncle Bob\", is an American software engineer, instructor, and best-selling author. He is most recognized for developing many software design principles and for being a founder of the influential Agile Manifesto. Martin has authored many books and magazine articles. He was the editor-in-chief of C++ Report magazine and served as the first chairman of the Agile Alliance.",
                new[] { new Role("Professor"), new Role("Instructor") }),
            new User(
                "Donald",
                "Knuth",
                "Donald Ervin Knuth is an American computer scientist, mathematician, and professor emeritus at Stanford University. He is the 1974 recipient of the ACM Turing Award, informally considered the Nobel Prize of computer science. Knuth has been called the \"father of the analysis of algorithms\".",
                new Role[0]),
        };
    }
}