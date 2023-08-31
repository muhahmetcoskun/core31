using System;
using System.Collections.Generic;

namespace Entities.Models.MSSQLEntities
{
    public partial class ReasonForJobHistory
    {
        public int SafahatGerekceId { get; set; }
        public string? SafahatGerekcesi { get; set; }
        public byte? Durum { get; set; }
    }
}
