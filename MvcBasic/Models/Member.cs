using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBasic.Models
{
  public class Member
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birth { get; set; }
    public string Coment { get; set; }
  }
}