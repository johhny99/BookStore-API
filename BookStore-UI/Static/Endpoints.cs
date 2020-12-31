﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Static
{
    public static class Endpoints
    {
#if DEBUG 
        public static string BaseURL = "https://localhost:44314/";
#else
        public static string BaseURL = "https://bookstore-api20201231094735.azurewebsites.net/";
#endif
        public static string AuthorsEndpoint = $"{BaseURL}api/authors/";
        public static string BooksEndpoint = $"{BaseURL}api/books/";
        public static string RegisterEndpoint = $"{BaseURL}api/users/register/";
        public static string LoginEndpoint = $"{BaseURL}api/users/login/";
    }
}
