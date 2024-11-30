using System.Text.Json.Serialization;
using Kpoper.DTOs;
using Microsoft.AspNetCore.Routing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kpoper.Entities
{

    public class Idol
    {        
        public int Id { get; set; }
        public string? Profile { get; set; }
        [JsonPropertyName("Stage Name")]
        public string? StageName { get; set; }
        [JsonPropertyName("Full Name")]
        public string? FullName { get; set; }
        [JsonPropertyName("Korean Name")]
        public string? KoreanName { get; set; }
        [JsonPropertyName("K.Stage Name")]
        public string? KoreanStageName { get; set; }

        [JsonPropertyName("Date of Birth")]
        public string? DateofBirth { get; set; }

        //[JsonPropertyName("Group")]
        public string? Group { get; set; }
        public string? Country { get; set; }

        [JsonPropertyName("Second Country")]
        public string? SecondCountry { get; set; }
        
        public int? Height {  get; set; }
        public int? Weight { get; set; }

        public string? Birthplace { get; set; }

        [JsonPropertyName("Other Group")]
        public string? OtherGroup { get; set; }

        [JsonPropertyName("Former Group")]
        public string? FormerGroup { get; set; }

        public string? Gender { get; set; }

        public string? Position { get; set; }
        public string? Instagram { get; set; }
        public string? Twitter { get; set; }
        
        
              
        public override string ToString()


//Profile":"https://dbkpop.com/idol/j-hope-bts/","Stage Name":"J-Hope","Full Name":"Jung Hoseok",
//"Korean Name":"정호석","K. Stage Name":"제이홉","Date of Birth":"1994-02-18","Group":"BTS",
//"Country":"South Korea","Second Country":null,"Height":"177","Weight":"65","Birthplace":"Gwangju",
//"Other Group":null,"Former Group":null,//"Gender":"M","Position":null,"Instagram":null,"Twitter":null}],"count":1
        {
            return Convert.ToString(Id) + " " + Profile+ " " + StageName + " " + FullName +
                " " + KoreanName + " " + KoreanStageName + " " + DateofBirth + " " + Group +
                " " + Country + " " + SecondCountry + Convert.ToString(Height)+Convert.ToString(Weight)
                + " " + Birthplace + " " + OtherGroup + " " + FormerGroup + " " + Gender
                + " " + Position + " " + Instagram + " " + Twitter;
        }
    }
} 