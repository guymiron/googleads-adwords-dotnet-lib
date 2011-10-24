' Copyright 2011, Google Inc. All Rights Reserved.
'
' Licensed under the Apache License, Version 2.0 (the "License");
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.

' Author: api.anash@gmail.com (Anash P. Oommen)

Imports Google.Api.Ads.AdWords.Lib
Imports Google.Api.Ads.AdWords.v201109

Imports System

Namespace Google.Api.Ads.AdWords.Examples.VB.v201109
  ''' <summary>
  ''' This code example illustrates how to retrieve all languages available for
  ''' targeting.
  '''
  ''' Tags: ConstantDataService.getCarrierCriterion
  ''' </summary>
  Class GetAllLanguages
    Inherits SampleBase
    ''' <summary>
    ''' Returns a description about the code example.
    ''' </summary>
    Public Overrides ReadOnly Property Description() As String
      Get
        Return "This code example illustrates how to retrieve all languages available for" & _
            " targeting."
      End Get
    End Property

    ''' <summary>
    ''' Main method, to run this code example as a standalone application.
    ''' </summary>
    ''' <param name="args">The command line arguments.</param>
    Public Shared Sub Main(ByVal args As String())
      Dim codeExample As SampleBase = New GetAllLanguages
      Console.WriteLine(codeExample.Description)
      codeExample.Run(New AdWordsUser)
    End Sub

    ''' <summary>
    ''' Run the code example.
    ''' </summary>
    ''' <param name="user">AdWords user running the code example.</param>
    Public Overrides Sub Run(ByVal user As AdWordsUser)
      ' Get the ConstantDataService.
      Dim constantDataService As ConstantDataService = user.GetService( _
          AdWordsService.v201109.ConstantDataService)
      Try
        ' Get all languages from ConstantDataService.
        Dim languages As Language() = constantDataService.getLanguageCriterion
        If (Not languages Is Nothing) Then
          Dim language As Language
          For Each language In languages
            Console.WriteLine("Language name is '{0}', ID is {1} and code is '{2}'.", _
                language.name, language.id, language.code)
          Next
        Else
          Console.WriteLine("No languages were found.")
        End If
      Catch ex As Exception
        Console.WriteLine("Failed to get languages. Exception says ""{0}""", ex.Message)
      End Try
    End Sub
  End Class
End Namespace
