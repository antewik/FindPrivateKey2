' <snippet1>
Imports System.Threading.Tasks
Imports System.Threading.Tasks.Dataflow

' Demonstrates a how to write to and read from a dataflow block.
Friend Class DataflowReadWrite
   ' Demonstrates asynchronous dataflow operations.
   Private Shared async Function AsyncSendReceive(ByVal bufferBlock As BufferBlock(Of Integer)) As Task
      ' <snippet5>
      ' Post more messages to the block asynchronously.
      For i As Integer = 0 To 2
         await bufferBlock.SendAsync(i)
      Next i

      ' Asynchronously receive the messages back from the block.
      For i As Integer = 0 To 2
         Console.WriteLine(await bufferBlock.ReceiveAsync())
      Next i

'       Output:
'         0
'         1
'         2
'       
      ' </snippet5>
   End Function

   Shared Sub Main(ByVal args() As String)
      ' <snippet2>
      ' Create a BufferBlock<int> object.
      Dim bufferBlock = New BufferBlock(Of Integer)()

      ' Post several messages to the block.
      For i As Integer = 0 To 2
         bufferBlock.Post(i)
      Next i

      ' Receive the messages back from the block.
      For i As Integer = 0 To 2
         Console.WriteLine(bufferBlock.Receive())
      Next i

'       Output:
'         0
'         1
'         2
'       
      ' </snippet2>

      ' <snippet3>
      ' Post more messages to the block.
      For i As Integer = 0 To 2
         bufferBlock.Post(i)
      Next i

      ' Receive the messages back from the block.
      Dim value As Integer
      Do While bufferBlock.TryReceive(value)
         Console.WriteLine(value)
      Loop

'       Output:
'         0
'         1
'         2
'       
      ' </snippet3>

      ' <snippet4>
      ' Write to and read from the message block concurrently.
      Dim post01 = Task.Run(Sub()
          bufferBlock.Post(0)
          bufferBlock.Post(1)
      End Sub)
      Dim receive = Task.Run(Sub()
            For i As Integer = 0 To 2
               Console.WriteLine(bufferBlock.Receive())
            Next i
      End Sub)
      Dim post2 = Task.Run(Sub() bufferBlock.Post(2))
      Task.WaitAll(post01, receive, post2)

'       Sample output:
'         2
'         0
'         1
'       
      ' </snippet4>

      ' Demonstrate asynchronous dataflow operations.
      AsyncSendReceive(bufferBlock).Wait()
   End Sub

End Class
' </snippet1>
