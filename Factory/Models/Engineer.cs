using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SillyFactory.Models
{
  public class Engineer
  {
    
    public Engineer()
    {
      this.EMJoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }

    [DisplayName("Hire Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime HireDate { get; set; }

    [DisplayName("Certification Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime CertDate { get; set; }

    [DisplayName("Certification Number")]
    public int CertNum { get; set; }

    [DisplayName("Certification Expiration")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime CertExp { get; set; }

    public virtual ICollection<EngineerMachine> EMJoinEntities { get; set; }
  }
}