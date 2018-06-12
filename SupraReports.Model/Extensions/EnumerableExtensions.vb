Imports System.Runtime.CompilerServices

Module EnumerableExtensions
  <Extension()>
  Public Function Except(Of T, TKey)(ByVal items As IEnumerable(Of T), ByVal other As IEnumerable(Of T), ByVal getKey As Func(Of T, TKey)) As IEnumerable(Of T)
    Dim a =
      From item In items
      Group Join otherItem In other
        On getKey(item) Equals getKey(otherItem)
        Into tempItems = Group
      From temp In tempItems.DefaultIfEmpty()
      Where temp Is Nothing
      Select item
    Return a
  End Function
End Module
