Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.IO

Public Class PDFGenerator
    Public Sub GeneratePDF(reportType As String, reportData As DataGridView)
        ' Define the PDF document
        Dim pdf As New PdfDocument()
        pdf.Info.Title = reportType
        Dim page As PdfPage = pdf.AddPage()

        ' Set landscape orientation
        page.Orientation = PdfSharp.PageOrientation.Landscape
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        ' Define fonts
        Dim titleFont As New XFont("Arial", 20, XFontStyleEx.Bold)
        Dim regularFont As New XFont("Arial", 12, XFontStyleEx.Regular)

        ' Margins and positioning
        Dim leftMargin As Double = 40
        Dim rightMargin As Double = page.Width.Point - 40
        Dim yPosition As Double = 40

        ' Load and draw the logo (Aligned with Title, Upper Right)
        Dim logoSize As Double = 50
        Dim logoX As Double = rightMargin - logoSize
        Dim logoY As Double = yPosition

        Dim appPath As String = Application.StartupPath
        Dim logoPath As String = Path.Combine(appPath, "ImagesAndLogo", "images.jpg")

        If File.Exists(logoPath) Then
            Dim img As XImage = XImage.FromFile(logoPath)
            gfx.DrawImage(img, logoX, logoY, logoSize, logoSize)
        End If

        ' Draw the Report Title (Upper Left)
        gfx.DrawString("Task Report - " & reportType, titleFont, XBrushes.Black, New XPoint(leftMargin, yPosition + 20))

        ' Move down for table (Adjust for title and logo space)
        yPosition += 80

        ' Draw Table
        DrawTable(gfx, reportData, yPosition, page)

        ' Save Path
        Dim reportsFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Task Reports")
        If Not Directory.Exists(reportsFolder) Then
            Directory.CreateDirectory(reportsFolder)
        End If
        Dim savePath As String = Path.Combine(reportsFolder, "Task Report (" & reportType & ").pdf")

        ' Save the PDF
        pdf.Save(savePath)
        pdf.Close()
        MessageBox.Show("PDF saved to: " & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Draw Table with Row Padding and Word Wrap for "Problem" Column
    Private Sub DrawTable(gfx As XGraphics, reportData As DataGridView, yPos As Double, page As PdfPage)
        Dim startX As Double = 40
        Dim columnWidth As Double = (page.Width.Point - 80) / reportData.ColumnCount
        Dim rowHeight As Double = 20
        Dim rowPadding As Double = 5 ' Add padding above and below text
        Dim font As New XFont("Arial", 10, XFontStyleEx.Regular)
        Dim boldFont As New XFont("Arial", 10, XFontStyleEx.Bold)

        ' Column Headers
        For col As Integer = 0 To reportData.ColumnCount - 1
            Dim headerText As String = reportData.Columns(col).HeaderText
            Dim rect As New XRect(startX + (col * columnWidth), yPos, columnWidth, rowHeight + (2 * rowPadding))
            gfx.DrawRectangle(XPens.Black, rect)
            gfx.DrawString(headerText, boldFont, XBrushes.Black, rect, XStringFormats.Center)
        Next
        yPos += rowHeight + (2 * rowPadding) ' Move to next row

        ' Draw Rows
        For row As Integer = 0 To reportData.RowCount - 1
            Dim maxRowHeight As Double = rowHeight + (2 * rowPadding) ' Track max height for wrapped text
            Dim wrappedText As New Dictionary(Of Integer, String()) ' Store wrapped text

            For col As Integer = 0 To reportData.ColumnCount - 1
                Dim cellText As String = If(reportData.Rows(row).Cells(col).Value IsNot Nothing, reportData.Rows(row).Cells(col).Value.ToString(), "")

                ' If it's the "Problem" column, wrap text
                If reportData.Columns(col).HeaderText = "Problem" Then
                    wrappedText(col) = WrapText(gfx, cellText, font, columnWidth)
                    maxRowHeight = wrappedText(col).Length * (rowHeight + (2 * rowPadding))
                Else
                    wrappedText(col) = {cellText} ' No wrapping needed
                End If
            Next

            ' Draw each cell
            For col As Integer = 0 To reportData.ColumnCount - 1
                Dim rect As New XRect(startX + (col * columnWidth), yPos, columnWidth, maxRowHeight)
                gfx.DrawRectangle(XPens.Black, rect)

                ' Print wrapped text line by line with padding
                Dim lineY As Double = yPos + rowPadding ' Start text after padding
                For Each line As String In wrappedText(col)
                    gfx.DrawString(line, font, XBrushes.Black, New XRect(rect.X, lineY, columnWidth, rowHeight), XStringFormats.TopCenter)
                    lineY += rowHeight ' Move to next line
                Next
            Next
            yPos += maxRowHeight ' Move to the next row
        Next
    End Sub

    ' Wrap text into multiple lines to fit inside a cell
    Private Function WrapText(gfx As XGraphics, text As String, font As XFont, columnWidth As Double) As String()
        Dim wrappedLines As New List(Of String)()
        Dim words As String() = text.Split(" "c)
        Dim currentLine As String = ""

        For Each word In words
            Dim testLine As String = If(currentLine = "", word, currentLine & " " & word)
            Dim textSize As XSize = gfx.MeasureString(testLine, font)

            If textSize.Width > columnWidth Then
                wrappedLines.Add(currentLine)
                currentLine = word
            Else
                currentLine = testLine
            End If
        Next

        If currentLine <> "" Then
            wrappedLines.Add(currentLine)
        End If

        Return wrappedLines.ToArray()
    End Function
End Class
