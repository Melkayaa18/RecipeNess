using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeNess.classes
{
    public class ModerationNotification
    {
        public string RecipeName { get; set; }
        public DateTime ResponseDate { get; set; }
        public bool IsApproved { get; set; } 
        public string Comment { get; set; }
    }
}
