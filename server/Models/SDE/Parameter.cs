using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sde3.Models.Sde
{
  [Table("Parameter", Schema = "Extract")]
  public partial class Parameter
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ParameterId
    {
      get;
      set;
    }
    public int ExtractId
    {
      get;
      set;
    }
    public Extract Extract { get; set; }
    public string Name
    {
      get;
      set;
    }
    public string Alias
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
  }
}
