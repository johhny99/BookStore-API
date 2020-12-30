using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.WASM.Static
{
    public static class Endpoints
    {
        public static string BaseURL = "https://localhost:44314/";
        public static string AuthorsEndpoint = $"{BaseURL}api/authors/";
        public static string BooksEndpoint = $"{BaseURL}api/books/";
        public static string RegisterEndpoint = $"{BaseURL}api/users/register/";
        public static string LoginEndpoint = $"{BaseURL}api/users/login/";
    }
}
