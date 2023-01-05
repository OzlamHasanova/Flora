using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class SlideBg
{
    public int Id { get; set; }
    [Required]
    public string Image { get; set; }

    //[NotMapped]
    //public int oZLEM { get; set; }

}
