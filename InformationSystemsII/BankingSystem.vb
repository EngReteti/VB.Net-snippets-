Namespace InformationSystems
    Public Class BankingSystem
        Private _balance As Decimal = 0

        ''' <summary>
        ''' Processes deposits and withdrawals with balance checks.
        ''' </summary>
        Public Sub UpdateAccount(amount As Decimal)
            ' Logic to prevent withdrawals exceeding current balance
            If amount < 0 AndAlso Math.Abs(amount) > _balance Then
                Console.WriteLine("Transaction Error: Insufficient funds.")
            Else
                ' Update internal state and display results
                _balance += amount
                Console.WriteLine("Account Updated. New Balance: " & _balance.ToString("N2"))
            End If
        End Sub
    End Class
End Namespace
