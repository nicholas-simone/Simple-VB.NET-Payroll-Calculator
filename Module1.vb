Option Explicit On
Option Strict On
Module PayrollReport

    Sub Main()
        Dim name As String
        Dim grossString As String
        Dim employeeNumber As String
        Dim bonusString As String
        Dim gross, deduct, net, bonus As Double
        Const RATE As Double = 0.25
        Const QUIT As String = "XXX"
        Const REPORT_HEADING As String = "Payroll Report"
        Const END_LINE As String = "**End of report"

        System.Console.WriteLine(REPORT_HEADING)
        name = InputBox$("Enter employee's name: ")
        While (name <> QUIT)
            employeeNumber = InputBox$("Enter the employee's number: ")
            grossString = InputBox$("Enter employee's gross pay: ")
            bonusString = InputBox$("Enter the bonus amount: ")
            bonus = Convert.ToDouble(bonusString)
            gross = Convert.ToDouble(grossString)
            deduct = gross * RATE
            net = gross + bonus - deduct
            System.Console.WriteLine("Name: " & name)
            System.Console.WriteLine("Employee Number: " & employeeNumber)
            System.Console.WriteLine("Gross Pay: " & gross)
            System.Console.WriteLine("Deductions: " & deduct)
            System.Console.WriteLine("Net Pay: " & net)
            System.Console.WriteLine("Bonus: " & bonus)
            name = InputBox$("Enter employee's name: ")
        End While

        System.Console.WriteLine(END_LINE)
    End Sub

End Module
