namespace Kpoper.Webapiclass
{
    public class WebIdol
    {
        public int id { get; set; }
        public string? name { get; set; }
        public bool idolSex { get; set; }
        public int idolLinks { get; set; }
    }
    public class WebIdols
    {
        public List<WebIdol> data { get; set; }
        public bool success { get; set; }
    }
}
