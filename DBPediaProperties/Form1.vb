Imports System.Text.RegularExpressions

Public Class Form1

    Private _linesToProcess As Long = 1200000000

    Private Sub btRemoveFluff_Click(sender As System.Object, e As System.EventArgs) Handles btRemoveFluff.Click
        '<http://dbpedia.org/resource/Aristotle> <http://dbpedia.org/ontology/mainInterest> <http://dbpedia.org/resource/Ethics> .
        '<http://dbpedia.org/resource/Aristotle> <http://dbpedia.org/ontology/mainInterest> <http://dbpedia.org/resource/Biology> .
        '<http://dbpedia.org/resource/Aristotle> <http://dbpedia.org/ontology/mainInterest> <http://dbpedia.org/resource/Zoology> .
        Dim sr As System.IO.StreamReader
        Dim sw As System.IO.StreamWriter
        Dim iLinesProcessed As Long = 0

        Try
            sr = New System.IO.StreamReader(tbFluffRemovalInputFile.Text)
            sw = New System.IO.StreamWriter(tbFluffRemovalOutputFile.Text, False)

            If sr.Peek <> -1 Then
                ' Skip first line
                sr.ReadLine()
            End If


            While sr.Peek <> -1
                Dim curLine As String = sr.ReadLine

                curLine = curLine.Replace("http://dbpedia.org/resource/", "")
                curLine = curLine.Replace("http://dbpedia.org/ontology/", "")
                curLine = curLine.Replace("http://www.w3.org/2003/01/geo/wgs84_pos#", "")
                curLine = curLine.Replace("http://www.georss.org/georss/", "")
                curLine = curLine.Replace("http://xmlns.com/foaf/0.1/", "")
                curLine = curLine.Replace("http://www.w3.org/2004/02/skos/core#", "")
                curLine = curLine.Replace("@en", "")
                curLine = curLine.Replace("\""", "")
                curLine = curLine.Replace(" .", "")

                ' Quotes to tags
                curLine = curLine.Replace(" """, "<")
                curLine = curLine.Replace("""", ">")

                ' Datatypes
                curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#date>", "<date>")
                'curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#gYear>", "<year>")
                curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#double>", "<number>")
                curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#integer>", "<number>")
                curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#positiveInteger>", "<number>")
                curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#nonNegativeInteger>", "<number>")
                curLine = curLine.Replace("^^<http://www.w3.org/2001/XMLSchema#float>", "<number>")
                curLine = curLine.Replace("^^<http://dbpedia.org/datatype/usDollar>", "<number>")

                If curLine.IndexOf("^^") <> -1 Then
                    Beep()
                End If

                If curLine.IndexOf("<http://www.opengis.net/gml/_Feature>") = -1 Then
                    If curLine.IndexOf("(Arabic)") = -1 Then
                        If curLine.IndexOf("^^<http://www.w3.org/2001/XMLSchema#gYear>") = -1 Then
                            If curLine.IndexOf("<point>") = -1 Then
                                sw.WriteLine(curLine)

                                iLinesProcessed += 1
                            Else
                                Beep()
                            End If
                        End If
                    End If
                End If

                If iLinesProcessed Mod 50 = 0 Then
                    lblFluffRemovalProgress.Text = "Written " & iLinesProcessed & " lines..."

                    Application.DoEvents()
                End If

                If iLinesProcessed > _linesToProcess Then
                    Exit While
                End If
            End While

            sr.Close()
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            Try
                sr.Close()
            Catch ex As Exception

            End Try

            Try
                sw.Close()
            Catch ex As Exception

            End Try
        End Try
    End Sub

    Private Sub btFilterUndesirables_Click(sender As System.Object, e As System.EventArgs) Handles btFilterUndesirables.Click
        Dim sr As System.IO.StreamReader
        Dim sw As System.IO.StreamWriter
        Dim iLinesProcessed As Long = 0

        Dim strFilterTypes As String() = tbFilterUndesirablesSkipDatatypes.Text.Split(", ")
        Dim strFilterPredicates As String() = tbFilterUndesirablesSkipPredicates.Text.Split(", ")

        For iFilterType As Integer = 0 To strFilterTypes.Length - 1
            strFilterTypes(iFilterType) = "<" & strFilterTypes(iFilterType).Trim & ">"
        Next

        For iFilterPredicate As Integer = 0 To strFilterPredicates.Length - 1
            strFilterPredicates(iFilterPredicate) = "<" & strFilterPredicates(iFilterPredicate).Trim & ">"
        Next

        Try
            sr = New System.IO.StreamReader(tbFilterUndesirablesInputFile.Text)
            sw = New System.IO.StreamWriter(tbFilterUndesirablesOutputFile.Text, False)

            While sr.Peek <> -1
                Dim curLine As String = sr.ReadLine

                If Not curLine.StartsWith("<_") Then
                    Dim bTypeFilterOk As Boolean = True
                    Dim bPredicateFilterOk As Boolean = True

                    For Each strTypeFilter As String In strFilterTypes
                        If curLine.EndsWith(strTypeFilter) Then
                            bTypeFilterOk = False

                            Exit For
                        End If
                    Next

                    If bTypeFilterOk Then
                        For Each strPredicateFilter As String In strFilterPredicates
                            If curLine.IndexOf(strPredicateFilter) <> -1 Then
                                bPredicateFilterOk = False

                                Exit For
                            End If
                        Next
                    End If

                    If bTypeFilterOk And bPredicateFilterOk Then
                        sw.WriteLine(curLine)

                        iLinesProcessed += 1
                    Else

                    End If

                    If iLinesProcessed Mod 1000 = 0 Then
                        lblFilterUndesirablesProgress.Text = "Written " & iLinesProcessed & " lines..."

                        Application.DoEvents()
                    End If

                    If iLinesProcessed > _linesToProcess Then
                        Exit While
                    End If
                Else
                    Exit While
                End If
            End While

            sr.Close()
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            Try
                sr.Close()
            Catch ex As Exception

            End Try

            Try
                sw.Close()
            Catch ex As Exception

            End Try
        End Try
    End Sub



    Private Sub btToSCM_Click(sender As System.Object, e As System.EventArgs) Handles btToSCM.Click
        Dim sr As System.IO.StreamReader
        Dim sw As System.IO.StreamWriter
        Dim iLinesProcessed As Long = 0

        Try
            sr = New System.IO.StreamReader(tbToSCMInputFile.Text)
            sw = New System.IO.StreamWriter(tbToSCMOutputFile.Text, False)

            While sr.Peek <> -1
                Dim curLine As String = sr.ReadLine

                curLine = curLine.Replace("–", "-")

                '(EvaluationLink (av 0 0 0) (stv 1 1)
                '  (PredicateNode "HasA" (av 0 0 0) (stv 1 1))
                '  (ListLink (av 0 0 0) (stv 1 1)
                '    (ConceptNode "bird" (av 0 0 0) (stv 1 1))
                '    (ConceptNode "feather" (av 0 0 0) (stv 1 1))
                '  )
                ')

                Dim matches As MatchCollection = Regex.Matches(curLine, "<(\-?\w+)[^>]*>")
                Dim sb As New System.Text.StringBuilder

                If matches.Count = 3 Then
                    ' <Aristotle> 
                    ' <MainInterest>
                    ' <MetaPhysics>

                    sb.AppendLine("(EvaluationLink (av 0 0 0) (stv 1 1)")

                    sb.Append("  (PredicateNode """)
                    sb.Append(matches(1).ToString().Replace("<", "").Replace(">", ""))
                    sb.Append(""" (av 0 0 0) (stv 1 1))")
                    sb.Append(vbCrLf)

                    sb.AppendLine("  (ListLink (av 0 0 0) (stv 1 1)")

                    sb.Append("    (ConceptNode """)
                    sb.Append(matches(0).ToString().Replace("<", "").Replace(">", ""))
                    sb.Append(""" (av 0 0 0) (stv 1 1))")
                    sb.Append(vbCrLf)

                    sb.Append("    (ConceptNode """)
                    sb.Append(matches(2).ToString().Replace("<", "").Replace(">", ""))
                    sb.Append(""" (av 0 0 0) (stv 1 1))")
                    sb.Append(vbCrLf)

                    sb.AppendLine("  )")

                    sb.AppendLine(")")

                    sw.Write(sb.ToString())

                    iLinesProcessed += 1
                ElseIf matches.Count = 4 Then
                    Beep()
                Else
                    Beep()
                End If

                If iLinesProcessed Mod 1000 = 0 Then
                    lblToScmProgress.Text = "Filtered " & iLinesProcessed & " lines..."

                    Application.DoEvents()
                End If

                'If iLinesProcessed > 500 Then
                '    Exit While
                'End If
            End While

            sr.Close()
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            Try
                sr.Close()
            Catch ex As Exception

            End Try

            Try
                sw.Close()
            Catch ex As Exception

            End Try
        End Try
    End Sub

    Private Sub tbFluffRemovalInputFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbFluffRemovalInputFile.TextChanged
        tbFluffRemovalOutputFile.Text = tbFluffRemovalInputFile.Text.Replace(".ttl", " - NoFluff.ttl")
    End Sub

    Private Sub btFluffRemovalChooseTTLFile_Click(sender As System.Object, e As System.EventArgs) Handles btFluffRemovalChooseTTLFile.Click
        OpenFileDialog1.Filter = "TTL File | .ttl"

        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbFluffRemovalInputFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btFluffRemovalChooseOutputFile_Click(sender As System.Object, e As System.EventArgs) Handles btFluffRemovalChooseOutputFile.Click
        SaveFileDialog1.Filter = "TTL File | .ttl"

        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbFluffRemovalOutputFile.Text = SaveFileDialog1.FileName
        End If
    End Sub



    Private Sub tbFluffRemovalOutputFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbFluffRemovalOutputFile.TextChanged
        tbFilterUndesirablesInputFile.Text = tbFluffRemovalOutputFile.Text
    End Sub

    Private Sub btFilterUndesirablesChooseTTLFile_Click(sender As System.Object, e As System.EventArgs) Handles btFilterUndesirablesChooseTTLFile.Click
        OpenFileDialog1.Filter = "TTL File | .ttl"

        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbFilterUndesirablesInputFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btFilterUndesirablesChooseOutputFile_Click(sender As Object, e As System.EventArgs) Handles btFilterUndesirablesChooseOutputFile.Click
        SaveFileDialog1.Filter = "TTL File | .ttl"

        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbFilterUndesirablesOutputFile.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub tbFilterUndesirablesInputFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbFilterUndesirablesInputFile.TextChanged
        tbFilterUndesirablesOutputFile.Text = tbFilterUndesirablesInputFile.Text.Replace("NoFluff.ttl", "Filtered.ttl")
    End Sub



    Private Sub btFilterUndesirablesViewOutputSample_Click(sender As System.Object, e As System.EventArgs) Handles btFilterUndesirablesViewOutputSample.Click
        Dim oSampleViewer As New SampleViewer

        oSampleViewer.SampleFile = tbFilterUndesirablesOutputFile.Text

        oSampleViewer.ShowDialog(Me)

    End Sub

    Private Sub btRemoveFluffViewOutputSample_Click(sender As System.Object, e As System.EventArgs) Handles btRemoveFluffViewOutputSample.Click
        Dim oSampleViewer As New SampleViewer

        oSampleViewer.SampleFile = tbFluffRemovalOutputFile.Text

        oSampleViewer.ShowDialog(Me)

    End Sub

    Private Sub tbToSCMInputFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbToSCMInputFile.TextChanged
        tbToSCMOutputFile.Text = tbToSCMInputFile.Text.Replace(".ttl", ".scm")
    End Sub

    Private Sub btToSCMChooseTTLFile_Click(sender As System.Object, e As System.EventArgs) Handles btToSCMChooseTTLFile.Click
        OpenFileDialog1.Filter = "TTL File | .ttl"

        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbToSCMInputFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btToSCMChooseOutputFile_Click(sender As System.Object, e As System.EventArgs) Handles btToSCMChooseOutputFile.Click
        SaveFileDialog1.Filter = "SCM File | .scm"

        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbToSCMOutputFile.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub tbFilterUndesirablesOutputFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbFilterUndesirablesOutputFile.TextChanged
        tbToSCMInputFile.Text = tbFilterUndesirablesOutputFile.Text
    End Sub



    Private Sub btRemoveFluffViewInputSample_Click(sender As System.Object, e As System.EventArgs) Handles btRemoveFluffViewInputSample.Click
        Dim oSampleViewer As New SampleViewer

        oSampleViewer.SampleFile = tbFluffRemovalInputFile.Text

        oSampleViewer.ShowDialog(Me)

    End Sub

    Private Sub btFilterUndesirablesViewInputSample_Click(sender As System.Object, e As System.EventArgs) Handles btFilterUndesirablesViewInputSample.Click
        Dim oSampleViewer As New SampleViewer

        oSampleViewer.SampleFile = tbFilterUndesirablesInputFile.Text

        oSampleViewer.ShowDialog(Me)

    End Sub

    Private Sub btToSCMViewInputSample_Click(sender As System.Object, e As System.EventArgs) Handles btToSCMViewInputSample.Click
        Dim oSampleViewer As New SampleViewer

        oSampleViewer.SampleFile = tbToSCMInputFile.Text

        oSampleViewer.ShowDialog(Me)

    End Sub

    Private Sub btToSCMViewOutputSample_Click(sender As System.Object, e As System.EventArgs) Handles btToSCMViewOutputSample.Click
        Dim oSampleViewer As New SampleViewer

        oSampleViewer.SampleFile = tbToSCMOutputFile.Text

        oSampleViewer.ShowDialog(Me)
    End Sub
End Class
