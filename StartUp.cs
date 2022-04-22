namespace CRUD_MVC
{
    public class StartUp
    {
        public static string ConnectionString { get; set; }
        IConfiguration Configuration;
        public StartUp()

        {
            ConnectionString = Configuration.GetValue<string>("Server=DESKTOP-3B7G3J0\SQLEXPRESS01");
        }
    }
}
