' Visual Basic .NET Document
Option Strict On

' <Snippet1>
Imports System.Globalization
Imports System.Text
Imports System.Threading

Module Example

   Public Sub Main()
      Console.OutputEncoding = Encoding.UTF8 
      ' Change current culture
      Dim culture As CultureInfo
      If Thread.CurrentThread.CurrentCulture.Name = "fr-FR" Then
         culture = CultureInfo.CreateSpecificCulture("en-US")
      Else
         culture = CultureInfo.CreateSpecificCulture("fr-FR")
      End If   
      Thread.CurrentThread.CurrentCulture = culture
      Thread.CurrentThread.CurrentUICulture = culture
      
      ' Generate and display three random numbers on the current thread.
      DisplayRandomNumbers()
      Thread.Sleep(1000)
      
      Dim workerThread As New Thread(AddressOf Example.DisplayRandomNumbers)
      workerThread.Start()
   End Sub
   
   Private Sub DisplayRandomNumbers()
      Console.WriteLine()
      Console.WriteLine("Current Culture:    {0}", 
                        Thread.CurrentThread.CurrentCulture)
      Console.WriteLine("Current UI Culture: {0}", 
                        Thread.CurrentThread.CurrentUICulture)

      Console.Write("Random Values: ")
      Dim rand As New Random()
      For ctr As Integer = 0 To 2
         Console.Write("     {0:C2}     ", rand.NextDouble())
      Next      
      Console.WriteLine()
   End Sub
End Module
' The example displays output similar to the following:
'    Current Culture:    fr-FR
'    Current UI Culture: fr-FR
'    Random Values:      0,77 €          0,35 €          0,52 €     
'    
'    Current Culture:    en-US
'    Current UI Culture: en-US
'    Random Values:      $0.30          $0.79          $0.65     
' </Snippet1>

