Namespace Utilities
    Public Class CalcUtility

        Private _value1 As Double
        Private _value2 As Double

        Property value1 As Double
            Get
                Return _value1
            End Get
            Set(value As Double)
                _value1 = value
            End Set
        End Property
        Property value2 As Double
            Get
                Return _value2
            End Get
            Set(value As Double)
                _value2 = value
            End Set
        End Property

        Public Function AddValues() As Double
            Return value1 + value2
        End Function
        Public Function SubtractValues() As Double
            Return value1 - value2
        End Function
        Public Function MultiplyValues() As Double
            Return value1 * value2
        End Function
        Public Function DivideValues() As Double
            Return value1 / value2
        End Function
    End Class

End Namespace


