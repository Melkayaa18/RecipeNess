using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeNess.classes
{
    public static class UserSession
    {
        public static bool IsLoggedIn { get; private set; }
        public static string Username { get; private set; }
        public static int UserId { get; private set; }

        public static void Login(int userId, string username)
        {
            UserId = userId;
            Username = username;
            IsLoggedIn = true;
        }

        public static void Logout()
        {
            UserId = 0;
            Username = null;
            IsLoggedIn = false;
        }
    }
}
