Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Public Class Filtrete
    Private MyThermoStatus As ThermoStatus
    Private CurrentTemp As String
    Private OutsideLowTempThreshold As String
    Private LastFanToggleOn As Date
    Private iFanToggleOnInterval As Integer = 45
    Private iFanOnDuration As Integer = 10
    Private LastStatusCheck As Date
    Private iStatusCheckInterval As Integer = 5

    Public Event FTError(sMsg As String, ex As Exception)
    'Public Event WeatherStatusUpdated(sMsg As String)
    Public Event OutsideTempUpdated(sTemp As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FTError, AddressOf Me.FTErrorHandler
        Me.MyThermoStatus = New ThermoStatus
        Me.OutsideLowTempThreshold = 50

        AddHandler Me.MyThermoStatus.TSError, AddressOf Me.FTErrorHandler
        AddHandler Me.MyThermoStatus.TSUpdated, AddressOf Me.ThermoStatusUpdateHandler
        AddHandler Me.OutsideTempUpdated, AddressOf Me.OutSideTempUpdateHandler
        'DONE: simply include the curl in this app.  Run the command and get the output ie temperature.         'If curl is just using simple httppost can use that instead         'may have to get outside temp from web or something.          'C:\Users\Eric\Downloads\curl-7.56.1\I386>curl -d "{\"fmode\":0}" http://192.168.0.4/tstat
    End Sub

#Region "Controls"
    Private Sub tsbGetStatus_Click(sender As Object, e As EventArgs) Handles tsbGetStatus.Click
        rtbOutput.Text = rtbOutput.Text & (GetThermoStatus()) & vbNewLine 'This updates MyThermoStatus, if sucess calls ThermoStatusUpdated event handler which updaes controls.
        UpdateOutsideTemp
        Me.LastStatusCheck = Now
    End Sub

    Private Sub tsbFanState_Click(sender As Object, e As EventArgs) Handles tsbFanState.Click
        Select Case tsbFanState.CheckState
            Case CheckState.Checked
                ToggleFan(True)
            Case Else
                ToggleFan(False)
        End Select
    End Sub

#End Region

#Region "Functions"
    Private Sub FTErrorHandler(ByVal sMSG As String, ex As Exception)
        rtbOutput.Text = rtbOutput.Text & sMSG & "|" & GetExceptionInfo(ex) & vbNewLine
    End Sub

    Private Sub UpdateOutsideTemp()
        Try
            Dim sNewWeather = GetWeather("Fort Worth") 'Getweather gets the raw xml string from OpenWeather. 
            If sNewWeather <> "" Then
                Dim sNewTemp As String = WeatherStatusUpdate(sNewWeather) 'Send the raw xml for populate a CurrWeather object.
                If sNewTemp <> "" Then 'If success there..
                    Me.CurrentTemp = sNewTemp
                    RaiseEvent OutsideTempUpdated(sNewTemp)
                End If
            End If
        Catch ex As Exception
            RaiseEvent FTError("Error in: UpdateOutsideTemp: " & ex.Message, ex)
        End Try
    End Sub

    Public Function GetExceptionInfo(ex As Exception) As String
        Dim Result As String
        Dim hr As Integer = Runtime.InteropServices.Marshal.GetHRForException(ex)
        Result = ex.GetType.ToString & "(0x" & hr.ToString("X8") & "): " & ex.Message & Environment.NewLine & ex.StackTrace & Environment.NewLine
        Dim st As StackTrace = New StackTrace(ex, True)
        For Each sf As StackFrame In st.GetFrames
            If sf.GetFileLineNumber() > 0 Then
                Result &= "Line:" & sf.GetFileLineNumber() & " Filename: " & IO.Path.GetFileName(sf.GetFileName) & Environment.NewLine
            End If
        Next
        Return Result
    End Function

    Private Function WeatherStatusUpdate(ByVal sXml As String) As String 'We are just getting the temp, but should incorporate this inot class TODO
        Dim xs As New Xml.Serialization.XmlSerializer(GetType(CurrentWeatherFW.current)) ' = Nothing
        Dim sr As System.IO.StringReader = Nothing
        Dim fr As StreamReader
        Try
            's = s.Replace("<?xml version=""""1.0"""" encoding=""""UTF-8""""?>"" & vbLf & """, "") 'this didn't work
            's = s.Replace("""""", "")
            sr = New System.IO.StringReader(sXml)
            'xs = Xml.Serialization.XmlSerializer(GetType(CurrentWeather.current))
            'Dim nEf As CurrWeather
            Dim nef As CurrentWeatherFW.current  ' = xs.Deserialize(sr)
            'When getting with just CurrWeather, get 'there is an error in xml document 2,2 -- <c
            'So i changed CurrWeather to CurrWeather.current.  Then i get an error  [A] cannot be cast to [B] type a orginates...  Doesn't matter if i use New in front of CurrWeather.current either
            'xs = New Xml.Serialization.XmlSerializer(GetType(nef))
            'TODO: it seem sto not like <?xml version="1.0" encoding="UTF-8"?> - There is an error in XML document (1, 2). 
            Dim sNew As String = sr.ReadToEnd
            'sNew = sNew.Remove(0, 39)
            My.Computer.FileSystem.WriteAllText("CurrentWeatherFW.txt", sNew, False)
            fr = New StreamReader("CurrentWeatherFW.txt")
            'Dim fr As New StreamReader("temp.txt")
            nef = xs.Deserialize(fr)
            'nef = xs.Deserialize(sr)
            sr.Close()
            Return nef.temperature.value
        Catch ex As Exception
            RaiseEvent FTError("Error in: WeatherStatusUpdate FW: " & ex.Message, ex)
        Finally
            If fr IsNot Nothing Then fr.Dispose()
            If sr IsNot Nothing Then sr.Dispose()
            xs = Nothing
        End Try

        'XML coming up in different formats so going to try different formats. 
        Dim ys As New Xml.Serialization.XmlSerializer(GetType(CurrentWeatherFW2.current)) ' = Nothing
        Dim rr As System.IO.StringReader = Nothing
        Dim gr As StreamReader
        Try
            rr = New System.IO.StringReader(sXml)
            Dim nef As CurrentWeatherFW2.current  ' = ys.Deserialize(rr)
            Dim sNew As String = rr.ReadToEnd
            My.Computer.FileSystem.WriteAllText("CurrentWeatherFW2.txt", sNew, False)
            gr = New StreamReader("CurrentWeatherFW2.txt")
            nef = ys.Deserialize(gr)
            rr.Close()
            Return nef.temperature.value
        Catch ex As Exception
            RaiseEvent FTError("Error in: WeatherStatusUpdate FW2: " & ex.Message, ex)
        Finally
            If gr IsNot Nothing Then gr.Dispose()
            If rr IsNot Nothing Then rr.Dispose()
            xs = Nothing
        End Try

        'XML coming up in different formats so going to try different formats. 
        Dim zs As New Xml.Serialization.XmlSerializer(GetType(CurrentWeatherFW3.current)) ' = Nothing
        Dim qr As System.IO.StringReader = Nothing
        Dim hr As StreamReader
        Try
            qr = New System.IO.StringReader(sXml)
            Dim nef As CurrentWeatherFW3.current  ' = zs.Deserialize(rr)
            Dim sNew As String = qr.ReadToEnd
            My.Computer.FileSystem.WriteAllText("CurrentWeatherFW3.txt", sNew, False)
            hr = New StreamReader("CurrentWeatherFW3.txt")
            nef = zs.Deserialize(hr)
            qr.Close()
            Return nef.temperature.value
        Catch ex As Exception
            RaiseEvent FTError("Error in: WeatherStatusUpdate FW3: " & ex.Message, ex)
        Finally
            If hr IsNot Nothing Then hr.Dispose()
            If qr IsNot Nothing Then qr.Dispose()
            xs = Nothing
        End Try

        'XML coming up in different formats so going to try different formats. 
        'HEY! the reason the last xml didn't work with FW3 was this:
        'FW3:         Public Property min() As Byte
        'FW4:         Public Property min() As Decimal
        'The new xml that was coming up:<temperature value="47.14" min="42.8" 
        'Old xml sample:                <temperature value = "41.22" min="32"
        Dim x4s As New Xml.Serialization.XmlSerializer(GetType(CurrentWeatherFW4.current)) ' = Nothing
        Dim sr4 As System.IO.StringReader = Nothing
        Dim sr4b As StreamReader
        Try
            sr4 = New System.IO.StringReader(sXml)
            Dim nef As CurrentWeatherFW4.current  ' = x4s.Deserialize(rr)
            Dim sNew As String = sr4.ReadToEnd
            My.Computer.FileSystem.WriteAllText("CurrentWeatherFW4.txt", sNew, False)
            sr4b = New StreamReader("CurrentWeatherFW4.txt")
            nef = x4s.Deserialize(sr4b)
            sr4.Close()
            Return nef.temperature.value
        Catch ex As Exception
            RaiseEvent FTError("Error in: WeatherStatusUpdate FW4: " & ex.Message, ex)
        Finally
            If sr4b IsNot Nothing Then sr4b.Dispose()
            If sr4 IsNot Nothing Then sr4.Dispose()
            xs = Nothing
        End Try

        'If we get here both have failed.
        rtbOutput.Text = rtbOutput.Text & "Both xml decodes have failed." & vbNewLine
    End Function

    Private Sub OutSideTempUpdateHandler(ByVal sTemp As String)
        Try
            If sTemp.Trim = "" Then Exit Sub
            lOutsideTemp.Text = sTemp
            rtbOutput.Text = rtbOutput.Text & " Outside temp: " & sTemp
            'CheckIfTimeToTurnOnFan
        Catch ex As Exception
            RaiseEvent FTError("Error in: OutSideTempUpdateHandler: " & ex.Message, ex)
        End Try
    End Sub

    Private Sub CheckIfTimeToTurnOnFan()
        Try
            'Firstly, check if the tmeperature outside is below threshold.
            If Me.OutsideLowTempThreshold.Trim = "" Or Me.CurrentTemp.Trim = "" Then Exit Sub
            If Not IsNumeric(Me.OutsideLowTempThreshold) Or Not IsNumeric(Me.CurrentTemp) Then Exit Sub
            If Me.MyThermoStatus.FanMode = "2" Then Exit Sub 'Exit if already on. 

            If CInt(Me.CurrentTemp) <= CInt(Me.OutsideLowTempThreshold) Then 'Action
                If Me.LastFanToggleOn = DateTime.MinValue OrElse DateDiff(DateInterval.Minute, Me.LastFanToggleOn, Now) > Me.iFanToggleOnInterval Then
                    Me.LastFanToggleOn = Now
                    rtbOutput.Text = rtbOutput.Text & "Time to turn on fan: " & Now
                    ToggleFan(True)
                End If
            End If

        Catch ex As Exception
            RaiseEvent FTError("Error in: CheckIfTimeToTurnOnFan: " & ex.Message, ex)
        End Try
    End Sub

    Private Sub CheckIfTimeToShutOffFan()
        Try
            'Firstly, check if the tmeperature outside is below threshold.
            If Me.MyThermoStatus.FanMode = "0" Then Exit Sub 'Exit if already off. 

            If DateDiff(DateInterval.Minute, Me.LastFanToggleOn, Now) > Me.iFanOnDuration Or CInt(lOutsideTemp.Text) > Me.OutsideLowTempThreshold Then
                'Me.LastFanToggleOn = Now
                rtbOutput.Text = rtbOutput.Text & "Time to shut off fan: " & Now & vbNewLine
                ToggleFan(False)
                GetThermoStatus()

            End If

        Catch ex As Exception
            RaiseEvent FTError("Error in: CheckIfTimeToShutOffFan: " & ex.Message, ex)
        End Try
    End Sub
    Private Sub ThermoStatusUpdateHandler(ByVal sMsg As String)
        Try
            Select Case Me.MyThermoStatus.FanMode
                Case "0"
                    lFanMode.Text = "AUTO"
                Case "1"
                    lFanMode.Text = "AUTO/CIRC"
                Case "2"
                    lFanMode.Text = "ON"
            End Select

            Select Case Me.MyThermoStatus.Mode
                Case "0"
                    lMode.Text = "OFF"
                Case "1"
                    lMode.Text = "HEAT"
                Case "2"
                    lMode.Text = "COOL"
                Case "3"
                    lMode.Text = "AUTO"
            End Select

            lInsideTemp.Text = Me.MyThermoStatus.InsideTemp
            lSelectedTemp.Text = Me.MyThermoStatus.SelectedTemperature
            lOutsideTemp.Text = Me.MyThermoStatus.OutsideTemp
        Catch ex As Exception
            RaiseEvent FTError("Error in: ThermoStatusUpdated: " & ex.Message, ex)
        End Try
    End Sub

    Private Function GetThermoStatus() As String
        Try
            ' Create a request for the URL.   
            Dim request As WebRequest =
             WebRequest.Create("http://192.168.0.4/tstat")
            ' If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials
            ' Get the response.  
            Dim response As WebResponse = request.GetResponse()
            ' Display the status.  
            rtbOutput.Text = rtbOutput.Text & (CType(response, HttpWebResponse).StatusDescription) & vbNewLine
            ' Get the stream containing content returned by the server.  
            Dim dataStream As Stream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.  
            Dim reader As New StreamReader(dataStream)
            ' Read the content.  
            Dim responseFromServer As String = reader.ReadToEnd()

            ' Clean up the streams and the response.  
            reader.Close()
            response.Close()
            Me.MyThermoStatus.UpdateStatus(responseFromServer)
            Return responseFromServer
        Catch ex As Exception
            RaiseEvent FTError("Error in: Public Class Filtrete: " & ex.Message, ex)
        End Try
    End Function

    Private Function GetWeather(sLocation As String) As String ' As Task(Of String)  ' As Task(Of String)
        Try
            Dim weatherService As New OpenWeatherMapService
            Dim CurrentWeather As New WeatherForecast
            Try
                Dim weather = weatherService.GetForecastAsync(sLocation, 3)
                'Debug.Print(weather)
                Return weather 'Raw xml string
                'CurrentWeather = weather.First
                'Forecast = weather.Skip(1).Take(2).ToList
            Catch ex As HttpRequestException
                'dialogService.ShowNotification("Ensure you're connected to the internet!", "Open Weather")
                'Catch ex As LocationNotFoundException
                'dialogService.ShowNotification("Location not found!", "Open Weather")
            End Try
        Catch ex As Exception
            RaiseEvent FTError("Error in: GetWeather: " & ex.Message, ex)
        End Try
    End Function

    Private Function ToggleFan(Optional ByVal Onn As Boolean = True) As String
        Try
            Dim sMode As String
            If Onn Then
                sMode = "2"
            Else
                sMode = "0" 'Also exists option 1 for auto/circulate, but i think this is for another model.
            End If
            'http://howtostartprogramming.com/vb-net/vb-net-tutorial-51-httpwebrequest-post-method/
            Dim postData As String = "{""fmode"":" & sMode & "}" 'This was almost working: """{""fmode:"":2}""" ' "referer=http%3A%2F%2Fforums.zybez.net%2Findex.php%3Fapp%3Dcore%26module%3Dglobal%26section%3Dlogin&username=" & TextBox1.Text & "&password=" & TextBox2.Text & "&rememberMe=1"
            Dim tempCookies As New CookieContainer
            Dim encoding As New UTF8Encoding
            Dim byteData As Byte() = encoding.GetBytes(postData)

            Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.0.4/tstat"), HttpWebRequest)
            postReq.Method = "POST"
            postReq.KeepAlive = True
            postReq.CookieContainer = tempCookies
            postReq.ContentType = "application/x-www-form-urlencoded"
            postReq.Referer = "" ' "http://forums.zybez.net/index.php?app=core&module=global&section=login&do=process"
            postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
            postReq.ContentLength = byteData.Length

            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()
            Dim postresponse As HttpWebResponse

            postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            tempCookies.Add(postresponse.Cookies)
            'logincookie = tempCookies
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

            Dim thepage As String = postreqreader.ReadToEnd

            rtbOutput.Text = rtbOutput.Text & thepage & vbNewLine & "Fan toggled "
            If Onn Then
                rtbOutput.Text = rtbOutput.Text & " on :"
            Else
                rtbOutput.Text = rtbOutput.Text & " off :"
            End If
            rtbOutput.Text = rtbOutput.Text & Now & vbNewLine
        Catch ex As Exception
            RaiseEvent FTError("Error in: ToggleFan: " & ex.Message, ex)
        End Try
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Every 5 minutes Update status, then check if time to toggle fan,
            If Me.LastStatusCheck = DateTime.MinValue OrElse DateDiff(DateInterval.Minute, Me.LastStatusCheck, Now) > Me.iStatusCheckInterval Then
                'Time to check/toggle
                Me.tsbGetStatus_Click(Nothing, Nothing) 'Triggers getthermostatus.
                CheckIfTimeToTurnOnFan()
            End If
            CheckIfTimeToShutOffFan()
            If lOutsideTemp.Text = "" Then UpdateOutsideTemp()
        Catch ex As Exception
            RaiseEvent FTError("Error in: Timer1_Tick: " & ex.Message, ex)
        End Try
    End Sub
    Private Sub Test()

    End Sub
#End Region
End Class
