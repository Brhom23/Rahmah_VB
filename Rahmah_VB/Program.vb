Imports System.Console
Imports System
Imports System.Runtime.CompilerServices

Module Program

    Sub Main(args As String())

        'Option Strict On
        'Function sum1(x1 As Int16, x2 As Int16) As Int16
        '    Return x1 + x2
        'End Function
        'WriteLine(sum1(4, 4.6))
        '' If Option Strict is on, this implicit narrowing
        '' conversion causes a compile-time error.
        '' The commented statements below use explicit
        '' conversions to avoid a compile-time error.
        'Dim cyclists As Long = 5
        'Dim bicycles As Integer = cyclists + 5
        'Dim bicycles1 As Integer = CType(cyclists, Integer)
        'Dim bicycles2 As Integer = CInt(cyclists)
        'Dim bicycles3 As Integer = Convert.ToInt32(cyclists)


        '' If Option Strict is on, this implicit narrowing
        '' conversion causes a compile-time error.
        '' The commented statements below use explicit
        '' conversions to avoid a compile-time error.
        'Dim charVal As Char = "a"
        'Dim charVal1 As Char = "a"c
        'Dim charVal2 As Char = CType("a", Char)


        '' If Option Strict is on, a compile-time error occurs.
        '' If Option Strict is off, the string is implicitly converted
        '' to a Double, and then is added to the other number.
        'Dim myAge As Integer = "34" + 6


        '' If Option Strict is on, a compile-time error occurs.
        '' If Option Strict is off, the floating-point number
        '' is implicitly converted to a Long.
        'Dim num = 123.45 \ 10
        '****************************************************************************


        'Dim x
        'x = 50
        'x = "ahm"

        'Dim fa2 As String = "Ibraheem " + "mostaf"
        'Dim b As Boolean
        'Dim by As Byte = 255
        'Dim sh As Short = 5555
        'Dim int = 2_147_483_648
        'Dim sb As SByte = -50
        'Dim f = 52_52_63212584

        'Dim bi As Integer = &B1101010
        'Dim hx = &HFFFFFF
        'WriteLine(hx)

        'Dim d As Date = #5/15/2020#

        'Dim d1 As Date = #2020-6-18 5:5#

        'WriteLine(d)
        'WriteLine($"{d:dd/MM/yyyy}")

        'WriteLine(d1)
        'WriteLine($"{d1:dd/MM/yyyy}")

        'WriteLine("Hello Rahmah " + fa2)
        'Dim ts As TimeSpan = TimeSpan.Parse("5:5")

        'WriteLine(3 < 2 Or 4 > 5)

        'WriteLine(SoundEx("ahmed"))
        'WriteLine(SoundEx("ahmad"))

        'WriteLine(SoundEx("ibrahim"))
        'WriteLine(SoundEx("ibraheem"))
        'WriteLine(SoundEx("ibraheen"), 0)

        'WriteLine(SoundEx("Ebraheen", 6))


        'WriteLine(SoundEx("ali"), 0)
        'WriteLine(SoundEx("aly"), 0)

        pSum(33, 55)
        Dim m1, m2 As Integer
        m1 = 33 : m2 = 55
        Write(m1)
        Write("    ")
        WriteLine(m2)
        swap(m1, m2)
        Write(m1)
        Write("    ")
        WriteLine(m2)

        swap(m1, m2)
        Write(m1)
        Write("    ")
        WriteLine(m2)


        Dim s1, s2 As String
        s1 = "ibraheem" : s2 = "mostafa"

        Write(s1)
        Write("    ")
        WriteLine(s2)
        swap(s1, s2)
        Write(s1)
        Write("    ")
        WriteLine(s2)



        Dim d1, d2 As Date
        d1 = #1969-6-13# : d2 = #2002-10-2#

        Write(d1)
        Write("    ")
        WriteLine(d2)
        swap(d1, d2)
        Write(d1)
        Write("    ")
        WriteLine(d2)


        WriteLine(-1, d1, "    ", d2)


    End Sub
    Sub swap(ByRef n1 As Object, n2 As Object)
        Dim nx = n1
        n1 = n2
        n2 = nx
    End Sub

    'Sub swap(ByRef n1 As Integer, ByRef n2 As Integer)
    '    Dim nx = n1
    '    n1 = n2
    '    n2 = nx
    'End Sub
    'Sub swap(ByRef n1 As String, ByRef n2 As String)
    '    Dim nx = n1
    '    n1 = n2
    '    n2 = nx
    'End Sub
    'Sub swap(ByRef n1 As Date, ByRef n2 As Date)
    '    Dim nx = n1
    '    n1 = n2
    '    n2 = nx
    'End Sub

    Function sum(n1 As Integer, n2 As Integer) As Integer
        Return n1 + n2
    End Function
    Function sum(n1 As Integer, n2 As Integer, n3 As Integer) As Integer
        Return n1 + n2 + n3
    End Function

    Sub pSum(n1 As Double, n2 As Double)
        WriteLine(sum(n1, n2))
    End Sub



    Public Function SoundEx(word As String, Optional kLength As Integer = 4) As String
        If kLength = 0 Then kLength = 4

        Dim value As String = ""

        Dim size As Integer = word.Length

        '// Make sure the word Is at least two characters in length
        If size > 1 Then
            word = word.ToUpper

            '// Convert the word to a character array for faster processing
            Dim chars() As Char = word.ToCharArray

            '// For storing the SoundEx character codes
            Dim code As New List(Of String)

            '// The current And previous character codes
            Dim prevCode As Integer = 0
            Dim currCode As Integer = 0

            '// Add the first character
            'code.Add(chars(0))

            Dim loopLimit As Integer = size - 1
            '// Loop through all the characters And convert them to the proper character code
            For i As Integer = 0 To loopLimit
                Select Case chars(i)
                    Case "H", "W"
                        currCode = -1
                    Case "A", "E", "I", "O", "U", "Y"
                        currCode = 0
                    Case "B", "F", "P", "V"
                        currCode = 1
                    Case "C", "G", "J", "K", "Q", "S", "X", "Z"
                        currCode = 2
                    Case "D", "T"
                        currCode = 3
                    Case "L"
                        currCode = 4
                    Case "M", "N"
                        currCode = 5
                    Case "R"
                        currCode = 6
                End Select

                If i > 0 Then
                    '// two letters With the same number separated by 'h' or 'w' are coded as a single number
                    If currCode = -1 Then currCode = prevCode

                    '// Check to see if the current code Is the same as the last one
                    If currCode <> prevCode Then
                        '// Check to see if the current code Is 0 (a vowel); do Not proceed
                        If currCode <> 0 Then
                            code.Add(currCode.ToString)
                        End If
                    End If
                End If

                prevCode = currCode

                '// If the buffer size meets the length limit, then exit the loop
                If code.Count - 1 = kLength - 1 Then
                    Exit For
                End If
            Next

            '// Pad the code if required
            size = code.Count
            For j As Integer = size To kLength - 1
                code.Add("0")
            Next

            '// Set the return value
            value = Join(code.ToArray, "")
        End If

        '// Return the computed soundex
        Return value
    End Function
End Module
