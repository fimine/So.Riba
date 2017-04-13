using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CrossOver.RIBA.Data.Models
{
    public class BaseModel
    {
		[Timestamp]
		public byte[] RowVersion { get; set; }
    }
}
