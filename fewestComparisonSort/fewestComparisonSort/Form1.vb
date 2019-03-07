Imports System.Linq

Public Class Form1


    Private mComparisonsCount As Integer
    Dim prompt As Prompt
    Private mEqualItemsIndex As Short
    Private Property mSortInprogress As Boolean = False

    Public Property ComparisonsCount() As Integer
        Get
            Return mComparisonsCount
        End Get
        Set(ByVal value As Integer)
            mComparisonsCount = value
            lblComparisonCount.Text = "Comparisons# :" & mComparisonsCount.ToString
        End Set
    End Property

    Private mTotalItems As Integer
    Public Property TotalItems() As Integer
        Get
            Return mTotalItems
        End Get
        Set(ByVal value As Integer)
            mTotalItems = value
            lblTotalItems.Text = "Total Items: " & mTotalItems.ToString
        End Set
    End Property


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine("*************Starting**************")
        Dim SortingItems As String()
        Dim testInt As Integer
        Dim lstString As String()

        mEqualItemsIndex = 0
        ComparisonsCount = 0
        SortingItems = txtList.Lines.ToList().ToArray
        If SortingItems.Any(Function(x) String.IsNullOrEmpty(x)) Then
            MessageBox.Show("There are some blank lines." & vbNewLine & "Please remove them and start again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'lstNumber = txtList.Lines.ToList() _
        '.Where(Function(ln) Integer.TryParse(ln.Trim(), testInt)) _
        '.Select(Function(ln) Convert.ToInt32(ln.Trim())).ToArray()

        TotalItems = SortingItems.Count
        Try
            'mergeSort(lstNumber, 0, lstNumber.Count - 1)
            QuickSort(SortingItems, 0, SortingItems.Count - 1)
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
        lstString = SortingItems.Select(Function(ln) Convert.ToString(ln) & Environment.NewLine).ToArray()
        txtSortedList.Text = listToString(lstString.ToList)
    End Sub

    Private Function listToString(lst As List(Of String), Optional seperator As String = "") As String
        listToString = String.Empty
        For Each item As String In lst
            listToString &= item
        Next
    End Function

    Public Sub mergeSort(arr As Integer(), l As Integer, r As Integer)
        If r - l = 1 Then
            ComparisonsCount += 1
            If arr(l) > arr(r) Then
                Dim tmp As Integer = arr(r)
                arr(r) = arr(l)
                arr(l) = tmp

            End If
            Return
        End If
        If l = r Then
            Return
        End If
        If l < r Then
            Dim m As Integer = l + (r - l) / 2
            printarray(arr, False, l, m)
            Debug.Write("|")
            printarray(arr, False, m + 1, r)
            Debug.Write(Environment.NewLine)
            mergeSort(arr, l, m)
            mergeSort(arr, m + 1, r)


            merge(arr, l, m, r)
            printarray(arr, True, l, r)
        End If
    End Sub


    ''' <summary>
    ''' 2 sorted lists (l..m) and (m+1..r) are being merged
    ''' </summary>
    Private Sub merge(arr As Integer(), l As Integer, m As Integer, r As Integer)
        Dim mLeft As Integer
        Dim insertPos As Integer
        'insert lst(i) between l and m inclusive
        For i As Integer = m + 1 To r
            mLeft = l + (m - l) / 2
            insertPos = positionInSortedList(arr, l, i - 1, arr(i))
            Dim shiftingItem As Integer = arr(i)
            For d As Integer = i - 1 To insertPos Step -1
                If d < 0 Then
                    Exit For
                End If
                arr(d + 1) = arr(d)
                'printarray(arr, True)
            Next
            arr(insertPos) = shiftingItem
            'printarray(arr, True, l, r)
        Next
    End Sub

    Private Function positionInSortedList(arr As Integer(), l As Integer, r As Integer, NewMember As Integer) As Integer

        Debug.WriteLine("l={0};r={1};newMember={2}", l, r, NewMember)
        Dim m As Integer
        m = l + (r - l) / 2

        If m = l Then

            If NewMember < arr(m) Then
                ComparisonsCount += 1
                Return l
            ElseIf NewMember < arr(r) Then
                ComparisonsCount += 1
                Return r
            Else
                Return r + 1
            End If
        ElseIf m = r Then
            If NewMember < arr(l) Then
                ComparisonsCount += 1
                Return l
            ElseIf NewMember < arr(r) Then
                ComparisonsCount += 1
                Return r
            Else
                Return r + 1
            End If
        End If

        'If NewMember = arr(m) Then
        '    Return m + 1
        'ElseIf NewMember < arr(m) Then
        '    Return positionInSortedList(arr, l, m, NewMember)
        'Else
        '    Return positionInSortedList(arr, m + 1, r, NewMember)
        'End If
        ComparisonsCount += 1
        If NewMember < arr(m) Then
            Return positionInSortedList(arr, l, m, NewMember)
        Else
            Return positionInSortedList(arr, m + 1, r, NewMember)
        End If

    End Function

    Sub printarray(arr As Integer(), insertNewLine As Boolean, Optional l As Integer = -1, Optional r As Integer = -1)
        If r = -1 Then
            r = arr.Count - 1
        End If
        If l = -1 Then
            l = 0
        End If
        For i As Integer = l To r
            Debug.Write(arr(i).ToString & ",")
        Next
        If insertNewLine Then Debug.Write(Environment.NewLine)
    End Sub

    Private Sub QuickSort(arr As String(), l As Integer, r As Integer)
        mSortInprogress = True
        If r - l = 0 Then
            Return
        End If

        'If r - l <= 0 Then
        '    Return
        'ElseIf r - l <= 1 Then
        '    If arr(l) > arr(r) Then
        '        Dim tmp As Integer = arr(l)
        '        arr(l) = arr(r)
        '        arr(r) = tmp
        '    End If
        '    Return
        'End If

        Dim pivotIndex As Integer = l
        Dim elementQueried As String
        For i As Integer = pivotIndex + 1 To r
            ComparisonsCount += 1
            If prompt.showPrompt(arr(i), arr(pivotIndex)) > 0 Then
                'If arr(i) <= arr(pivotIndex) Then
                'shift pivotindex till i-1 elements to next index
                'move arr(i) at pivotindex
                elementQueried = arr(i)
                For d As Integer = i To pivotIndex + 1 Step -1
                    arr(d) = arr(d - 1)
                Next
                arr(pivotIndex + 1) = arr(pivotIndex)
                arr(pivotIndex) = elementQueried
                pivotIndex += 1
            End If
        Next
        If pivotIndex > l Then
            QuickSort(arr, l, pivotIndex - 1)
        End If
        If pivotIndex < r Then
            QuickSort(arr, pivotIndex + 1, r)
        End If
        mSortInprogress = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        prompt = New Prompt(btnA, btnB, btnEqual)
    End Sub
End Class


Class Prompt
    Private Shared WithEvents mbtnA, mbtnB, mbtnEqual As Button
    Private Shared mUserResponded As Boolean
    Private Shared mPromptResult As Short
    Private Shared mEqualItemIndex As Integer = 0

    Sub New(btnA As Button, btnB As Button, btnEqual As Button)
        mbtnA = btnA
        mbtnB = btnB
        mbtnEqual = btnEqual
    End Sub
    Shared Function showPrompt(ByRef itemL As String, ByRef itemR As String) As Short
        mbtnA.Text = itemL
        mbtnB.Text = itemR
        mUserResponded = False
        While Not mUserResponded
            Application.DoEvents()
        End While
        If mPromptResult = 0 Then
            'if either has a number, use it to assign other AND dont increment index
            If itemL.Substring(0, 1) = "(" Then
                mEqualItemIndex = Integer.Parse(itemL.Substring(1, 1))
                itemR = "(" & mEqualItemIndex.ToString & ")" & itemR
            ElseIf itemR.Substring(0, 1) = "(" Then
                mEqualItemIndex = Integer.Parse(itemR.Substring(1, 1))
                itemL = "(" & mEqualItemIndex.ToString & ")" & itemL
            Else
                mEqualItemIndex += 1
                itemL = "(" & mEqualItemIndex.ToString & ")" & itemL
                itemR = "(" & mEqualItemIndex.ToString & ")" & itemR
            End If
        End If
        Return mPromptResult
    End Function

    Private Shared Sub btnA_Click(sender As Object, e As EventArgs) Handles mbtnA.Click
        mUserResponded = True
        mPromptResult = 1
    End Sub

    Private Shared Sub btnB_Click(sender As Object, e As EventArgs) Handles mbtnB.Click
        mUserResponded = True
        mPromptResult = -1
    End Sub
    Private Shared Sub btnEqual_Click(sender As Object, e As EventArgs) Handles mbtnEqual.Click
        mUserResponded = True
        mPromptResult = 0
    End Sub
End Class


