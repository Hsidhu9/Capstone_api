using Shift_Picker_Api.Models;
using System.Collections.Generic;

namespace Shift_Picker_Api.Services
{
    /// <summary>
    /// Abstraction of Shift Detail Service
    /// </summary>
    public interface IShiftDetailService
    {
        void AddShiftDetail(ShiftDetailModel ShiftDetail);
        void CancelShiftDetail(ShiftDetailModel shiftDetail);
        void DeleteShiftDetail(ShiftDetailModel shiftDetail);
        List<ShiftModel> GetAllShifts();
        List<ShiftDetailModel> GetAllShiftsForEmployee(int employeeId);
        ShiftDetailModel GetShiftDetail(int Id);
        void UpdateShiftDetail(ShiftDetailModel ShiftDetail);
    }
}