namespace FirstWebApiProj.Models
{
    public class ServiceResponsive<T> //T is the actual type of data
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;
       
        public string Message { get; set; } = null;
       
    }
}
