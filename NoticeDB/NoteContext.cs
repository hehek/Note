﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace NoticeDB
{
    class NoteContext : DbContext
    {
        public NoteContext(): base("DbConnection")
        {
        }

        public DbSet<Note> Notes { get; }

    }
}
