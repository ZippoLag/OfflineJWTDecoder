# OfflineJWTDecoder

This is just a quick and dirty wrapper for grabbing a JWT token string from commandline, decode it, parse it as JSON and print it in a lazily-formatted way. May be expanded in the future if time allows (to add validations, error messages, private key decoding, etc).


## Usage:

Call the OfflineJWTDecoder.exe followed by your token string, eg: _>./OfflineJWTDecoder.exe ey....0x