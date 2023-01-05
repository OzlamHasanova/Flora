using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class SlideDesc
{
    public int Id { get; set; }
    [Required, MaxLength(200)]
    public string Header1 { get; set; }
    [Required, MaxLength(200)]
    public string Header2 { get; set; }
    [Required, MinLength(200)]
    public string Descripton { get; set; }
}
