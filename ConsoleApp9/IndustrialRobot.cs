using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IndustrialRobot : RobotPrototype
{
    public string IndustrialTasklike;

    public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTasklike)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        this.IndustrialTasklike = industrialTasklike;
    }

    public override RobotPrototype Clone()
    {
        return new IndustrialRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.IndustrialTasklike);
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Industrial Robot: {modelName} | Battery: {batteryCapacity}h | Software: {softwareVersion} | Task: {IndustrialTasklike}");
    }
}
