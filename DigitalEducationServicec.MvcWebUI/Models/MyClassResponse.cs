namespace DigitalEducationServicec.MvcWebUI.Models
{
    public class MyClassResponse
    {
        public int statusCode { get; set; }
        public Meta meta { get; set; }
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public List<MyClass> data { get; set; }
    }
    public class Meta
    {
        public int count { get; set; }
    }
}
