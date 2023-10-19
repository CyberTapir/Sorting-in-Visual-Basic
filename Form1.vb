﻿Public Class Form1
    Dim arr As Integer() = {0, 24, 12, 16, 32, 41, 22}
    'Bubble sort
    Private Sub BubbleSort()
        Dim Last As Integer
        Last = 6
        Dim Swapped As Boolean
        Swapped = True
        Dim i As Integer
        i = 1
        While Swapped = True
            Swapped = False
            i = 1
            While i < Last
                If arr(i) > arr(i + 1) Then
                    Swap(arr(i), arr(i + 1))
                    Swapped = True
                End If
                i = i + 1
            End While
            Last = Last - 1
        End While
        printArray()
    End Sub
    Private Sub SelectionSort()
        Dim EndUnsorted As Integer = 6
        While EndUnsorted > 1
            Dim i As Integer = 1
            Dim Max As Integer = arr(i)
            Dim PosMax As Integer = i
            While i < EndUnsorted
                i = i + 1
                If arr(i) > Max Then
                    Max = arr(i)
                    PosMax = i
                End If
            End While
            Swap(arr(PosMax), arr(EndUnsorted))
            EndUnsorted = EndUnsorted - 1
        End While
        printArray()
    End Sub
    Private Sub Swap(ByRef A As Integer, ByRef B As Integer)
        Dim Temp As Integer
        Temp = A
        A = B
        B = Temp
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BubbleSort()
        SelectionSort()
    End Sub
    Private Sub printArray()
        For i = 1 To 6
            ListBox1.Items.Add(arr(i))
        Next i
    End Sub
End Class