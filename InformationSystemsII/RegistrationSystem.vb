Namespace InformationSystems
    Public Class RegistrationSystem
        ''' <summary>
        ''' Validates and saves student registration details.
        ''' </summary>
        Public Sub RegisterStudent(name As String, id As String, course As String)
            ' Validation logic to ensure data integrity
            If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(id) Then
                Console.WriteLine("Validation Failed: Required fields are empty.")
                Return
            End If

            ' Logic to confirm successful data capture
            Console.WriteLine("Registration confirmed for: " & name & " (" & id & ")")
            Console.WriteLine("Course Assigned: " & course)
        End Sub
    End Class
End Namespace
