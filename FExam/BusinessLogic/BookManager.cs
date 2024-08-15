using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FExam.BusinessLogic
{
    internal class BookManager
    {
        private readonly Readdata _repository;

        public BookManager()
        {
            _repository = new Readdata();
        }

        public List<Book> GetAllBooks()
        {
            return _repository.GetBooks();
        }
    }
}

    

