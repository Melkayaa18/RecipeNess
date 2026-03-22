using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeNess.classes
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }

        public static bool IsAdmin => Role == "администратор";
    }
}
