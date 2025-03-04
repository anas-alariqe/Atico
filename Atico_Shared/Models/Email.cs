public class Email :Account
{
    public Email(){

    }
    public Email(string _name,string _email,string _msg ){
        this.Customer_Name = _name;
        this.Email_Account = _email;
        this.Message = _msg;
        this.Msg_Date_time = DateTime.Now; 
    }
    public string Customer_Name { get; set; } = string.Empty;
    public string Email_Account { get; set; }= string.Empty;
    public string Message { get; set; }= string.Empty;
    public DateTime Msg_Date_time { get; set; }= new();

}