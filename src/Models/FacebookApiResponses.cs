 
using Newtonsoft.Json;

namespace AngularASPNETCore2WebApiAuth.Models
{
  internal class FacebookUserData
  {
    public long Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Locale { get; set; }
    public FacebookPictureData Picture { get; set; }
  }

  internal class FacebookPictureData
  {
    public FacebookPicture Data { get; set; }
  }

  internal class FacebookPicture
  {
    public int Height { get; set; }
    public int Width { get; set; }
    [JsonProperty("is_silhouette")]
    public bool IsSilhouette { get; set; }
    public string Url { get; set; }
  }

  internal class FacebookUserAccessTokenData
  {
    [JsonProperty("app_id")]
    public long AppId { get; set; }
    public string Type { get; set; }
    public string Application { get; set; }
    [JsonProperty("expires_at")]
    public long ExpiresAt { get; set; }
    [JsonProperty("is_valid")]
    public bool IsValid { get; set; }
    [JsonProperty("user_id")]
    public long UserId { get; set; }
  }

  internal class FacebookUserAccessTokenValidation
  {
     public FacebookUserAccessTokenData Data { get; set; }
  }

  internal class FacebookAppAccessToken
  {
    [JsonProperty("token_type")]
    public string TokenType { get; set; }
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }
  }
}
