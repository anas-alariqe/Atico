using System.Collections.Generic;
public class Contact_Us_Data 
{

    public Contact_Us_Data()
    {
      
    }
    public Contact_Us_Data(WorkTime _Wrk_Times, string _tel, string _loc)
    {
        WorkTimes = _Wrk_Times;
        Tel_Num.Add( _tel);
        Locations.Add( _loc);
    }

    public WorkTime WorkTimes { get; set; } = new();
    public List<string> Tel_Num { get; set; }  = new();
    public List<string> Locations { get; set; }  = new();


}