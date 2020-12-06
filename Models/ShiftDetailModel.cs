using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shift_Picker_Api.Models
{
    public class ShiftDetailModel
    {
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public ShiftModel Shift { get; set; }
        public int PickedByEmployee { get; set; }

        public bool IsCancelRequest { get; set; }
    }
}
