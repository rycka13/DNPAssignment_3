using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Models {
public class Child : Person {
    
    public List<Interest> Interests { get; set; }
    [JsonPropertyName("Pets")]
    public List<Pet> Pets { get; set; }
}
}