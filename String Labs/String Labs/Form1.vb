Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Madlib
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Fill in the blanks 1
        Dim quote As String
        quote = "How you spend your days is how you spend your life."

        'Find the index of the word "How" and add it to the ListBox (I'll demonstrate the first one)
        Dim index1 As Integer
        index1 = quote.indexOf("How")
        Listbox1.items.add(index1)

        'Find the index of the word "how" (note the lowercased 'h') and add it to the ListBox 
        
        'Find the index of the period and add it to the ListBox

        'Find the index of thw word "your" and add it to the ListBox

        'Find the index where "your" last appears and add it to the ListBox

        'Find the index where "zebra" appears and add it to the ListBox 


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Email

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Fill in the blanks 2
        Dim quote As String
        quote = "Failure is not the opposite of success, it's part of it."

        Dim result1, result2, result3, result4, result5, result6 As String
        
        'Extract and print "Failure" (I'll dmonstrate this one)
        result1 = quote.Substring(0, 7)
        ListBox1.Items.Add(result1)

        'Extract and print "is"
        'result2 =
        ListBox1.Items.Add(result2)

        'Extract and print "part"
        'result3 =
        ListBox1.Items.Add(result3)

        'Extract and print "of"
        'result4 = 
        ListBox1.Items.Add(result4)

        'Extract and print "success"
        'result5 = 
        ListBox1.Items.Add(result5)
        
        'Extract and print "."
        'result6 = 
        ListBox1.Items.Add(result6)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Username 

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Word Count

    End Sub
End Class
