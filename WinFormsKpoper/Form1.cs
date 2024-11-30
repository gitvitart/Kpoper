using System.Net.Http.Headers;
namespace WinFormsKpoper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://k-pop.p.rapidapi.com/idols/random"),
                Headers =
    {
        { "x-rapidapi-key", "dfc49f9a67mshc5ebc5f88ae5491p173298jsn8a1748ca8bf3" },
        { "x-rapidapi-host", "k-pop.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            MessageBox.Show("Kpoper 1.0\nWritten by:Vitaly", "About");
        }

    }
}
