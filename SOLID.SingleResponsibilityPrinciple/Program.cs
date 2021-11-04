// See https://aka.ms/new-console-template for more information
//public class GarageStation
//{
//    public void DoOpenGate()
//    {
//        //Open the gate functinality
//    }

//    public void PerformService(Vehicle vehicle)
//    {
//        //Check if garage is opened
//        //finish the vehicle service
//    }

//    public void DoCloseGate()
//    {
//        //Close the gate functinality
//    }
//}

/* We can correctly apply SRP by refactoring of above code by introducing interface */

public class GarageStation
{
    IGarageUtility _garageUtil;

    public GarageStation(IGarageUtility garageUtil)
    {
        this._garageUtil = garageUtil;
    }
    public void OpenForService()
    {
        _garageUtil.OpenGate();
    }
    public void DoService()
    {
        //Check if service station is opened and then
        //finish the vehicle service
    }
    public void CloseGarage()
    {
        _garageUtil.CloseGate();
    }
}
public class GarageStationUtility : IGarageUtility
{
    public void OpenGate()
    {
        //Open the Garage for service
    }

    public void CloseGate()
    {
        //Close the Garage functionlity
    }
}

public interface IGarageUtility
{
    void OpenGate();
    void CloseGate();
}