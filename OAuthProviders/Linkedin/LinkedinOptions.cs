using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;

namespace Nivatech.Framework.OAuthProviders.LinkedIn
{
    public class LinkedInOptions : OAuthOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedInOptions"/> class.
        /// </summary>
        public LinkedInOptions()
        {
            this.CallbackPath = new PathString("/signin-linkedin");
            this.AuthorizationEndpoint = LinkedInDefaults.AuthorizationEndpoint;
            this.TokenEndpoint = LinkedInDefaults.TokenEndpoint;

            this.UserInformationEndpoint = LinkedInDefaults.UserInformationEndpoint;
            this.Scope.Add("r_basicprofile");
            this.Scope.Add("r_emailaddress");

            this.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id", ClaimValueTypes.String);
            this.ClaimActions.MapJsonKey(ClaimTypes.Name, "formattedName", ClaimValueTypes.String);
            this.ClaimActions.MapJsonKey(ClaimTypes.Email, "emailAddress", ClaimValueTypes.Email);
            this.ClaimActions.MapJsonKey("picture", "pictureUrl", ClaimValueTypes.String);
        }
    }
}