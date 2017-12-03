
Imports System.Net.Http
Imports System.IO

Imports System.Net
'From: https://www.codeproject.com/Articles/630248/WPF-OpenWeather
'https://github.com/MeshackMusundi/OpenWeather
Public Class OpenWeatherMapService
    'Implements IWeatherService

    Private Const APP_ID As String = "d26ae60817dc1c1e981397177df455e7"
    Private Const MAX_FORECAST_DAYS As Integer = 5
        Private client As HttpClient


        Public Sub New()
            client = New HttpClient
            client.BaseAddress = New Uri("http://api.openweathermap.org/data/2.5/")
        End Sub

    Public Function GetForecastAsync(location As String, days As Integer) As String ' As Task(Of String) 'Of IEnumerable(Of WeatherForecast)) Implements IWeatherService.GetForecastAsync
        If location Is Nothing Then Throw New ArgumentNullException("Location can't be null.")
        If location = String.Empty Then Throw New ArgumentException("Location can't be an empty string.")
        If days <= 0 Then Throw New ArgumentOutOfRangeException("Days should be greater than zero.")
        If days > MAX_FORECAST_DAYS Then Throw New ArgumentOutOfRangeException($"Days can't be greater than {MAX_FORECAST_DAYS}.")

        'Dim query = $"forecast/daily?q={location}&type=accurate&mode=xml&units=metric&cnt={days}&appid={APP_ID}"
        Dim query = $"weather?q={location}&units=imperial&mode=xml&APPID={APP_ID}"
        query = "http://api.openweathermap.org/data/2.5/" & query
        'http://api.openweathermap.org/data/2.5/weather?q=Berlin&APPID=d26ae60817dc1c1e981397177df455e7
        Dim req As WebRequest = WebRequest.Create(query)
        Dim response As WebResponse = req.GetResponse()
        Dim datas As Stream = response.GetResponseStream
        Dim srr As New StreamReader(datas)
        Return srr.ReadToEnd()
        Return response.ToString
        'Dim response = WebRequest(query) ' client.GetAsync(query)

        'Select Case response.StatusCode
        '    Case HttpStatusCode.Unauthorized
        '        Throw New Exception("invalid api key") ' UnauthorizedApiAccessException("Invalid API key.")
        '    Case HttpStatusCode.NotFound
        '        Throw New Exception("loc not found")' LocationNotFoundException("Location not found.")
        '    Case HttpStatusCode.OK
        '        Dim s = Await response.Content.ReadAsStringAsync()
        '        Return s
        '        Dim xs As New Xml.Serialization.XmlSerializer(GetType(CurrentWeather.current)) ' = Nothing
        '        Dim sr As System.IO.StringReader = Nothing
        '        's = s.Replace("<?xml version=""""1.0"""" encoding=""""UTF-8""""?>"" & vbLf & """, "") 'this didn't work
        '        's = s.Replace("""""", "")
        '        sr = New System.IO.StringReader(s)
        '        'xs = Xml.Serialization.XmlSerializer(GetType(CurrentWeather.current))
        '        'Dim nEf As CurrWeather
        '        Dim nef As New CurrWeather.current ' = xs.Deserialize(sr)
        '        'When getting with just CurrWeather, get 'there is an error in xml document 2,2 -- <c
        '        'So i changed CurrWeather to CurrWeather.current.  Then i get an error  [A] cannot be cast to [B] type a orginates...  Doesn't matter if i use New in front of CurrWeather.current either
        '        'xs = New Xml.Serialization.XmlSerializer(GetType(nef))

        '        nef = xs.Deserialize(sr)

        '        sr.Close()
        '        'Return nef

        '        Dim x = XElement.Load(New StringReader(s))
        '        Dim data = x...<time>.Select(Function(w) New WeatherForecast With {
        '                                         .Description = w.<symbol>.@name,
        '                                         .ID = w.<symbol>.@number,
        '                                         .IconID = w.<symbol>.@var,
        '                                         .[Date] = w.@day,
        '                                         .WindType = w.<windSpeed>.@name,
        '                                         .WindSpeed = w.<windSpeed>.@mps,
        '                                         .WindDirection = w.<windDirection>.@code,
        '                                         .DayTemperature = w.<temperature>.@day,
        '                                         .NightTemperature = w.<temperature>.@night,
        '                                         .MaxTemperature = w.<temperature>.@max,
        '                                         .MinTemperature = w.<temperature>.@min,
        '                                         .Pressure = w.<pressure>.@value,
        '                                         .Humidity = w.<humidity>.@value})
        '        Return data
        '    Case Else
        '        Throw New NotImplementedException(response.StatusCode.ToString())
        'End Select
    End Function
End Class


