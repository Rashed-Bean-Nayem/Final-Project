using Autofac;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Models
{
    public class ViewData/*:BaseModel*/
    {
        //public IList<ElectionVoter> ElectionVoter { get; set; }
        public ElectionVoter ElectionVoter { get; set; } 
        private const string IMAGE_PATH = "temp";

        private readonly IGetService _getService;
       // private readonly BookStoreContext _bookStoreContext;
        public ViewData(IGetService getService
            /*, BookStoreContext bookStoreContext*/) 
        {
            _getService = getService;
            //_bookStoreContext = bookStoreContext;
        }
        public ViewData()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
            //_bookStoreContext = Startup.AutofacContainer.Resolve<BookStoreContext>(); 
        }

        //public void LoadBooks() 
        //{
        //    Books = ConvertToBookList(_getService.GetBookList());
        //}

        //private IList<Book> ConvertToBookList(IList<Book> books) 
        //{
        //    IList<Book> bookList = new List<Book>(); 

        //    foreach (var Bookitem in books)
        //    {
        //        bookList.Add(new Book()
        //        {
        //            Id= Bookitem.Id,
        //            Author= Bookitem.Author,
        //            Title= Bookitem.Title,
        //            Description= Bookitem.Description,
        //            Category= Bookitem.Category,
        //            Language= Bookitem.Language,
        //            TotalPages= Bookitem.TotalPages,
        //            CreatedOn= Bookitem.CreatedOn,
        //            UpdatedOn= Bookitem.UpdatedOn,
        //            CoverPhotoUrl = FormatFileUrl(Bookitem.CoverPhotoUrl)
        //        });
        //    }
        //    return bookList;
        //}

        public void LoadSingleVoter(string userId)  
        {
            ElectionVoter = ConvertToBook(_getService.GetVoter(userId));
        }

        public ElectionVoter ConvertToBook(IList<ElectionVoter> electionVoter)  
        {
            var electionVoterObj = new ElectionVoter();
            foreach (var item in electionVoter)
            {
                electionVoterObj.Name = item.Name;
                electionVoterObj.NID = item.NID;
                electionVoterObj.Mobile = item.Mobile;
                electionVoterObj.DateOfBirth = item.DateOfBirth;
                electionVoterObj.Address = item.Address;
                electionVoterObj.CoverPhotoUrl = FormatFileUrl(item.CoverPhotoUrl);
            }

            return electionVoterObj;
        }
         //book = _bookStoreContext.Books.Where(x => x.Id == id).Select(book => new Book()
            //{
            //    Author = book.Author,
            //    Language = book.Language,
            //    Category = book.Category,
            //    CoverPhotoUrl = book.CoverPhotoUrl,
            //    PdfUrl = FormatFileUrl(book.PdfUrl),
            //    CreatedOn = book.CreatedOn,
            //    UpdatedOn = book.UpdatedOn,
            //    Description = book.Description,
            //    Title = book.Title,
            //    TotalPages = book.TotalPages,
            //    Id = book.Id,
            //    BookGalleryUrl = book.BookGalleryUrl.Select(g => new BookGallery()
            //    {
            //        Id = g.Id,
            //        Name = g.Name,
            //        URL = FormatFileUrl(g.URL)
            //    }).ToList()
            //}).FirstOrDefault();
        private static string FormatFileUrl(string filePath) 
        {
            return $"/{IMAGE_PATH}/{Path.GetFileName(filePath)}";
        }      
    }
}

//private Book ConvertToBook(Book book)  
//{
//    _bookStoreContext.Books.Where().

//    Book bookObj = new Book();

//    bookObj.Id = book.Id;
//    bookObj.Title = book.Title;
//    bookObj.Author = book.Author;
//    bookObj.Category = book.Category;
//    bookObj.CreatedOn = book.CreatedOn;
//    bookObj.UpdatedOn = book.UpdatedOn;
//    bookObj.TotalPages = book.TotalPages;
//    bookObj.Description = book.Description;
//    bookObj.Language = book.Language;
//    bookObj.CoverPhotoUrl = FormatImageUrl(book.CoverPhotoUrl);
//    bookObj.BookGalleryUrl = book.BookGalleryUrl.Select(g => new BookGallery()
//    {
//        Id = g.Id,
//        Name = g.Name,
//        URL = FormatImageUrl(g.URL)
//    }).ToList();

//    return bookObj;
//}
//var gallery = new List<BookGallery>();
//foreach (var item in book.BookGalleryUrl.Select)
//{
//    gallery.Add(new BookGallery
//    {
//        Id=item.Id,
//        Name = item.Name,
//        URL = FormatImageUrl(item.URL) 
//    });
//}
