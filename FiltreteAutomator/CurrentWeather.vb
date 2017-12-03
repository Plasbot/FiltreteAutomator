Public Class CurrentWeather

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class current

        Private cityField As currentCity

        Private temperatureField As currentTemperature

        Private humidityField As currentHumidity

        Private pressureField As currentPressure

        Private windField As currentWind

        Private cloudsField As currentClouds

        Private visibilityField As currentVisibility

        Private precipitationField As currentPrecipitation

        Private weatherField As currentWeather

        Private lastupdateField As currentLastupdate

        '''<remarks/>
        Public Property city() As currentCity
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property temperature() As currentTemperature
            Get
                Return Me.temperatureField
            End Get
            Set
                Me.temperatureField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property humidity() As currentHumidity
            Get
                Return Me.humidityField
            End Get
            Set
                Me.humidityField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property pressure() As currentPressure
            Get
                Return Me.pressureField
            End Get
            Set
                Me.pressureField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property wind() As currentWind
            Get
                Return Me.windField
            End Get
            Set
                Me.windField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property clouds() As currentClouds
            Get
                Return Me.cloudsField
            End Get
            Set
                Me.cloudsField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property visibility() As currentVisibility
            Get
                Return Me.visibilityField
            End Get
            Set
                Me.visibilityField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property precipitation() As currentPrecipitation
            Get
                Return Me.precipitationField
            End Get
            Set
                Me.precipitationField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property weather() As currentWeather
            Get
                Return Me.weatherField
            End Get
            Set
                Me.weatherField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property lastupdate() As currentLastupdate
            Get
                Return Me.lastupdateField
            End Get
            Set
                Me.lastupdateField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentCity

        Private coordField As currentCityCoord

        Private countryField As String

        Private sunField As currentCitySun

        Private idField As UInteger

        Private nameField As String

        '''<remarks/>
        Public Property coord() As currentCityCoord
            Get
                Return Me.coordField
            End Get
            Set
                Me.coordField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property country() As String
            Get
                Return Me.countryField
            End Get
            Set
                Me.countryField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property sun() As currentCitySun
            Get
                Return Me.sunField
            End Get
            Set
                Me.sunField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property id() As UInteger
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentCityCoord

        Private lonField As Decimal

        Private latField As Decimal

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property lon() As Decimal
            Get
                Return Me.lonField
            End Get
            Set
                Me.lonField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property lat() As Decimal
            Get
                Return Me.latField
            End Get
            Set
                Me.latField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentCitySun

        Private riseField As Date

        Private setField As Date

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property rise() As Date
            Get
                Return Me.riseField
            End Get
            Set
                Me.riseField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property [set]() As Date
            Get
                Return Me.setField
            End Get
            Set
                Me.setField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentTemperature

        Private valueField As Decimal

        Private minField As Decimal

        Private maxField As Decimal

        Private unitField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As Decimal
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property min() As Decimal
            Get
                Return Me.minField
            End Get
            Set
                Me.minField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property max() As Decimal
            Get
                Return Me.maxField
            End Get
            Set
                Me.maxField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property unit() As String
            Get
                Return Me.unitField
            End Get
            Set
                Me.unitField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentHumidity

        Private valueField As Byte

        Private unitField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As Byte
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property unit() As String
            Get
                Return Me.unitField
            End Get
            Set
                Me.unitField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentPressure

        Private valueField As UShort

        Private unitField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As UShort
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property unit() As String
            Get
                Return Me.unitField
            End Get
            Set
                Me.unitField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentWind

        Private speedField As currentWindSpeed

        Private gustsField As Object

        Private directionField As currentWindDirection

        '''<remarks/>
        Public Property speed() As currentWindSpeed
            Get
                Return Me.speedField
            End Get
            Set
                Me.speedField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property gusts() As Object
            Get
                Return Me.gustsField
            End Get
            Set
                Me.gustsField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property direction() As currentWindDirection
            Get
                Return Me.directionField
            End Get
            Set
                Me.directionField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentWindSpeed

        Private valueField As Decimal

        Private nameField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As Decimal
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentWindDirection

        Private valueField As Byte

        Private codeField As String

        Private nameField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As Byte
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property code() As String
            Get
                Return Me.codeField
            End Get
            Set
                Me.codeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentClouds

        Private valueField As Byte

        Private nameField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As Byte
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentVisibility

        Private valueField As UShort

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As UShort
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentPrecipitation

        Private modeField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property mode() As String
            Get
                Return Me.modeField
            End Get
            Set
                Me.modeField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentWeather

        Private numberField As UShort

        Private valueField As String

        Private iconField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property number() As UShort
            Get
                Return Me.numberField
            End Get
            Set
                Me.numberField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property icon() As String
            Get
                Return Me.iconField
            End Get
            Set
                Me.iconField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class currentLastupdate

        Private valueField As Date

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property value() As Date
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = Value
            End Set
        End Property
    End Class


End Class
