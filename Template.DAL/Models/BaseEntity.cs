﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Template.DAL.Models;

[NotMapped]
public class BaseEntity
{
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public bool IsDeleted { get; set; }
}

[NotMapped]
public class BaseTranslationEntity : BaseEntity
{
    public int LanguageId { get; set; }
}
