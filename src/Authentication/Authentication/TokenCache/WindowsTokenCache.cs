﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using System.IO;
    using System.Security.Cryptography;
    /// <summary>
    /// Contains methods to store, get and encrypt access tokens using Windows DPAPI in token cache file.
    /// </summary>
    internal static class WindowsTokenCache
    {
        /// <summary>
        /// Gets a decrypted token from the token cache.
        /// </summary>
        /// <param name="appId">The app/client id..</param>
        /// <returns>A decrypted access token.</returns>
        public static byte[] GetToken(string appId)
        {
            if (!Directory.Exists(Constants.TokenCacheDirectory))
                Directory.CreateDirectory(Constants.TokenCacheDirectory);

            string tokenCacheFilePath = Path.Combine(Constants.TokenCacheDirectory, $"{appId}cache.bin3");

            return File.Exists(tokenCacheFilePath) ?
                ProtectedData.Unprotect(
                    encryptedData: File.ReadAllBytes(tokenCacheFilePath),
                    optionalEntropy: null,
                    scope: DataProtectionScope.CurrentUser)
                : new byte[0];
        }

        /// <summary>
        /// Sets an encrypted access token to the token cache.
        /// </summary>
        /// <param name="appId">The app/client id..</param>
        /// <param name="plainContent">Plain access token to securely write to the token cache file.</param>
        public static void SetToken(string appId, byte[] plainContent)
        {
            if (!Directory.Exists(Constants.TokenCacheDirectory))
                Directory.CreateDirectory(Constants.TokenCacheDirectory);

            string tokenCacheFilePath = Path.Combine(Constants.TokenCacheDirectory, $"{appId}cache.bin3");

            File.WriteAllBytes(tokenCacheFilePath,
                ProtectedData.Protect(
                    userData: plainContent,
                    optionalEntropy: null,
                    scope: DataProtectionScope.CurrentUser));
        }

        /// <summary>
        /// Deletes an access token cache file/
        /// </summary>
        /// <param name="appId">The app/client id to delete its token cache file.</param>
        public static void DeleteToken(string appId)
        {
            string tokenCacheFilePath = Path.Combine(Constants.TokenCacheDirectory, $"{appId}cache.bin3");

            if (File.Exists(tokenCacheFilePath))
                File.Delete(tokenCacheFilePath);
        }
    }
}
