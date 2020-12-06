using Shift_Picker_Api.Models;
using System;
using System.Collections.Generic;

namespace Shift_Picker_Api.Services
{
    /// <summary>
    /// Abstraction of Shift Service
    /// </summary>
    public interface IShiftService
    {
        ShiftModel AddShift(ShiftModel Shift);
        void DeleteShift(int id);
        List<ShiftModel> GetShiftsForDateRange(DateTime startDateTime, DateTime endDateTime);
        void UpdateShift(ShiftModel Shift);

        List<ShiftModel> GetAllShifts();
    }
}