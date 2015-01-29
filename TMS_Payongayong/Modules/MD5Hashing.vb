Imports System.Security.Cryptography
Imports System.Text

Module MD5Hashing

    Public Function encryptHash(ByVal inString As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = enc.GetBytes(inString)
        encryptHash = Convert.ToBase64String(buffer)
    End Function

    Public Function decryptHash(ByVal inString As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = Convert.FromBase64String(inString)
        decryptHash = enc.GetString(buffer)
    End Function

End Module
