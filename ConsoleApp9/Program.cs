using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceRobot medicalBase = new ServiceRobot("Lovable", 12, "v1.0", "Assisting Achchila");
        medicalBase.DisplayDetails();

        ServiceRobot customizedCareBot = (ServiceRobot)medicalBase.Clone();
        customizedCareBot.batteryCapacity = 18;
        customizedCareBot.softwareVersion = "v1.1-Beta";
        customizedCareBot.DisplayDetails();

        IndustrialRobot welderBase = new IndustrialRobot("ForgeMaster-X", 10, "v3.4", "Automated Welding");
        welderBase.DisplayDetails();

        IndustrialRobot updatedWelder = (IndustrialRobot)welderBase.Clone();
        updatedWelder.softwareVersion = "v3.5-Patch1";
        updatedWelder.DisplayDetails();

        EntertainmentRobot hostBase = new EntertainmentRobot("Chamath_Bot", 6, "v2.0", "Telling Jokes");
        hostBase.DisplayDetails();

        EntertainmentRobot highCapacityHost = (EntertainmentRobot)hostBase.Clone();
        highCapacityHost.batteryCapacity = 15;
        highCapacityHost.DisplayDetails();
    }
}
