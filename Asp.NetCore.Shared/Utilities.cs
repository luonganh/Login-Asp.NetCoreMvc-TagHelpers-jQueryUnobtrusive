﻿namespace Asp.NetCore.Shared
{
    public static class Utilities
    {

        public class AppSettings
        {
            public const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";
            public const string ConnectionString = "DefaultConnection";

            public const string CorsPolicy = "CorsPolicy";
            public const string AccessUrls = "AccessUrls";
        }

        public class Role
        {
            public const string Admin = "Admin";
            public const string Rico = "Rico";
        }

        public class Username
        {
            public const string Administrator = "admin";
        }

        public class Password
        {
            public const string Administrator = "Alo12345$";
        }

        public class  FolderPath
        {
            
        }

        public class Characters
        {                       
            /// <summary>
            /// Non-alphanumeric characters
            /// </summary>
            public static readonly List<string> SpecialCharacter = new List<string>()
            {
                 "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "[", "}", "]", "|", "\\", ":", ";", "\"", "'", "<", ">", ",", ".", "?", "/"
            };

            public static readonly List<string> EscapeCharacters = new List<string>()
            {
                "\\", "\n", "\r", "\t", "\b"
            };
        }
    }
}
