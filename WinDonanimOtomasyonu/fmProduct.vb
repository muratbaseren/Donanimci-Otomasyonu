#Region "imports"
Imports PureComponents.NicePanel
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class fmProduct

#Region "Yerel Degiskenler"
    Private myConn As OleDbConnection
    Private myCmd As OleDbCommand
    Private myDR As OleDbDataReader

    Private ProductID As Integer
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

            Me.cmbCategories.Items.Clear()

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

    'Seçilen kategoriye göre urunlerin listelenmesi..Bir kategori degeri alir..
    Private Sub GetCategoryDetails(ByVal CategoryName As String)
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblProducts WHERE Category=@category"

            myCmd.Parameters.AddWithValue("@Category", CategoryName)

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
                ProductID = myDR.Item("ID")
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

    'Listeden secili urunun detaylarýný gormek..
    Private Sub GetProductDetails(ByVal Product_ID As Integer)
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblProducts WHERE ID=@id AND Category=@category"

            myCmd.Parameters.AddWithValue("@id", Product_ID)
            myCmd.Parameters.AddWithValue("@Category", Me.cmbCategories.Text.ToString)

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                ProductID = myDR.Item("ID")
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
#End Region

#Region "Olaylar"
    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCategories()
    End Sub

    Private Sub lstProducts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProducts.SelectedIndexChanged
        GetProductDetails()
    End Sub

    Private Sub cmbCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategories.SelectedIndexChanged
        GetCategoryDetails()
        Me.txtCategory.Text = Me.cmbCategories.Text
    End Sub

    'Iptal butonu görevi..
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GetCategories()

        Me.txtCategory.Text = Nothing
        Me.txtProductName.Text = Nothing
        Me.txtQuantity.Text = Nothing
        Me.txtUnitPriceDolar.Text = Nothing
    End Sub

    'Ekle butonu görevi..
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Category As String
        Dim Product As String

        'Eger kategori yada urun adý boþ geçilmediyse..
        If Not Me.txtCategory.Text = Nothing AndAlso Not Me.txtProductName.Text = Nothing Then

            'Eger birim fiyat yada adet rakam olarak girildiyse..
            If IsNumeric(Me.txtUnitPriceDolar.Text) = True AndAlso IsNumeric(Me.txtQuantity.Text) = True Then
                'Insert sorgusu gerçekleþir..
                Dim InsertQuery As OleDbQueryEvents.OleDbInsertQuery
                InsertQuery = New OleDbQueryEvents.OleDbInsertQuery(Module1.strConnStr, "tblProducts", "Category", "Product", "UnitPrice", "Quantity", Me.txtCategory.Text, Me.txtProductName.Text, Me.txtUnitPriceDolar.Text, Me.txtQuantity.Text)

                'Aksi halde Adet ve birim fiyat hatalý oldugunu söyleyen
                'mesaj ekrana verilir..
            Else
                MessageBox.Show("Lütfen 'Adet' veya 'Birim Fiyat' bölümlerini rakam olarak giriniz..", "Adet veya Birim Fiyat Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            'Aksi halde kategori ve urun adýnýn boþ oldugu hatasý ekrana verilir..
        Else
            MessageBox.Show("Lütfen 'Ürün Adý' veya 'Kategori' bölümlerini boþ geçmeyiniz..", "Ürün Adý veya Kategori Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Category = Me.txtCategory.Text
        Product = Me.txtProductName.Text

        GetCategories()
        GetCategoryDetails(Category)
    End Sub

    'Kaydet butonu görevi..
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Category As String

        'Eger kategori yada urun adý boþ geçilmediyse..
        If Not Me.txtCategory.Text = Nothing AndAlso Not Me.txtProductName.Text = Nothing Then

            'Eger birim fiyat yada adet rakam olarak girildiyse..
            If IsNumeric(Me.txtUnitPriceDolar.Text) = True AndAlso IsNumeric(Me.txtQuantity.Text) = True Then
                'Insert sorgusu gerçekleþir..
                Dim UpdateQuery As OleDbQueryEvents.OleDbUpdateQuery
                UpdateQuery = New OleDbQueryEvents.OleDbUpdateQuery(Module1.strConnStr, "tblProducts", "Category", "Product", "UnitPrice", "Quantity", Me.txtCategory.Text, Me.txtProductName.Text, Me.txtUnitPriceDolar.Text, Me.txtQuantity.Text, "ID", ProductID)

                'Aksi halde Adet ve birim fiyat hatalý oldugunu söyleyen
                'mesaj ekrana verilir..
            Else
                MessageBox.Show("Lütfen 'Adet' veya 'Birim Fiyat' bölümlerini rakam olarak giriniz..", "Adet veya Birim Fiyat Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            'Aksi halde kategori ve urun adýnýn boþ oldugu hatasý ekrana verilir..
        Else
            MessageBox.Show("Lütfen 'Ürün Adý' veya 'Kategori' bölümlerini boþ geçmeyiniz..", "Ürün Adý veya Kategori Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Category = Me.txtCategory.Text

        GetCategories()
        GetCategoryDetails(Category)
        GetProductDetails(ProductID)
    End Sub

    'Sil butonu görevi..
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim Category As String

        If Not Me.lstProducts.SelectedIndex = -1 Then
            DialogResult = MessageBox.Show(Me.lstProducts.SelectedItem & " adlý ürünü silmek istediðinize emin misiniz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Dim DeleteQuery As OleDbQueryEvents.OleDbDeleteQuery
                DeleteQuery = New OleDbQueryEvents.OleDbDeleteQuery(Module1.strConnStr, "tblProducts", "ID", ProductID)
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Lütfen silme iþlemi için 'Ürünler' listesinden bir ürün seçiniz..", "Seçili Ürün Yok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Category = Me.txtCategory.Text

        GetCategories()
        GetCategoryDetails(Category)

    End Sub

    'Tum urunlerin ve istenirse kategorinin de silinmesi..
    Private Sub cmnuProducts_DeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuProducts_DeleteAll.Click
        DialogResult = MessageBox.Show("Tüm ürünlerin silinmesini istediðinize emin misiniz?", "Tüm Ürünleri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Dim DeleteQuery As OleDbQueryEvents.OleDbDeleteQuery
                DeleteQuery = New OleDbQueryEvents.OleDbDeleteQuery(Module1.strConnStr, "tblProduct")
            Else
                Exit Sub
            End If
        End If

        DialogResult = MessageBox.Show("Seçili Kategorinin de silinmesini ister misiniz?", "Kategori Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Try
                    myConn = New OleDbConnection
                    myConn.ConnectionString = Module1.strConnStr

                    myCmd = New OleDbCommand
                    myCmd.Connection = myConn
                    myCmd.CommandType = CommandType.Text
                    myCmd.CommandText = "DELETE FROM tblProducts WHERE Category=@category"

                    myCmd.Parameters.AddWithValue("@Category", Me.cmbCategories.Text)

                    myConn.Open()
                    myCmd.ExecuteReader()

                Catch exOle As OleDbException
                    MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    myConn.Close()
                End Try
            Else
                Exit Sub
            End If
        End If

        GetCategories()
    End Sub

    Private Sub cmnuProducts_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuProducts_Add.Click
        btnAdd_Click(sender, e)
    End Sub

    Private Sub cmnuProducts_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuProducts_Update.Click
        btnSave_Click(sender, e)
    End Sub

    Private Sub cmnuProducts_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuProducts_Cancel.Click
        btnDel_Click(sender, e)
    End Sub

    Private Sub cmnuProducts_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuProducts_Del.Click
        btnDel_Click(sender, e)
    End Sub
#End Region

End Class