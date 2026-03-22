using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeNess.classes
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }   // строка тегов, разделённых запятыми
        public Image Image { get; set; }   // пока не используется
    }
}
