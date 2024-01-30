'Owen Fujii
'RCET 2265
'Spring 2024
'Convert and Validate
'

Option Explicit On
Option Strict On
Module ConvertandValidate

    Sub Main()

        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer

        Do
            Dim usernResponse As String

            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()

            If ConversionValid(usernResponse, aValidNumber) = True Then

                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

            End If

        Loop

    End Sub
    'make this work


    Function ConversionValid(convertThisString, toThisInteger) As Boolean

        Dim status As Boolean

        Try

        Catch ex As Exception

        End Try

        Return status

    End Function

End Module
