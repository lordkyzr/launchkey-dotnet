﻿namespace iovation.LaunchKey.Sdk.Client
{
    /// <summary>
    /// Object that represents an authorization request
    /// </summary>
    public class AuthorizationRequest
    {
        public AuthorizationRequest(string id, string pushPackage)
        {
            Id = id;
            PushPackage = pushPackage;
        }

        /// <summary>
        /// Unique identifier for the authorization request generated by the LaunchKey API.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Push package to be sent to Devices when managing your own Device push notifications.
        /// </summary>
        public string PushPackage { get; }
    }
}
