Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim num3 As Integer
    Dim op As Double
    Private Sub InventarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InventarioDataSet)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventarioDataSet.Inventario' table. You can move, or remove it, as needed.
        Me.InventarioTableAdapter.Fill(Me.InventarioDataSet.Inventario)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InventarioBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InventarioBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InventarioBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InventarioBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        InventarioBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        InventarioBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            InventarioBindingSource.EndEdit()
            InventarioTableAdapter.Update(InventarioDataSet)
        Catch ex As Exception
            MsgBox("Error en la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num1 = Entrada.Text
        num2 = StockTextBox.Text
        op = num1 + num2
        StockTextBox.Text = op
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        num3 = Salida.Text
        num2 = StockTextBox.Text
        op = num2 - num3
        StockTextBox.Text = op
    End Sub
End Class
