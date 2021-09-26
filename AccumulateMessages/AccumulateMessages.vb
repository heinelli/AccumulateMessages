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
        Dim clearMessages As Boolean = False
        Dim storage As String
        Dim endLoop As Boolean

        'Display instructions for user.
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
                MsgBox(UserMessages(newMessage, clearMessages, storage))
            ElseIf newMessage = "C" Then
                Console.WriteLine("MESSAGES ERASED")
            Else
                UserMessages(newMessage, clearMessages, storage)
                storage = UserMessages(newMessage, clearMessages, storage)
            End If
        Loop
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean, ByVal storage As String) As String

        'Each string is added to previous string with carriage return
        Dim functionStorage As String = newMessage + vbNewLine + storage
        If newMessage = "C" Then
            functionStorage = ""
        ElseIf newMessage = "#display" Then
            functionStorage = storage
        End If
        Return functionStorage
    End Function
End Module
