<Extension()>
Public Function ResizeKeepAspect(ByVal src As Size, ByVal maxWidth As Integer, ByVal maxHeight As Integer, ByVal Optional fillToMax As Boolean = False) As Size
    maxWidth = If(fillToMax, maxWidth, Math.Min(maxWidth, src.Width))
    maxHeight = If(fillToMax, maxHeight, Math.Min(maxHeight, src.Height))
    Dim rnd = Math.Min(maxWidth / CDec(src.Width), maxHeight / CDec(src.Height))
    Dim newSize As Size = New Size(Math.Round(src.Width * rnd), Math.Round(src.Height * rnd))
    Return newSize
End Function
