using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Graph.Models;

namespace PMApplication.Helpers
{
    internal class UserHelper
    {
        public async Task<User?> GetUserIfExists(GraphServiceClient graphClient, string userEmail)
        {
            var userCollection = await graphClient.Users
                .GetAsync(requestConfiguration => requestConfiguration.QueryParameters.Filter = $"userPrincipalName eq '{userEmail}'");
            return userCollection?.Value?.FirstOrDefault();
        }
    }
}
