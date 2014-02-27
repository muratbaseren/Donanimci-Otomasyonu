#Region "imports"
Imports PureComponents.NicePanel
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class fmOrderer

#Region "Yerel Degiskenler"
    Private myConn As OleDbConnection
    Private myCmd As OleDbCommand
    Private myDR As OleDbDataReader

    Private Toplam As Single
    Private Dolar As Single
#End Region

#Region "Metotlar"
    'Sipariþ listesine eklenen ürünlerin toplamýný almak..
    Private Sub SetTotal()
        Dim X As String
        Toplam = 0

        For Each strOrder As String In Me.lstOrders.Items
            For i As Integer = Len(strOrder) To 1 Step -1
                X = Mid(strOrder, i, 1)
                If X = " " Then
                    X = Mid(strOrder, i + 1, Len(strOrder) - i)
                    Toplam += CInt(X)
                    Exit For
                End If
            Next
        Next

        'Eger Dolar olarak toplam istenirse..
        If Me.cmnuTotal_Dolar.Checked = True Then
            Me.lblTotal.Text = "$"
            Me.lblTotalKDV.Text = "$"
            Me.txtTotal.Text = Toplam
            Me.txtTotalKDV.Text = Me.txtTotal.Text + (Me.txtTotal.Text * 18 / 100)
            'Eger YTL olarak toplam istenirse..
        ElseIf Me.cmnuTotal_YTL.Checked = True Then
            Me.lblTotal.Text = "YTL"
            Me.lblTotalKDV.Text = "YTL"
            Me.txtTotal.Text = Toplam * Dolar
            Me.txtTotalKDV.Text = Me.txtTotal.Text + (Me.txtTotal.Text * 18 / 100)
        End If

    End Sub
#End Region

#Region "Olaylar"
    Private Sub frmOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblOrderName"

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                Dim objListBoxNesnesi As ListBoxNesnesi
                objListBoxNesnesi = New ListBoxNesnesi(myDR.Item("Name").ToString, CInt(myDR.Item("ID")))

                Me.lstOrderer.Items.Add(objListBoxNesnesi)
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

    Private Sub lstOrderer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOrderer.SelectedIndexChanged
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblOrders WHERE ID=@id"

            Dim myDR As OleDbDataReader

            Me.lstOrders.Items.Clear()

            Me.txtOrderer.Text = Me.lstOrderer.SelectedItem.ToString

            Dim objListBoxNesnesi As ListBoxNesnesi
            objListBoxNesnesi = CType(Me.lstOrderer.SelectedItem, ListBoxNesnesi)

            myCmd.Parameters.AddWithValue("@id", objListBoxNesnesi.ID)

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                Me.lstOrders.Items.Add(myDR.Item("OrderUnit"))
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try

        If Not Me.lstOrders.Items.Count = 0 Then
            SetTotal()
        End If
    End Sub

    Private Sub cmnuTotal_YTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTotal_YTL.Click
        Dim Deger As Object

        Deger = InputBox("Dolar Kurunu Giriniz:", "Dolar Kuru")

        If Not IsNumeric(Deger) = True Then
            MessageBox.Show("Lütfen Dolar Kurunu sayý olarak giriniz..", "Hatalý Dolar Kuru")
            Exit Sub
        Else
            Dolar = CType(Deger, Single)
        End If

        Me.cmnuTotal_Dolar.Checked = False
        Me.cmnuTotal_YTL.Checked = True

        SetTotal()
    End Sub

    Private Sub cmnuTotal_Dolar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTotal_Dolar.Click
        Me.cmnuTotal_Dolar.Checked = True
        Me.cmnuTotal_YTL.Checked = False

        SetTotal()
    End Sub

    Private Sub btnDelOrderer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelOrderer.Click
        Dim objListboxNesnesi As ListBoxNesnesi
        objListboxNesnesi = New ListBoxNesnesi

        objListboxNesnesi = CType(Me.lstOrderer.SelectedItem, ListBoxNesnesi)

        DialogResult = MessageBox.Show(objListboxNesnesi.Value & " adlý sipaiþçinin sipariþini silmek istediðinize emin misiniz?", "Sipariþçi Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If DialogResult = Windows.Forms.DialogResult.Yes Then

            Try
                myConn = New OleDbConnection
                myConn.ConnectionString = Module1.strConnStr

                myCmd = New OleDbCommand
                myCmd.Connection = myConn
                myCmd.CommandType = CommandType.Text
                myCmd.CommandText = "DELETE FROM tblOrders WHERE ID=@id"

                myCmd.Parameters.AddWithValue("@id", objListboxNesnesi.ID)
                'Baðlantý açýlýr ve tblOrders daki sipaiþ edilen 
                'ürünler ID ye göre silinir..
                myConn.Open()
                myCmd.ExecuteNonQuery()

                myCmd = New OleDbCommand
                myCmd.Connection = myConn
                myCmd.CommandType = CommandType.Text
                'Baglantý açýkken tblOrderName deki müþteri ismi silinir..
                myCmd.CommandText = "DELETE FROM tblOrderName WHERE ID=@id"

                myCmd.Parameters.AddWithValue("@id", objListboxNesnesi.ID)

                myCmd.ExecuteNonQuery()

            Catch exOle As OleDbException
                MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                myConn.Close()
            End Try
        End If
    End Sub

    Private Sub btnSelectOrderer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectOrderer.Click
        'Listeden bir sipariþçi seçilmedi ise sub dan çýkýlýr..
        If Me.lstOrderer.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen listeden bir sipariþçi seçiniz..", "Seçili Sipariþçi Yok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        DialogResult = MessageBox.Show("Seçili sipariþçi ana program penceresindeki sipariþ listesine aktarýlsýn mý?", "Sipariþçi Aktarma", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Dim objListboxNesnesi As ListBoxNesnesi
            objListboxNesnesi = New ListBoxNesnesi

            objListboxNesnesi = CType(Me.lstOrderer.SelectedItem, ListBoxNesnesi)

            'Orderer ismi module degiskenine aktarýlýr..
            Module1.strOrderer = objListboxNesnesi.Value.ToString
            'Orderer ID module degiskenine aktarýlýr..
            Module1.intOrdererID = objListboxNesnesi.ID
            'Bir aktarma iþlemi yapýldýðýný belirtmek için..
            Module1.boolSelectOrderer = True

            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmnuOrdererList_SecAktar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOrdererList_SecAktar.Click
        btnSelectOrderer_Click(sender, e)
    End Sub

    Private Sub cmnuOrdererList_SiparisciSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOrdererList_SiparisciSil.Click
        btnDelOrderer_Click(sender, e)
    End Sub
#End Region



End Class