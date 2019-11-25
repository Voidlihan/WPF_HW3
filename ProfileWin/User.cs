using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileWin
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
    }
}
