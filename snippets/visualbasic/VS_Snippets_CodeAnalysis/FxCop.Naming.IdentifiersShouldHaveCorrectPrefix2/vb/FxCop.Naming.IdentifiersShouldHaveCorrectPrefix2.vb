'<Snippet1>
Namespace Samples

    Public Interface IBook  ' Fixes the violation by prefixing the interface with 'I'

        ReadOnly Property Title() As String

        Sub Read()

    End Interface

End Namespace
'</Snippet1>

