'Owen Fujii
'RCET 2265
'Spring 2024
'Convert and Validate
'https://github.com/Masaharu41/Convert-and-Validate.git

Option Explicit On
Option Strict On
Option Compare Text
Module ConvertandValidate

    Sub Main()

        'Convert the user inputed string to a integer and validates the converstion

        Dim aValidNumber As Integer

        Do
            Dim usernResponse As String
            Console.WriteLine("Press q at anytime to leave")
            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()
            If usernResponse = "q" Then
                Exit Do
            Else
                If ConversionValid(usernResponse, aValidNumber) = True Then

                    Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

                Else

                    Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

                End If
            End If
        Loop
        Console.WriteLine("Have a Nice Day!")
        Console.Read()
    End Sub


    ''' <summary>
    ''' Funtion that takes the user input and completes convertion
    ''' while returning a boolean statement for failed or passed convertions
    ''' </summary>
    ''' <param name="convertThisString$"></param>
    ''' <param name="toThisInteger%"></param>
    ''' <returns></returns>
    Function ConversionValid(convertThisString$, ByRef toThisInteger%) As Boolean

        Dim status As Boolean

        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try
        Return status

    End Function

End Module
