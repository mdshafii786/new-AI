using Attendance.Core.Models;
namespace Attendance.API.Services;
public class FaceRecognitionService
{
    public async Task<Student?> IdentifyStudentAsync(string imagePath)
    {
        await Task.Delay(100);
        return new Student { Id = 1, Name = "Demo Student" };
    }
}