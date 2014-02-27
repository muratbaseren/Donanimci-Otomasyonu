#Region "imports"
Imports PureComponents.NicePanel
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class frmMain

#Region "Yerel Degiskenler"
    Private myConn As OleDbConnection
    Private myCmd As OleDbCommand
    Private myDR As OleDbDataReader

    Private Toplam As Single = 0
    Private SameID As Boolean = False
    Private ID As Decimal
#End Region

#Region "Metotlar"
    'Kategorilerin tblProducts dan okunmasý ve kategori combobox ýna aktarýlmasý..
    Private Sub GetCategories()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT Distinct Category FROM tblProducts"

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                Me.cmbCategories.Items.Add(myDR.Item("Category"))
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

    'Seçilen kategoriye göre urunlerin listelenmesi..
    Private Sub GetCategoryDetails()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblProducts WHERE Category=@category"

            myCmd.Parameters.AddWithValue("@Category", Me.cmbCategories.Text.ToString)

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Me.lstProducts.Items.Clear()

            Do While myDR.Read
                Me.lstProducts.Items.Add(myDR.Item("Product"))
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

    'Listeden secili urunun detaylarýný gormek..
    Private Sub GetProductDetails()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblProducts WHERE Product=@product AND Category=@category"

            myCmd.Parameters.AddWithValue("@Product", Me.lstProducts.SelectedItem.ToString)
            myCmd.Parameters.AddWithValue("@Category", Me.cmbCategories.Text.ToString)

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                Me.txtCategory.Text = myDR.Item("Category")
                Me.txtProductName.Text = myDR.Item("Product")
                Me.txtUnitPriceDolar.Text = myDR.Item("UnitPrice")
                Me.txtQuantity.Text = myDR.Item("Quantity")
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

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
            Me.txtTotal.Text = Toplam
            Me.txtTotalKDV.Text = Me.txtTotal.Text + (Me.txtTotal.Text * 18 / 100)
            'Eger YTL olarak toplam istenirse..
        ElseIf Me.cmnuTotal_YTL.Checked = True Then
            Me.txtTotal.Text = Toplam * Me.txtDolar.Text
            Me.txtTotalKDV.Text = Me.txtTotal.Text + (Me.txtTotal.Text * 18 / 100)
        End If

    End Sub

    'Sipariþ listesi goruntuleme..
    Private Sub GetOrders()
        Me.txtOrderer.Text = Module1.strOrderer

        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblOrders WHERE ID=@id"

            Dim myDR As OleDbDataReader

            Me.lstOrders.Items.Clear()

            myCmd.Parameters.AddWithValue("@id", Module1.intOrdererID)

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

    'Sipariþciye verilecek ID nin kontrol edilmesi..
    Private Sub ControlID()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT ID FROM tblOrderName"

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                If ID = myDR.Item("ID") Then
                    SameID = True
                End If
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

#End Region

#Region "Olaylar"
    'Form yuklendiðinde kategoriler yuklenir..
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCategories()
    End Sub

    'Seçilen kategoriye gore ürünler listelenir..
    Private Sub cmbCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategories.SelectedIndexChanged
        GetCategoryDetails()
    End Sub

    'Seçilen ürüne gore ürün detaylarý ekrana gelir..
    Private Sub lstProducts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProducts.SelectedIndexChanged
        GetProductDetails()
    End Sub

    'Ürünün dolar birim fiyatý deðiþirse Dolar kuru girilmiþmi diye bakýlarak
    'Birim YTL fiyatý ve KDV li Birim YTL fiyatý hesaplanýr..
    Private Sub txtUnitPriceDolar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitPriceDolar.TextChanged
        'Eger dolar kuru girilmiþse,birim fiyat girilmiþse ve bunlar isnumeric ise
        'Birim fiyatý hesapla YTL olarak..
        If Not Me.txtUnitPriceDolar.Text = Nothing AndAlso _
           Not Me.txtDolar.Text = Nothing AndAlso _
           IsNumeric(Me.txtUnitPriceDolar.Text) = True AndAlso _
           IsNumeric(Me.txtDolar.Text) = True Then

            Me.txtUnitPriceYTL.Text = Me.txtUnitPriceDolar.Text * Me.txtDolar.Text
        End If
    End Sub

    'Dolar kuru deðiþirse YTL birim fiyatý hesapla..
    Private Sub txtDolar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDolar.TextChanged
        'Eger dolar kuru boþ ise yada sayý deðilse birim fiyat YTL ve
        'brim fiyat YTL KDV li temizlensin..
        If Me.txtDolar.Text = Nothing OrElse IsNumeric(Me.txtDolar.Text) = False Then
            Me.txtUnitPriceYTL.Text = Nothing
            Me.txtUnitPriceKDV.Text = Nothing
            cmnuTotal_Dolar_Click(sender, e)
        End If
        txtUnitPriceDolar_TextChanged(sender, e)
        'Dolar kuru girildiðinde yada deðiþtirildiðinde toplam YTL cinsinden ise 
        'Toplamý yeniden hesaplayacak..
        If Me.cmnuTotal_YTL.Checked = True AndAlso IsNumeric(Me.txtDolar.Text) = True Then
            SetTotal()
        End If
    End Sub

    'Eðer YTL birim fiyatý deðiþirse KDV li YTL birim fiyatý hesapla..
    Private Sub txtUnitPriceYTL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitPriceYTL.TextChanged
        'Eger YTL birim fiyat boþ deðilse ve isnumeric ise KDV li YTL birim fiyat
        'hesapla..
        If Not Me.txtUnitPriceYTL.Text = Nothing AndAlso IsNumeric(Me.txtUnitPriceYTL.Text) = True Then
            Me.txtUnitPriceKDV.Text = Me.txtUnitPriceYTL.Text + (Me.txtUnitPriceYTL.Text * 18 / 100)
        End If
    End Sub

    'Orders listesine ürün ekleme..
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not Me.lstProducts.SelectedIndex = -1 Then
            'Siparis listesine ürünün eklenmesi..
            Me.lstOrders.Items.Add(Me.lstProducts.SelectedItem & " --- " & Me.txtUnitPriceDolar.Text)
            'Toplam yazilmasi..
            If Not Me.lstOrders.Items.Count = 0 Then
                SetTotal()
            End If
        End If
    End Sub

    'Orders listesinden ürün çýkarma..
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If Not Me.lstOrders.SelectedIndex = -1 Then
            Me.lstOrders.Items.Remove(Me.lstOrders.SelectedItem)

            'Sipariþler listesinden bir ürün çýkarýldýðýnda toplam hesaplanýyor..
            SetTotal()
        End If
    End Sub

    'KDV siz toplam deðiþtiði zaman KDV li hesaplanýyor..
    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        Me.txtTotalKDV.Text = Me.txtTotal.Text + (Me.txtTotal.Text * 18 / 100)
    End Sub

    'Toplam Dolar olarak yazýlsýn istenirse..
    Private Sub cmnuTotal_Dolar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTotal_Dolar.Click
        Me.cmnuTotal_Dolar.Checked = True
        Me.cmnuTotal_YTL.Checked = False
        Me.lblTotal.Text = "$"
        Me.lblTotalKDV.Text = "$"

        SetTotal()
    End Sub

    'Toplam YTL olarak istenirse..
    Private Sub cmnuTotal_YTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTotal_YTL.Click
        If Not Me.txtDolar.Text = Nothing AndAlso IsNumeric(Me.txtDolar.Text) = True Then
            Me.cmnuTotal_Dolar.Checked = False
            Me.cmnuTotal_YTL.Checked = True
            Me.lblTotal.Text = "YTL"
            Me.lblTotalKDV.Text = "YTL"

            SetTotal()
        Else
            MessageBox.Show("Dolar kuru girilmemiþ yada sayý olarak girildiðine emin olunuz!", "Dolar Kuru Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    'lstOrders dan ürün sil komutu verilirse..
    Private Sub cmnuOrders_ProductDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuProducts_Del.Click
        btnDel_Click(sender, e)
    End Sub

    'lstOrders da tum urunlerin silinmesi..
    Private Sub cmnuOrders_AllClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOrders_AllClear.Click
        Me.lstOrders.Items.Clear()
        Me.txtOrderer.Text = Nothing
        cmnuTotal_Dolar_Click(sender, e)
    End Sub

    'lstProducts da bir urune çift týklandýðýnda onun lstOrders a aktarýlmasý..
    Private Sub lstProducts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducts.DoubleClick
        If Not Me.lstProducts.SelectedIndex = -1 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    'lstOrders da bir urune çift týklandýðýnda onun lstProducts a aktarýlmasý..
    Private Sub lstOrders_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrders.DoubleClick
        If Not Me.lstOrders.SelectedIndex = -1 Then
            btnDel_Click(sender, e)
        End If
    End Sub

    'Programdan çýkýþ..
    Private Sub cmnuMain_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuMain_Exit.Click
        DialogResult = MessageBox.Show("Programdan çýkmak istediðinize emin misiniz?", "ÇIKIÞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    'Sipariþler formuna gider..
    Private Sub cmnuOrders_SelectOrderer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOrders_SelectOrderer.Click
        Dim frm As New fmOrderer
        frm.ShowDialog()
    End Sub

    'Sipariþ kaydet e basýlýrsa..
    Private Sub cmnuOrders_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOrders_Save.Click

        If Not Me.txtOrderer.Text = Nothing AndAlso Not Me.lstOrders.Items.Count = 0 Then
            Try
Dongu:
                'Sipariþçi için 0-100000 arasý rastgele bir deger verilir ve
                'bu deger tblOrderName de varmý diye kontrol edilir..
                'Eger varsa Dongu yazan yere geri donulur ve tekrar rastgele
                'bir deger verilerek kayýdýn gerçekleþmesi saðlanýr..
                Randomize()
                ID = CInt(100000 * Rnd())

                ControlID()

                If SameID = True Then
                    GoTo Dongu
                Else
                    SameID = False
                End If

                myConn = New OleDbConnection
                myConn.ConnectionString = Module1.strConnStr

                myCmd = New OleDbCommand
                myCmd.Connection = myConn
                myCmd.CommandType = CommandType.Text
                myCmd.CommandText = _
                    "INSERT INTO tblOrderName(ID,Name) " & _
                    "VALUES(@id,@name)"

                myCmd.Parameters.AddWithValue("@id", ID)
                myCmd.Parameters.AddWithValue("@name", Me.txtOrderer.Text)

                myConn.Open()
                myCmd.ExecuteNonQuery()

                For i As Integer = 0 To Me.lstOrders.Items.Count - 1
                    myCmd = New OleDbCommand
                    myCmd.Connection = myConn
                    myCmd.CommandType = CommandType.Text
                    myCmd.CommandText = _
                    "INSERT INTO tblOrders (ID,OrderUnit) " & _
                    "VALUES(@id,@OrderUnit)"

                    myCmd.Parameters.AddWithValue("@id", ID)
                    myCmd.Parameters.AddWithValue("@OrderUnit", Me.lstOrders.Items(i))
                    myCmd.ExecuteNonQuery()
                Next

                MessageBox.Show(Me.txtOrderer.Text & " adlý kiþi adýna sipariþ kaydedilmiþtir..", "Sipariþ Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Catch exOle As OleDbException
                MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                myConn.Close()
            End Try
        Else
            MessageBox.Show("Sipariþçi Ad ve Soyadýný girmediniz ya da sipariþ için ürün eklemediniz..!Sipariþinizin kaydedilmesi için lütfen ikisinide giriniz..", "Sipariþ Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    'Siparisci tablosundan alýnan degerin ana form a aktarýlmasý..
    Private Sub cmnuOrders_OrderBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOrders_OrderBuy.Click
        If Module1.boolSelectOrderer = True AndAlso Not Module1.intOrdererID = Nothing Then
            GetOrders()

            Module1.boolSelectOrderer = False
            Module1.intOrdererID = Nothing
            Module1.strOrderer = Nothing
        End If
    End Sub

    Private Sub cmnuPD_DelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuPD_DelAll.Click
        Me.txtProductName.Text = Nothing
        Me.txtCategory.Text = Nothing
        Me.txtUnitPriceDolar.Text = Nothing
        Me.txtUnitPriceKDV.Text = Nothing
        Me.txtUnitPriceYTL.Text = Nothing
        Me.txtQuantity.Text = Nothing
    End Sub

    Private Sub cmnuPD_frmProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuPD_frmProduct.Click
        Dim frm As New fmProduct
        frm.ShowDialog()
    End Sub

    Private Sub cmnuMain_OrdersGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuMain_OrdersGo.Click
        Dim frm As New fmOrderer
        frm.ShowDialog()
    End Sub

    Private Sub cmnuMain_Orders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuMain_Orders.Click
        Dim frm As New fmProduct
        frm.ShowDialog()
    End Sub

    Private Sub cmnuMain_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuMain_About.Click
        Dim frm As New fmHakkinda
        frm.ShowDialog()
    End Sub

    Private Sub cmnuMain_BorcTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuMain_BorcTable.Click
        Dim frm As New fmBorclar
        frm.ShowDialog()
    End Sub
#End Region

    
End Class
