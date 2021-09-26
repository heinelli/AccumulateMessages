'Elliot Heiner
'RCET 0265
'Fall 2021
'Accumulate Messages Function
'https://github.com/heinelli/AccumulateMessages.git

Option Explicit On
Option Strict On

Module AccumulateMessages

    Sub Main()
        Dim newMessage As String
        Dim clear As Boolean = False

        Console.WriteLine("Type a message here.")
        newMessage = Console.ReadLine()
        UserMessages(newMessage, clear)
        Console.WriteLine(UserMessages(newMessage, clear))
        Console.ReadLine()

    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Dim returnMessage As String = newMessage
        Return returnMessage
    End Function


End Module
