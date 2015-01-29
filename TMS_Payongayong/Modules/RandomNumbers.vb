Imports System.Text

Module RandomNumbers

    Public Function GetRandomString(ByVal length As Integer) As String
        'use the following string to control your set of alphanumeric characters to choose from
        'you could also include lowercase or punctuation too
        Const alphabet As String = "0123456789"

        Dim result As New StringBuilder(length)

        ' Random is not truly random,
        ' so we try to encourage better randomness by using a seed value
        Static rnd As New Random(Convert.ToInt32(DateTime.Now.Ticks And Integer.MaxValue))
        Dim prevChar As String = String.Empty
        Dim nextChar As String
        Do While result.Length < length
            nextChar = alphabet.Substring(rnd.[Next](0, alphabet.Length), 1)
            If nextChar.Equals(prevChar) = False Then
                result.Append(nextChar)
                prevChar = nextChar
            End If
        Loop

        Return result.ToString

    End Function

End Module
