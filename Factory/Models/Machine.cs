using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SillyFactory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.EMJoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }

    [DisplayName("Department")]
    public string Dept { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    [DisplayName("Serial number")]
    public int Serial { get; set; }

    [DisplayName("Installation Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime InstDate { get; set; }

    public virtual ICollection<EngineerMachine> EMJoinEntities { get; }
  }
}