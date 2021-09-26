'Elliot Heiner
'RCET 0265
'Fall 2021
'Accumulate Messages Function
'https://github.com/heinelli/AccumulateMessages.git

Option Explicit On
Option Strict On
Option Compare Text

Module AccumulateMessages

    Sub Main()
        Dim newMessage As String
        Dim clear As Boolean = False
        Dim storage As String
        Dim endLoop As Boolean



        Do While endLoop = False

            If newMessage = "q" Then
                endLoop = True
            Else
                Console.WriteLine("Type a message here. Press C to clear stored messages. Press Q to terminate program")
                newMessage = Console.ReadLine()
                UserMessages(newMessage, clear, storage)
                Console.WriteLine(UserMessages(newMessage, clear, storage))
                storage = UserMessages(newMessage, clear, storage)
            End If
        Loop


    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean, ByVal storage As String) As String

        Dim functionStorage As String = newMessage + vbNewLine + storage

        If newMessage = "C" Then
            functionStorage = ""
        End If

        Return functionStorage
    End Function


End Module
