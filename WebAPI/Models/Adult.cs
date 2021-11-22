using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Models {
public class Adult : Person {
    
    [JsonPropertyName("JobTitle")]
    public Job JobTitle { get; set; }

    public Adult()
    {
        JobTitle = new Job();
    }
}
}