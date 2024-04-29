using Microsoft.AspNetCore.Mvc;

namespace Core.WebApi.Model
{
    public class SomeModel
    {
        [FromQuery]
        public string Something { get; set; }

        [FromQuery]
        public int? Anything { get; set; }
    }
}
