Public Class ThermoStatus
    Public Event TSError(ByVal sMsg As String, ex As Exception)
    Public Event TSUpdated(ByVal sBlah As String)
#Region "properties"


    Private _OutsideTemp As String
    Public Property OutsideTemp() As String
        Get
            Return _OutsideTemp
        End Get
        Set(ByVal value As String)
            _OutsideTemp = value
        End Set
    End Property

    Private _InsideTemp As String
    Public Property InsideTemp() As String
        Get
            Return _InsideTemp
        End Get
        Set(ByVal value As String)
            _InsideTemp = value
        End Set
    End Property

    Private _SelectedTemperature As String
    Public Property SelectedTemperature() As String
        Get
            Return _SelectedTemperature
        End Get
        Set(ByVal value As String)
            _SelectedTemperature = value
        End Set
    End Property

    Private _Mode As String
    Public Property Mode() As String
        Get
            Return _Mode
        End Get
        Set(ByVal value As String)
            _Mode = value
        End Set
    End Property

    Private _FanMode As String
    Public Property FanMode() As String
        Get
            Return _FanMode
        End Get
        Set(ByVal value As String)
            _FanMode = value
        End Set
    End Property
#End Region
#Region "Functions"
    Public Function UpdateStatus(ByVal sThermoStatus As String) As String
        Try
            If sThermoStatus.Trim = "" Then Return ""
            'So we get a line like this:
            '{"temp":77.50,"tmode":1,"fmode":0,"override":0,"hold":0,"t_heat":70.00,"tstate":0,"fstate":0,"time":{"day":1,"hour":22,"minute":48},"t_type_post":0}
            sThermoStatus = sThermoStatus.Replace(Chr(34), "") 'Get rid of pesky quotes.
            'Split and loop through, use a case statement to update props.
            Dim sArr() As String = Split(sThermoStatus, ",")
            For Each Str As String In sArr
                Str = Str.Replace("{", "").Replace("}", "")
                Dim sPair() As String = Split(Str, ":")
                If sPair.GetUpperBound(0) > 0 Then
                    Debug.Print(sPair(0) & " - " & sPair(1))
                    Select Case sPair(0) 'The label
                        Case "temp"
                            Me.InsideTemp = sPair(1)
                        Case "tmode"
                            Me.Mode = sPair(1)
                        Case "fmode"
                            Me.FanMode = sPair(1)
                        Case "override"
                        Case "hold"
                        Case "t_heat"
                            Me.SelectedTemperature = sPair(1) 'The check for 0 is maybe uncessary, i thought it defaults to 0 val when mode is not on heat, but what happes is it only sends either t_heat or t_cool
                        Case "t_cool"
                            Me.SelectedTemperature = sPair(1)
                        Case "tstate"
                        Case "fstate"
                        Case "time"
                        Case "day"
                        Case "hour"
                        Case "minute"
                        Case "t_type_post"
                        Case Else
                            RaiseEvent TSError("UpdateStatus: Unknown element found in thermo status." & sPair(0) & " - " & sPair(1), New Exception())
                    End Select
                End If

            Next

            RaiseEvent TSUpdated(Now.ToString)
            Return sThermoStatus
        Catch ex As Exception
            RaiseEvent TSError("Error in: UpdateStatus: " & ex.Message, ex)
        End Try
    End Function

    Private Sub test()

    End Sub
#End Region
End Class
