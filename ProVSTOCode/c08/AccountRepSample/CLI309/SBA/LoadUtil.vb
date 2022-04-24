Imports Microsoft.BusinessSolutions.SmallBusinessAccounting.Loader
Imports System.Reflection

Public Class LoaderUtil
  ' Define Loader strong name
  Const loaderFULLNAME As String = "Loader, Version=2.0.5201.0, Culture=neutral,  PublicKeyToken=31bf3856ad364e35"
  ' Define fully qualified name of Loader class
  Const loaderNAMESPACE As String = "Microsoft.BusinessSolutions.SmallBusinessAccounting.Loader.Loader"

  Public Shared Function InstantiateLoader() As ILoader
    ' Define variables
    Dim assem As Assembly                ' Loader assembly
    Dim ldr As ILoader = Nothing         ' ILoader object instance

    Try
      ' Load assembly
      assem = Assembly.Load(loaderFULLNAME)

      ' Instantiate ILoader object
      ldr = DirectCast(assem.CreateInstance(loaderNAMESPACE), ILoader)
      Return ldr
    Catch e As Exception
      Throw New TypeLoadException("Unable to instantiate Loader object instance.", e)
    End Try
  End Function
End Class

