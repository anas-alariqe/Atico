public class WorkTime 
{

    public WorkTime()
    {
      
    }
    public WorkTime(TimeOnly _from, TimeOnly _to, WorkDay_Enum _wrk_day, string _wrk_day_name= "")
    {
        WorkTimeTitle = _wrk_day_name;
        From = _from;
        To = _to;
        WorkDay = _wrk_day;
    }

    public TimeOnly From { get; set; } = new TimeOnly( 8,00);
    public TimeOnly To { get; set; }  = new TimeOnly( 20,00);
    public WorkDay_Enum  WorkDay{ get; set; } = WorkDay_Enum.None;
    public string WorkTimeTitle{ get; set; } = "";
    public override string ToString(){
        return $" {From.ToString("hh tt",System.Globalization.CultureInfo.InvariantCulture)} - {To.ToString("hh tt",System.Globalization.CultureInfo.InvariantCulture)} ";
    }

}
[Flags]
public enum WorkDay_Enum{
    None = 0,       // 0000 0000
    Sat = 1 << 0,   // 0000 0001
    Sun = 1 << 1 ,  // 0000 0010
    Mon = 1 << 2,   // 0000 0100
    Thr = 1 << 3,   // 0000 1000
    Wnd = 1 << 4,   // 0001 0000
    Tue = 1 << 5,   // 0010 0000
    Frd = 1 << 6,   // 0100 0000
    ALL = Sat | Sun | Mon | Thr | Wnd | Tue | Frd,  // 0111 1111
    Work_Day = Sat | Sun | Mon | Thr | Wnd | Tue,   // 0011 1111
}