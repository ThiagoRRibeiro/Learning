﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Models
{
    public record Movie(string Title, string Studio, string Director, int Year);
}
