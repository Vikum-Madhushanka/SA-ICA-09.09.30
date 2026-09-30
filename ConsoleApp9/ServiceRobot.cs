using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ServiceRobot : RobotPrototype
{
    public string ServiceTask;

    public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        this.ServiceTask = serviceTask;
    }

    public override RobotPrototype Clone()
    {
        return new ServiceRobot(this.modelName, this.batteryCapacity, this.softwareVersion, this.ServiceTask);
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Service Robot: {modelName} | Battery: {batteryCapacity}h | Software: {softwareVersion} | Task: {ServiceTask}");
    }
}
