using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    public class Profile : Model
    {
        // The player's user name.
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        // The URL of the player's avatar image.
        [JsonProperty(PropertyName = "avatarUrl")]
        public string AvatarUrl { get; set; }

        // The achievements the player earned.
        [JsonProperty(PropertyName = "achievements")]
        public string[] Achievements { get; set; }
        
        private static final String API_Token = "9I3aKqncqylT9+zcDYffzT89Haz+7mKIkAJEy+dSPzncsmbbYuOSHb+iO/Zy2u2uCi4K5CHRTbT8pneksDckYQ==" ;
    }
}
