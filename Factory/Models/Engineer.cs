using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The Engineer's name can't be empty!")]
    public string Name { get; set; }
    public string EnginDetails { get; set; }
    public Machine Machine { get; set; }
    public List<Machine> Machines { get; set; }
    public List<MachineEngineer> JoinEntities { get;}
  }
}