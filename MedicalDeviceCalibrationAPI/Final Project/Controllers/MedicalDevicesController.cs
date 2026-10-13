using Microsoft.AspNetCore.Mvc;
using MedicalDeviceCalibrationAPI.Models;

namespace MedicalDeviceCalibrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalDevicesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDevice()
        {
            MedicalDevice device = new MedicalDevice
            {
                DeviceID = 101,
                DeviceName = "Digital Caliper",
                CalibrationDate = new DateTime(2026, 8, 15),
                NextCalibrationDate = new DateTime(2027, 8, 15),
                Technician = "Lab Technician"
            };

            return Ok(new
            {
                device.DeviceID,
                device.DeviceName,
                device.CalibrationDate,
                device.NextCalibrationDate,
                device.Technician,
                CalibrationStatus = device.IsCalibrationOverdue()
                    ? "Overdue"
                    : "Current"
            });
        }
    }
}
