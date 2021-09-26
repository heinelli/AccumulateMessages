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

        MsgBox("*Type a message to store for later.
*Type C to clear stored messages.
*Type #display to see stored messages.
*Type Q to terminate program.")

        Do While endLoop = False
            Console.WriteLine("Type a message here.")
            newMessage = Console.ReadLine()
            If newMessage = "q" Then
                endLoop = True
            ElseIf newMessage = "#display" Then
                MsgBox(UserMessages(newMessage, clear, storage))
            Else
                UserMessages(newMessage, clear, storage)
                storage = UserMessages(newMessage, clear, storage)
            End If
        Loop


    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean, ByVal storage As String) As String

        Dim functionStorage As String = newMessage + vbNewLine + storage

        If newMessage = "C" Then
            functionStorage = ""
        ElseIf newMessage = "#display" Then
            functionStorage = storage
        End If

        Return functionStorage
    End Function


End Module
