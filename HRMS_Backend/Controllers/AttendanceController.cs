using BusinessLayer.DTOs;
using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IShiftAllocationService _shiftAllocationService;
        public AttendanceController(IShiftAllocationService shiftAllocationService)
        {
            
            _shiftAllocationService = shiftAllocationService;

        }
        #region ShiftAllocation

        [HttpGet("GetAllShifts")]
        public async Task<IActionResult> GetAllShifts()
        {
            var data = await _shiftAllocationService.GetAllShiftsAsync();
            return Ok(data);
        }

        [HttpGet("GetShiftById/{shiftId}")]
        public async Task<IActionResult> GetShiftById(int shiftId)
        {
            var result = await _shiftAllocationService.GetShiftByIdAsync(shiftId);
            if (result == null) return NotFound("Shift not found");
            return Ok(result);
        }

        [HttpPost("AddShift")]
        public async Task<IActionResult> AddShift([FromBody] ShiftMasterDto dto)
        {
            var status = await _shiftAllocationService.AddShiftAsync(dto);
            return status ? Ok("Shift added successfully") : BadRequest("Failed to add shift");
        }

        [HttpPut("UpdateShift")]
        public async Task<IActionResult> UpdateShift([FromBody] ShiftMasterDto dto)
        {
            var status = await _shiftAllocationService.UpdateShiftAsync(dto);
            return status ? Ok("Shift updated successfully") : NotFound("Shift not found");
        }

        [HttpDelete("DeleteShift/{shiftId}")]
        public async Task<IActionResult> DeleteShift(int shiftId)
        {
            var status = await _shiftAllocationService.DeleteShiftAsync(shiftId);
            return status ? Ok("Shift deleted successfully") : NotFound("Shift not found");
        }

        [HttpPut("ActivateShift/{shiftId}")]
        public async Task<IActionResult> ActivateShift(int shiftId)
        {
            var status = await _shiftAllocationService.ActivateShiftAsync(shiftId);
            return status ? Ok("Shift activated") : NotFound("Shift not found");
        }

        [HttpPut("DeactivateShift/{shiftId}")]
        public async Task<IActionResult> DeactivateShift(int shiftId)
        {
            var status = await _shiftAllocationService.DeactivateShiftAsync(shiftId);
            return status ? Ok("Shift deactivated") : NotFound("Shift not found");
        }


        // ===========================================================
        //                  SHIFT ALLOCATION API
        // ===========================================================

        [HttpGet("GetAllAllocations")]
        public async Task<IActionResult> GetAllAllocations()
        {
            var list = await _shiftAllocationService.GetAllAllocationsAsync();
            return Ok(list);
        }

        [HttpGet("GetAllocationById/{id}")]
        public async Task<IActionResult> GetAllocationById(int id)
        {
            var result = await _shiftAllocationService.GetAllocationByIdAsync(id);
            if (result == null) return NotFound("Allocation not found");
            return Ok(result);
        }

        [HttpPost("AllocateShift")]
        public async Task<IActionResult> AllocateShift([FromBody] ShiftAllocationDto dto)
        {
            var status = await _shiftAllocationService.AllocateShiftAsync(dto);
            return status ? Ok("Shift allocated successfully") : BadRequest("Failed to allocate shift");
        }

        [HttpPut("UpdateAllocation")]
        public async Task<IActionResult> UpdateAllocation([FromBody] ShiftAllocationDto dto)
        {
            var status = await _shiftAllocationService.UpdateAllocationAsync(dto);
            return status ? Ok("Allocation updated successfully") : NotFound("Allocation not found");
        }

        [HttpDelete("DeleteAllocation/{id}")]
        public async Task<IActionResult> DeleteAllocation(int id)
        {
            var status = await _shiftAllocationService.DeleteAllocationAsync(id);
            return status ? Ok("Allocation deleted") : NotFound("Allocation not found");
        }





        #endregion
    }
}
