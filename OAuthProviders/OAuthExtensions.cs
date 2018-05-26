using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Nivatech.Framework.OAuthProviders.GitHub;
using Nivatech.Framework.OAuthProviders.LinkedIn;

namespace Nivatech.Framework.OAuthProviders
{
    public static class OAuthExtension
    {
        /// <summary>
        /// Adds the LinkedIn oAuth provider
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="linkedinOptions">The GitHub options.</param>
        /// <returns></returns>
        public static AuthenticationBuilder AddGitHub(this AuthenticationBuilder builder, Action<GitHubOptions> githubOptions)
        {
            return builder.AddOAuth<GitHubOptions, GitHubHandler>("GitHub", githubOptions);
        }

        /// <summary>
        /// Adds the LinkedIn oAuth provider
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="linkedinOptions">The LinkedIn options.</param>
        /// <returns></returns>
        public static AuthenticationBuilder AddLinkedin(this AuthenticationBuilder builder, Action<LinkedInOptions> linkedinOptions)
        {
            return builder.AddOAuth<LinkedInOptions, LinkedinHandler>("LinkedIn", linkedinOptions);
        }
    }
}