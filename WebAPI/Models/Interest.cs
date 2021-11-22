using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Models {
public class Interest {
    [Key]
    public int InterestID { get; set; }
    public string Type { get; set; }
    [JsonPropertyName("Description")]
    public string Description { get; set; }
}
}