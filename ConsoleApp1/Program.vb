Imports System
Imports RollDice.Roll REM to call the rollEm() method from the C# class in the RollDice.dll file.
Module Program
    Sub Main(args As String())
        Dim num As Integer
        num = rollEm()
        Console.WriteLine("Hello World! The number is " & num)
    End Sub
End Module
