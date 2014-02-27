#Region "imports"
Imports PureComponents.NicePanel
Imports System
Imports System.Data
Imports System.Exception
Imports System.Data.OleDb
#End Region

Public Class fmBorclar

#Region "Yerel Degiskenler"
    Private myConn As OleDbConnection
    Private myCmd As OleDbCommand
    Private myDR As OleDbDataReader

    Private OdenenBorclar As String
    Private BorcEkle As Single
#End Region

#Region "Metotlar"

    'Borclularý listelemek..
    Private Sub GetBorclular()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT BorcluID,BorcluAdSoy FROM tblBorclar"

            Dim myDR As OleDbDataReader

            Me.lstBorclar.Items.Clear()

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                Dim objListBoxNesnesi2 As ListBoxNesnesi2
                objListBoxNesnesi2 = New ListBoxNesnesi2(myDR.Item("BorcluAdSoy").ToString, CInt(myDR.Item("BorcluID")))

                Me.lstBorclar.Items.Add(objListBoxNesnesi2)
            Loop

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

    'Odenen borclarý okumak..
    Private Sub GetBorcDetails()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.strConnStr

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM tblBorclar where BorcluID=@borcluid"

            Dim myDR As OleDbDataReader

            Me.lstOdenenler.Items.Clear()
            Me.lblBorcBitti.Text = Nothing

            Dim objListBoxNesnesi2 As New ListBoxNesnesi2
            objListBoxNesnesi2 = CType(Me.lstBorclar.SelectedItem, ListBoxNesnesi2)


            myCmd.Parameters.AddWithValue("@borcluid", objListBoxNesnesi2.ID)

            myConn.Open()
            myDR = myCmd.ExecuteReader

            OdenenBorclar = Nothing

            Do While myDR.Read
                Me.txtBorcluAdSoy.Text = myDR.Item("BorcluAdSoy")
                Me.txtToplamBorc.Text = myDR.Item("ToplamBorc")
                OdenenBorclar = myDR.Item("OdenenBorc")
            Loop

            If Not OdenenBorclar = Nothing Then
                GetOdenenBorc()
                SetToplam()
            End If

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "OLEDB HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            myConn.Close()
        End Try
    End Sub

    'Odenen miktarlarý Odenen borclar listesine aktarmak için parçalamak..
    Private Sub GetOdenenBorc()
        Dim X As String = Nothing
        Dim K As Integer = Len(OdenenBorclar)

        'Odenmiþ borclarýn listelenmesi..
        For i As Integer = Len(OdenenBorclar) To 2 Step -1
            X = Mid(OdenenBorclar, i, 1)
            If X = "/" Then
                If K = Len(OdenenBorclar) Then
                    X = Mid(OdenenBorclar, i + 1, K - i)
                Else
                    X = Mid(OdenenBorclar, i + 1, K - i - 1)
                End If
                K = i
                Me.lstOdenenler.Items.Add(X)
            End If
        Next

    End Sub

    Private Sub SetToplam()
        Dim Odenenler As Single = 0

        'Kalan borc hesaplama..
        For i As Integer = 0 To Me.lstOdenenler.Items.Count - 1
            Odenenler += Me.lstOdenenler.Items(i)
        Next

        Dim KalanBorc As Single = 0
        KalanBorc = CType(Me.txtToplamBorc.Text, Single) - Odenenler

        'Borc bitip bitmediðini belirtme..
        If KalanBorc = 0 Then
            Me.lblBorcBitti.Text = Me.txtBorcluAdSoy.Text & " adlý kiþinin borcu kalmamýþtýr."
        ElseIf KalanBorc < 0 Then
            Me.lblBorcBitti.Text = Me.txtBorcluAdSoy.Text & " adlý kiþinin borcundan fazla ödemiþtir."
        Else
            Me.lblBorcBitti.Text = Me.txtBorcluAdSoy.Text & " adlý kiþinin borcu hala vardýr."
        End If

        Me.txtKalanBorc.Text = KalanBorc
    End Sub

    'Odenen borclarý database e kaydetmek için uygun hale getirme..
    Private Sub SetOdenenBorc()
        OdenenBorclar = Nothing

        If Not Me.lstOdenenler.Items.Count = 0 Then
            For i As Integer = 0 To Me.lstOdenenler.Items.Count - 1
                OdenenBorclar += "/" & CStr(Me.lstOdenenler.Items(i))
            Next
        Else
            OdenenBorclar = 0
        End If
    End Sub

    'Var olan borclu kaydýný düzenler..
    Private Sub SaveBorclu()
        Dim objListBoxNesnesi2 As New ListBoxNesnesi2
        objListBoxNesnesi2 = CType(Me.lstBorclar.SelectedItem, ListBoxNesnesi2)

        Dim UpdateQuery As OleDbQueryEvents.OleDbUpdateQuery
        UpdateQuery = New OleDbQueryEvents.OleDbUpdateQuery(Module1.strConnStr, "tblBorclar", "BorcluAdSoy", "ToplamBorc", "OdenenBorc", Me.txtBorcluAdSoy.Text, CType(Me.txtToplamBorc.Text, Single), OdenenBorclar, "BorcluID", objListBoxNesnesi2.ID)
    End Sub

    ''Var olan borclu kaydýný düzenler..
    'Private Sub SaveBorclu(ByVal EklenenBorc As Single)
    '    Dim objListBoxNesnesi2 As New ListBoxNesnesi2
    '    objListBoxNesnesi2 = CType(Me.lstBorclar.SelectedItem, ListBoxNesnesi2)

    '    Dim UpdateQuery As OleDbQueryEvents.OleDbUpdateQuery
    '    UpdateQuery = New OleDbQueryEvents.OleDbUpdateQuery(Module1.strConnStr, "tblBorclar", "BorcluAdSoy", "ToplamBorc", "OdenenBorc", Me.txtBorcluAdSoy.Text, CType(Me.txtToplamBorc.Text, Single), OdenenBorclar, "BorcluID", objListBoxNesnesi2.ID)
    'End Sub

    'Yeni borclu ekler..
    Private Sub NewBorclu()
        Dim TplBorc As Single = CType(Me.txtToplamBorc.Text, Single)

        SetOdenenBorc()

        Dim InsertQuery As OleDbQueryEvents.OleDbInsertQuery
        InsertQuery = New OleDbQueryEvents.OleDbInsertQuery(Module1.strConnStr, "tblBorclar", "BorcluAdSoy", "ToplamBorc", "OdenenBorc", Me.txtBorcluAdSoy.Text, TplBorc, OdenenBorclar)
    End Sub

    'Seçili borcluyu siler..
    Private Sub DelBorclu()
        Dim objListBoxNesnesi2 As New ListBoxNesnesi2
        objListBoxNesnesi2 = CType(Me.lstBorclar.SelectedItem, ListBoxNesnesi2)

        Dim DeleteQuery As OleDbQueryEvents.OleDbDeleteQuery
        DeleteQuery = New OleDbQueryEvents.OleDbDeleteQuery(Module1.strConnStr, "tblBorclar", "BorcluID", objListBoxNesnesi2.ID)
    End Sub

    'Tum borclularý siler..
    Private Sub DelBorclular()
        Dim DeleteQuery As OleDbQueryEvents.OleDbDeleteQuery
        DeleteQuery = New OleDbQueryEvents.OleDbDeleteQuery(Module1.strConnStr, "tblBorclar")
    End Sub
#End Region

#Region "Olaylar"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not Me.lstBorclar.SelectedIndex = -1 Then
            If Not Me.txtBorcluAdSoy.Text = Nothing Then
                SetOdenenBorc()
                SaveBorclu()
            Else
                MessageBox.Show("Lütfen Borçlu ismini giriniz..", "Borçlu Ismi Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Else
            MessageBox.Show("Lütfen listeden bir borçlu seçiniz..", "Seçili Borçlu Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim User As String = InputBox("Borcu olan kiþinin ismini giriniz..", "Yeni Borçlu Ekle")
        Dim Deger As Object
        Dim Borc As Single = 0

        If Not Trim(User.Length) = 0 Then
            Do
                Deger = InputBox(User & " adlý kiþinin borcunu giriniz..", "Borç Miktarý")
            Loop While (IsNumeric(Deger) = False)

            Borc = Convert.ToSingle(Deger)
            Me.txtToplamBorc.Text = Borc
            Me.txtBorcluAdSoy.Text = User
            SetOdenenBorc()
            NewBorclu()
            GetBorclular()

            For i As Integer = 0 To Me.lstBorclar.Items.Count - 1
                If Me.lstBorclar.Items(i).ToString = User Then
                    Me.lstBorclar.SelectedIndex = i
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Lütfen borçlu ismini giriniz..", "Borçlu Ismi Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GetBorclular()
        Me.txtBorcluAdSoy.Text = Nothing
        Me.txtKalanBorc.Text = Nothing
        Me.txtToplamBorc.Text = Nothing
        Me.lblBorcBitti.Text = Nothing
        Me.lstOdenenler.Items.Clear()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If Not Me.lstBorclar.SelectedIndex = -1 Then
            Dim objListBoxNesnesi2 As New ListBoxNesnesi2
            objListBoxNesnesi2 = CType(Me.lstBorclar.SelectedItem, ListBoxNesnesi2)

            DialogResult = MessageBox.Show(objListBoxNesnesi2.Value & " adlý kiþiyi silmek istediðinize emin misniz?", "Borçlu Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                DelBorclu()
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Lütfen silinmesi için listeden bir borçlu seçiniz..", "Seçili Borçlu Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cmnuBorclular_Yeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuBorclular_Yeni.Click
        btnAdd_Click(sender, e)
    End Sub

    Private Sub cmnuBorclular_Kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuBorclular_Kaydet.Click
        btnSave_Click(sender, e)
    End Sub

    Private Sub cmnuBorclular_Iptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuBorclular_Iptal.Click
        btnCancel_Click(sender, e)
    End Sub

    Private Sub cmnuBorclular_Sil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuBorclular_Sil.Click
        btnDel_Click(sender, e)
    End Sub

    Private Sub cmnuBorclular_HepsiSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuBorclular_HepsiSil.Click
        DialogResult = MessageBox.Show("Tüm kayýtlarýn silinsin mi?", "Tüm Kayýtlarý Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            DelBorclular()
        End If
    End Sub

    Private Sub cmnuOdenen_Ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOdenen_Ekle.Click
        BorcEkle = Nothing
        BorcEkle = InputBox("Ödenen borç miktarýný giriniz." & vbCrLf & "Örn:123,45", "Ödenen Borç Ekle")

        If IsNumeric(BorcEkle) = True Then
            Me.lstOdenenler.Items.Add(BorcEkle)
        End If

        SetToplam()
    End Sub

    Private Sub cmnuOdenen_Sil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOdenen_Sil.Click
        If Not Me.lstOdenenler.SelectedIndex = -1 Then
            Me.lstOdenenler.Items.RemoveAt(Me.lstOdenenler.SelectedIndex)
        Else
            MessageBox.Show("Silmek için bir ödeme seçiniz.", "Ödeme Sil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

        SetToplam()
    End Sub

    'Private Sub cmnuOdenen_HepsiSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DialogResult = MessageBox.Show("Tüm ödemeler silinsin mi?", "Tüm Ödemeleri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

    '    If DialogResult = Windows.Forms.DialogResult.Yes Then
    '        Me.lstOdenenler.Items.Clear()
    '    Else
    '        Exit Sub
    '    End If

    '    SetToplam()
    'End Sub

    Private Sub lstOdenenler_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstOdenenler.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmnuOdenen_Sil_Click(sender, e)
        End If
    End Sub

    Private Sub frmBorclar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetBorclular()
    End Sub

    Private Sub lstBorclar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBorclar.SelectedIndexChanged
        GetBorcDetails()
        GetOdenenBorc()
        SetToplam()
    End Sub

    Private Sub cmnuOdenen_BorcEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuOdenen_BorcEkle.Click
        Dim BorcEkle As Single

        BorcEkle = InputBox("Eklenecek Borcu Giriniz." & vbCrLf & "Örn:123,56", "Borç Ekle")

        If IsNumeric(BorcEkle) = True Then
            If Not Me.txtToplamBorc.Text = Nothing Then
                BorcEkle += CType(Me.txtToplamBorc.Text, Single)
                Me.txtToplamBorc.Text = BorcEkle
            Else
                Me.txtToplamBorc.Text = BorcEkle
            End If

            SetToplam()
        End If
    End Sub
#End Region

    
End Class