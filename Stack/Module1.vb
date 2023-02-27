Module Module1
    Dim Stack(10) As Integer
    Dim Response, StackPointer As Integer
    Dim Parameter As String

    Sub Main()
        StackPointer = 0
        While Response > -1
            Console.WriteLine("What operation would you like to perform?")
            Console.WriteLine("Enter 0 to Push")
            Console.WriteLine("Enter 1 to Pop")
            Console.WriteLine("Enter 2 to view contents of the stack")
            Console.WriteLine("Enter -1 to exit")
            Response = Console.ReadLine
            If Response = 0 Then
                Console.WriteLine("Enter data to push")
                Parameter = Console.ReadLine
                Call Push()
            End If
            If Response = 1 Then
                Call Pop()
            End If
            If Response = 2 Then
                Call Output()
            End If
        End While
        Console.ReadKey()
    End Sub

    Function Push()
        StackPointer = StackPointer + 1
        If StackPointer > 10 Then
            Console.WriteLine("Stack is full, please use the pop function to free up space.")
        Else
            Stack(StackPointer) = Parameter
            Console.WriteLine("Operation completed successfully.")
        End If
        Return StackPointer 
    End Function

    Function Pop()
        If StackPointer > 0 Then
            StackPointer = StackPointer - 1
            Console.WriteLine("Operation completed successfully.")
        Else
            Console.WriteLine("Unable to pop as the stack is empty, please use the push function")
        End If
        Return StackPointer
    End Function

    Sub Output()
        If StackPointer > 0 Then
            For Counter = 0 To StackPointer
                Console.WriteLine(Stack(Counter))
            Next
            Console.WriteLine("Operation completed successfully")
        Else
            Console.WriteLine("Stack is empty, please use the push function.")
        End If
    End Sub

End Module
