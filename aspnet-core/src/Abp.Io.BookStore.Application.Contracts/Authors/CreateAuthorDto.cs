﻿using System;

namespace Abp.Io.BookStore.Authors;

public class CreateAuthorDto
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string ShortBio { get; set; }
}