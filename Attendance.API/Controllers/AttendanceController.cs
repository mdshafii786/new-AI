using Microsoft.AspNetCore.Mvc;
using Attendance.API.Services;

namespace Attendance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AttendanceController : ControllerBase
{
    private readonly FaceRecognitionService _service;
    public AttendanceController(FaceRecognitionService service) => _service = service;

    [HttpPost("mark-attendance")]
    public async Task<IActionResult> MarkAttendance()
    {
        var student = await _service.IdentifyStudentAsync("image.jpg");
        return Ok(new { Student = student?.Name, Attendance = "Marked" });
    }
}