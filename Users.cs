using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace XF2_443_Q3
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Number { get; set; }
        public int Code { get; set; }


    }
}