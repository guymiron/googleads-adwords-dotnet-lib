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
Imports System.Collections.Generic


Namespace Google.Api.Ads.AdWords.Examples.VB.v201109
  ''' <summary>
  ''' This code example adds location, language, and platform criteria to an
  ''' existing campaign. To get a campaign, run GetAllCampaigns.vb.
  '''
  ''' Tags: CampaignCriterionService.mutate
  ''' </summary>
  Class AddCampaignTargetingCriteria
    Inherits SampleBase
    ''' <summary>
    ''' Returns a description about the code example.
    ''' </summary>
    Public Overrides ReadOnly Property Description() As String
      Get
        Return "This code example adds location, language, and platform criteria to an " & _
            "existing campaign. To get a campaign, run GetAllCampaigns.vb."
      End Get
    End Property

    ''' <summary>
    ''' Main method, to run this code example as a standalone application.
    ''' </summary>
    ''' <param name="args">The command line arguments.</param>
    Public Shared Sub Main(ByVal args As String())
      Dim codeExample As SampleBase = New AddCampaignTargetingCriteria
      Console.WriteLine(codeExample.Description)
      codeExample.Run(New AdWordsUser)
    End Sub

    ''' <summary>
    ''' Run the code example.
    ''' </summary>
    ''' <param name="user">AdWords user running the code example.</param>
    Public Overrides Sub Run(ByVal user As AdWordsUser)
      ' Get the CampaignCriterionService.
      Dim campaignCriterionService As CampaignCriterionService = user.GetService( _
          AdWordsService.v201109.CampaignCriterionService)

      Dim campaignId As Long = Long.Parse(_T("INSERT_CAMPAIGN_ID_HERE"))

      ' Create language criteria.
      ' See http://code.google.com/apis/adwords/docs/appendix/languagecodes.html
      ' for a detailed list of language codes.
      Dim language1 As New Language
      language1.id = 1002 ' French
      Dim languageCriterion1 As New CampaignCriterion
      languageCriterion1.campaignId = campaignId
      languageCriterion1.criterion = language1

      Dim language2 As New Language
      language2.id = 1005  ' Japanese
      Dim languageCriterion2 As New CampaignCriterion
      languageCriterion2.campaignId = campaignId
      languageCriterion2.criterion = language2

      ' Create location criteria.
      ' See http://code.google.com/apis/adwords/docs/appendix/countrycodes.html
      ' for a detailed list of country codes.
      Dim location1 As New Location
      location1.id = 2840  ' USA
      Dim locationCriterion1 As New CampaignCriterion
      locationCriterion1.campaignId = campaignId
      locationCriterion1.criterion = location1

      Dim location2 As New Location
      location2.id = 2392 ' Japan
      Dim locationCriterion2 As New CampaignCriterion
      locationCriterion2.campaignId = campaignId
      locationCriterion2.criterion = location2

      ' Create platform criteria.
      ' See http://code.google.com/apis/adwords/docs/appendix/platforms.html
      ' for a detailed list of platform codes.
      Dim platform1 As New Platform()
      platform1.id = 30002  ' Tablets
      Dim platformCriterion1 As New CampaignCriterion
      platformCriterion1.campaignId = campaignId
      platformCriterion1.criterion = platform1

      Dim criteria() As CampaignCriterion = {languageCriterion1, languageCriterion2, _
          locationCriterion1, locationCriterion2, platformCriterion1}

      Dim operations As New List(Of CampaignCriterionOperation)
      For Each criterion As CampaignCriterion In criteria
        Dim operation As New CampaignCriterionOperation
        operation.operator = [Operator].ADD
        operation.operand = criterion
        operations.Add(operation)
      Next

      Try
        ' Set campaign targets.
        Dim retVal As CampaignCriterionReturnValue = campaignCriterionService.mutate( _
            operations.ToArray())

        If ((Not retVal Is Nothing) AndAlso (Not retVal.value Is Nothing)) Then
          ' Display campaign targets.
          For Each criterion As CampaignCriterion In retVal.value
            Console.WriteLine("Campaign criterion of type '{0}' was set to Campaign with id " & _
                "= '{1}'.", criterion.CampaignCriterionType, criterion.campaignId)
          Next
        End If
      Catch ex As Exception
        Console.WriteLine("Failed to set Campaign criteria. Exception says ""{0}""", ex.Message)
      End Try
    End Sub
  End Class
End Namespace
