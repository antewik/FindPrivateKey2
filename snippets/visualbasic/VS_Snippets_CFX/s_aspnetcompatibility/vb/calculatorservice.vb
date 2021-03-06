'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
 System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples")>  _
Public Interface ICalculatorSession
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Clear", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/ClearResponse")>  _
    Sub Clear()
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/AddTo", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/AddToResponse")>  _
    Sub AddTo(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/SubtractFrom", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/SubtractFromResponse")>  _
    Sub SubtractFrom(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/MultiplyBy", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/MultiplyByResponse")>  _
    Sub MultiplyBy(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/DivideBy", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/DivideByResponse")>  _
    Sub DivideBy(ByVal n As Double)
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Equal", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/EqualResponse")>  _
    Function Equal() As Double
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Public Interface ICalculatorSessionChannel
    Inherits ICalculatorSession, System.ServiceModel.IClientChannel
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Partial Public Class CalculatorSessionClient
    Inherits System.ServiceModel.ClientBase(Of ICalculatorSession)
    Implements ICalculatorSession
    
    Public Sub New()
        MyBase.New
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String)
        MyBase.New(endpointConfigurationName)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub
    
    Public Sub Clear() Implements ICalculatorSession.Clear
        MyBase.Channel.Clear
    End Sub
    
    Public Sub AddTo(ByVal n As Double) Implements ICalculatorSession.AddTo
        MyBase.Channel.AddTo(n)
    End Sub
    
    Public Sub SubtractFrom(ByVal n As Double) Implements ICalculatorSession.SubtractFrom
        MyBase.Channel.SubtractFrom(n)
    End Sub
    
    Public Sub MultiplyBy(ByVal n As Double) Implements ICalculatorSession.MultiplyBy
        MyBase.Channel.MultiplyBy(n)
    End Sub
    
    Public Sub DivideBy(ByVal n As Double) Implements ICalculatorSession.DivideBy
        MyBase.Channel.DivideBy(n)
    End Sub
    
    Public Function Equal() As Double Implements ICalculatorSession.Equal
        Return MyBase.Channel.Equal
    End Function
End Class
