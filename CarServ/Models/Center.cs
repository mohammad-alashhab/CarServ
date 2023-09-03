namespace CarServ.Models
{
    public enum Center
    {
        NewYork,
        LosAngeles,
        Chicago,
        Miami,
        Houston,
        SanFrancisco,
        Boston,
        Seattle,
        Dallas,
        Atlanta

    }

    public enum Services
    {
        OilChange,          // Oil Change
        BrakeRepair,        // Brake Repair
        EngineTuneUp,       // Engine Tune-Up
        TransmissionRepair, // Transmission Repair
        TireRotation,       // Tire Rotation
        ACRepair,           // AC Repair
        WheelAlignment,     // Wheel Alignment
        BatteryReplacement, // Battery Replacement
        CarDetailing,       // Car Detailing
        PaintProtection,    // Paint Protection
    }


    /*
      <select class="form-select border-0" style="height: 55px;">
                                        <option selected>Select A Service</option>
                                        <option value="1">Service 1</option>
                                        <option value="2">Service 2</option>
                                        <option value="3">Service 3</option>
                                    </select>
     
     
     
     
     */
}
