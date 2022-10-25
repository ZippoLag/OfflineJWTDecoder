/************************************
#OfflineJWTDecoder

This is just a quick and dirty wrapper for grabbing a JWT token string from commandline, decode it, parse it as JSON and print it in a lazily-formatted way. May be expanded in the future if time allows (to add validations, error messages, private key decoding, etc).


## Usage:

Call the OfflineJWTDecoder.exe followed by your token string, eg: _>./OfflineJWTDecoder.exe ey....0x
*************************************/

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

Console.WriteLine("Attempting to extract JSON content from provided token string..\n");

JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
SecurityToken jsonToken = handler.ReadToken(args[0]);

Console.WriteLine(
    jsonToken.ToString()
        .Replace("{", "\n{\n")
        .Replace("}", "\n}\n")
        .Replace("\",\"", "\",\n\"")
);