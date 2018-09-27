using System;
using System.Collections.Generic;
using System.Text;

namespace Slots.Models
{
    public class Response
    {
        public decimal WinAmount { get; set; }
        public string Transaction { get; set; }
        public string SlotResult { get; set; }
    }
}
