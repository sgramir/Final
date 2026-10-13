namespace MedicalDeviceCalibrationAPI.Models
{
    public class MedicalDevice
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; } = "";
        public DateTime CalibrationDate { get; set; }
        public DateTime NextCalibrationDate { get; set; }
        public string Technician { get; set; } = "";

        public bool IsCalibrationOverdue()
        {
            return NextCalibrationDate < DateTime.Today;
        }
    }
}
