﻿namespace ELib.DAL.Migrations
{
    using Domain.Entities;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ELib.DAL.Infrastructure.Concrete.ELibDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ELib.DAL.Infrastructure.Concrete.ELibDbContext";
        }

        protected override void Seed(ELib.DAL.Infrastructure.Concrete.ELibDbContext context)
        {

            //users
            var applicationUsers = new List<ApplicationUser>()
            {
                new ApplicationUser() { Id = "98f9156c-f396-4c25-9cdb-8f559da4046c", Email = "John@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "John" },
                new ApplicationUser() { Id = "f43b6e5c-c4e5-4db5-9d7b-813f77edcaec", Email = "Frank@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "Frank" },
                new ApplicationUser() { Id = "98f9156c-4c25-f396-9cdb-8f559da4047c", Email = "Eva@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "Eva" },
                new ApplicationUser() { Id = "98f9156c-c4e5-4c25-9cdb-8f559da4048c", Email = "Peter@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "Peter" },
                new ApplicationUser() { Id = "98f9156c-9cdb-f396-4c25-8f559da4049c", Email = "Howard@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "Howard" },
                new ApplicationUser() { Id = "98f9156c-f396-9cdb-9cdb-8f559da4050c", Email = "Mary@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "Mary" },
                new ApplicationUser() { Id = "98f9156c-f396-4c25-9cdb-8f559da4051c", Email = "Simón@mail.ru", EmailConfirmed = false, PasswordHash = "AFO3zX6UgpLp5+2KG6CHTCGxBA6GxYPA30Q4dejAe8P4tf/p4vcPHcKi1jVwkhsNhw==", SecurityStamp = "8e83a385-aa50-4055-86dc-0260ed971a20", PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true, AccessFailedCount = 0, UserName = "Simón" }
            };

            applicationUsers.ForEach(x => context.Users.AddOrUpdate(u => u.Email, x));
            context.SaveChanges();

            //users - roles
            var userRole1 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4046c", UserId = "98f9156c-f396-4c25-9cdb-8f559da4046c" };
            var userRole2 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4046c", UserId = "f43b6e5c-c4e5-4db5-9d7b-813f77edcaec" };
            var userRole3 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4047c", UserId = "98f9156c-4c25-f396-9cdb-8f559da4047c" };
            var userRole4 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4047c", UserId = "98f9156c-c4e5-4c25-9cdb-8f559da4048c" };
            var userRole5 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4048c", UserId = "98f9156c-9cdb-f396-4c25-8f559da4049c" };
            var userRole6 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4048c", UserId = "98f9156c-f396-9cdb-9cdb-8f559da4050c" };
            var userRole7 = new IdentityUserRole() { RoleId = "98f9156c-f396-4c25-9cdb-8f559da4048c", UserId = "98f9156c-f396-4c25-9cdb-8f559da4051c" };

            //roles
            var roles = new List<IdentityRole>()
            {
                new IdentityRole() { Id = "98f9156c-f396-4c25-9cdb-8f559da4046c", Name = "ApprovedMember", Users = { userRole1, userRole2 } },
                new IdentityRole() { Id = "98f9156c-f396-4c25-9cdb-8f559da4047c", Name = "Moderator", Users = { userRole3, userRole4 } },
                new IdentityRole() { Id = "98f9156c-f396-4c25-9cdb-8f559da4048c", Name = "Administrator", Users = { userRole5, userRole6, userRole7 } }
            };

            roles.ForEach(x => context.Roles.AddOrUpdate(r => r.Name, x));
            context.SaveChanges();

            //people
            var people = new List<Person>()
            {
                new Person() { FirstName = "John", Login = "John", RegistrationDate = DateTime.Now, AplicationUserId = "98f9156c-f396-4c25-9cdb-8f559da4046c" },
                new Person() { FirstName = "Frank", Login = "Frank", RegistrationDate = DateTime.Now, AplicationUserId = "f43b6e5c-c4e5-4db5-9d7b-813f77edcaec" },
                new Person() { FirstName = "Eva", Login = "Eva", RegistrationDate = DateTime.Now, AplicationUserId = "98f9156c-4c25-f396-9cdb-8f559da4047c" },
                new Person() { FirstName = "Peter", Login = "Peter", RegistrationDate = DateTime.Now, AplicationUserId = "98f9156c-c4e5-4c25-9cdb-8f559da4048c" },
                new Person() { FirstName = "Howard", Login = "Howard", RegistrationDate = DateTime.Now, AplicationUserId = "98f9156c-9cdb-f396-4c25-8f559da4049c" },
                new Person() { FirstName = "Mary", Login = "Mary", RegistrationDate = DateTime.Now, AplicationUserId = "98f9156c-f396-9cdb-9cdb-8f559da4050c" },
                new Person() { FirstName = "Simón", Login = "Simón", RegistrationDate = DateTime.Now, AplicationUserId = "98f9156c-f396-4c25-9cdb-8f559da4051c" }
            };

            people.ForEach(x => context.People.AddOrUpdate(p => p.AplicationUserId, x));
            context.SaveChanges();

            //genres
            var genres = new List<Genre>()
            {
                new Genre() { Name = "Техническая литература" },
                new Genre() { Name = "Детектив" },
                new Genre() { Name = "Ужасы" },
                new Genre() { Name = "Женский роман" },
                new Genre() { Name = "Фантастика" },
                new Genre() { Name = "Фэнтези" },
                new Genre() { Name = "Драма" }
            };

            genres.ForEach(x => context.Genres.AddOrUpdate(g => g.Name, x));
            context.SaveChanges();

            //subgenres
            var subgenres = new List<Subgenre>()
            {
                new Subgenre() { Name = "Роман" }
            };

            subgenres.ForEach(x => context.Subgenres.AddOrUpdate(g => g.Name, x));
            context.SaveChanges();

            //authors
            var authors = new List<Author>()
            {
                new Author()
                {
                    FirstName = "Джефри",
                    LastName = "Рихтер",
                    Description = " Компьютерный специалист, автор наиболее хорошо продаваемых книг в области Win32 и .NET." +
                " Рихтер — соучредитель компании Wintellect, которая обучает ИТ-специалистов и консультирует фирмы в области создания ПО."
                },
                new Author()
                {
                    FirstName = "Стивен",
                    LastName = "Кинг",
                    Description = " Американский писатель, работающий в разнообразных жанрах, включая ужасы, триллер, фантастику," +
                    " фэнтези, мистику, драму; получил прозвище «Король ужасов». Продано более 350 миллионов экземпляров его книг," +
                    " по которым был снят ряд художественных фильмов, телевизионных постановок, а также нарисованы комиксы.",
                    DateOfBirth = new DateTime(1947, 9, 21)
                },
                new Author()
                {
                    FirstName = "Эрих",
                    LastName = "Гамма",
                    Description = "Программист из Швейцарии, один из четырёх авторов классической книги Design Patterns о шаблонах проектирования." +
                    " Команда авторов книги также известна под названием «банда четырёх» (англ. Gang of Four, GoF). Является ведущим разработчиком JUnit " +
                    "и Eclipse (кросс-платформенной интегрированной среды разработки программного обеспечения). Работал в IBM над проектом Jazz. " +
                    " С 2011 года руководит командой разработки Microsoft Visual Studio в Цюрихе, Швейцария.",
                    DateOfBirth = new DateTime(1961, 3, 13)
                },
                new Author() { FirstName = "Ричард", LastName = "Хелм", },
                new Author() { FirstName = "Ральф", LastName = "Джонсон", Description = "", DateOfBirth = new DateTime(1955, 10, 7) },
                new Author() { FirstName = "Джон", LastName = "Влиссидс", Description = "", DateOfBirth = new DateTime(1961, 8, 2), DeathDate = new DateTime(2005, 11, 24) }
            };
            authors.ForEach(x => context.Authors.AddOrUpdate(a => a.LastName, x));
            context.SaveChanges();

            //authGenres

            var authorGenres = new List<AuthorGenre>()
            {
                new AuthorGenre() { AuthorId = 1, GenreId = 1 },
                new AuthorGenre() { AuthorId = 2, GenreId = 1 },
                new AuthorGenre() { AuthorId = 3, GenreId = 3 },
                new AuthorGenre() { AuthorId = 4, GenreId = 1 },
                new AuthorGenre() { AuthorId = 5, GenreId = 1 },
                new AuthorGenre() { AuthorId = 6, GenreId = 1 }
            };

            authorGenres.ForEach(x => context.AuthorGenres.AddOrUpdate(a => a.AuthorId, x));
            context.SaveChanges();

            //publishers
            var publishers = new List<Publisher>()
            {
                new Publisher { Name = "Аст" },
                new Publisher { Name = "Астрель" },
                new Publisher { Name = "Питер" },
                new Publisher { Name = "Microsoft Press" }
            };

            publishers.ForEach(x => context.Publishers.AddOrUpdate(p => p.Name, x));
            context.SaveChanges();

            //languages
            var languages = new List<Language>()
            {
                new Language { Name = "RU" },
                new Language { Name = "UK" },
                new Language { Name = "EN" },
                new Language { Name = "IT" },
                new Language { Name = "FR" },
                new Language { Name = "DE" },
                new Language { Name = "PR" }
            };

            languages.ForEach(x => context.Languages.AddOrUpdate(l => l.Name, x));
            context.SaveChanges();

            //books
            var books = new List<Book>()
            {
                new Book()
                {
                    Title = "Программирование на платформе Microsoft .NET Framework 4.5 на языке C#",
                    Description = "Эта книга, выходящая в четвертом издании и уже ставшая классическим учебником по" +
                    "программированию, подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей " +
                    " среды (CLR) Microsoft .NET Framework версии 4.5. Написанная признанным экспертом в области " +
                    "программирования Джеффри Рихтером, много лет являющимся консультантом команды разработчиков .NET " +
                    " Framework компании Microsoft, книга научит вас создавать по-настоящему надежные приложения любого вида, " +
                    "в том числе с использованием Microsoft Silverlight, ASP.NET, Windows Presentation Foundation и т. д.",
                    OriginalLangId = 3,
                    PublishLangId = 1,
                    PublisherId = 3,
                    SubgenreId = 1,
                    Isbn = "978-5-496-00433-6",
                    PublishYear = new DateTime(2013, 1, 1),
                    TotalPages = 896
                },
                new Book()
                {
                    Title = "CLR via C#",
                    Description = "",
                    PublishLangId = 3,
                    Isbn = "978-0-7356-6745-7",
                    PublishYear = new DateTime(2012, 1, 1),
                    SubgenreId = 1,
                    TotalPages = 870,
                    PublisherId = 4
                },
                new Book()
                {
                    Title = "Оно",
                    Description = "В маленьком провинциальном городке Дерри много лет назад семерым подросткам пришлось столкнуться с кромешным ужасом" +
                                  " – живым воплощением ада. Прошли годы… Подростки повзрослели, и ничто, казалось, не предвещало новой беды. Но кошмар " +
                                  "прошлого вернулся, неведомая сила повлекла семерых друзей назад, в новую битву со Злом. Ибо в Дерри опять льется кровь" +
                                  " и бесследно исчезают люди. Ибо вернулось порождение ночного кошмара, настолько невероятное, что даже не имеет имени… ",
                    OriginalLangId = 3,
                    PublishLangId = 1,
                    SubgenreId = 1,
                    PublisherId = 1,
                    Isbn = "978-5-17-077763-1",
                    PublishYear = new DateTime(2015, 8, 3),
                    TotalPages = 1248
                },
                new Book()
                {
                    Title = "Кэрри",
                    Description = "Маленький провинциальный городок в Новой Англии в одночасье становится \"мертвым городом \". На улицах лежат трупы, " +
                    "над домами бушует смертоносное пламя. И весь этот кошмар огненного Апокалипсиса ― дело рук одного человека, девушки Кэрри, жалкой, " +
                    "запуганной дочери чудаковатой вдовы. Долгие годы дремал в Кэрри талант телекинеза, чтобы однажды проснуться. И тогда в городок пришла смерть...",
                    OriginalLangId = 3,
                    PublishLangId = 1,
                    SubgenreId = 1,
                    PublisherId = 2,
                    Isbn = "978-5-17-078099-0",
                    PublishYear = new DateTime(2013, 1, 1),
                    TotalPages = 320
                },
                new Book()
                {
                    Title = "Приемы объектно-ориентированого програмирования. Паттерны проэктирования",
                    Description = "В предлагаемой книге описываются простые и изящные решения типичных задач, возникающих в " +
                                  "объектно-ориентированном проектировании. Паттерны появились потому, что многие разработчики" +
                                  " искали пути повышения гибкости и степени повторного использования своих программ. Найденные решения" +
                                  "воплощены в краткой и легко применимой на практике форме. Авторы излагают принципы использования" +
                                  "паттернов проектирования и приводят их каталог. Таким образом, книга одновременно решает две задачи." +
                                  "Во-первых, здесь демонстрируется роль паттернов в создании архитектуры сложных систем. Во-вторых, " +
                                   "применяя содержащиеся в справочнике паттерны, проектировщик сможет с легкостью разрабатывать собственные приложения.",
                    OriginalLangId = 3,
                    PublishLangId = 1,
                    SubgenreId = 1,
                    PublisherId = 3,
                    Isbn = "5-272-00355-1",
                    PublishYear = new DateTime(2001, 1, 1),
                    TotalPages = 352
                }
            };

            books.ForEach(x => context.Books.AddOrUpdate(b => b.Title, x));
            context.SaveChanges();

            //bookGenres
            var bookGenres = new List<BookGenre>()
            {
                new BookGenre { BookId = 1, GenreId = 1 },
                new BookGenre { BookId = 2, GenreId = 1 },
                new BookGenre { BookId = 3, GenreId = 2 },
                new BookGenre { BookId = 4, GenreId = 2 },
                new BookGenre { BookId = 5, GenreId = 1 }
            };

            bookGenres.ForEach(x => context.BookGenres.AddOrUpdate(g => g.BookId, x));
            context.SaveChanges();

            //bookAuthors
            var bookAuthors = new List<BookAuthor>()
            {
                new BookAuthor { AuthorId = 1, BookId = 1 },
                new BookAuthor { AuthorId = 2, BookId = 4 },
                new BookAuthor { AuthorId = 3, BookId = 5 },
                new BookAuthor { AuthorId = 4, BookId = 5 },
                new BookAuthor { AuthorId = 5, BookId = 5 },
                new BookAuthor { AuthorId = 6, BookId = 5 }
            };

            bookAuthors.ForEach(x => context.BookAuthors.AddOrUpdate(b => b.AuthorId, x));
            context.SaveChanges();
        }
    }
}
