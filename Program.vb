Imports System
Imports System.Diagnostics.CodeAnalysis
Imports System.Runtime.Intrinsics.X86

Module Program
    Sub main(args As String())
        Dim dec As Decimal
        Dim dbl As Double
        Dim sdl As Single
        Dim int As Integer
        dec = 12345678912345.109
        dbl = 0.0345
        sdl = 0.004
        int = 0.0029
        Console.WriteLine("disimal{0}", dec)
        Console.WriteLine("double{0}", dbl)
        Console.WriteLine("single{0}", sdl)
        Console.WriteLine("integer{0}", int)
        Dim sum As String
        Console.WriteLine("введите сумму в kопейках")
        sum = Console.ReadLine
        Dim rub As Decimal
        rub = sum
        rub = CSng(sum) / 100
        Dim te As Single
        te = sum Mod 100
        Console.WriteLine(te)




    End Sub
End Module
