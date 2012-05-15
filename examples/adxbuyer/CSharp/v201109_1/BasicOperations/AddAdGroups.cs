// Copyright 2012, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.AdWords.v201109_1;

using System;
using System.Collections.Generic;
using System.IO;

namespace Google.Api.Ads.AdWords.Examples.CSharp.v201109_1 {
  /// <summary>
  /// This code example illustrates how to create ad groups. To create
  /// campaigns, run AddCampaigns.cs.
  ///
  /// Tags: AdGroupService.mutate
  /// </summary>
  public class AddAdGroups : ExampleBase {
    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      ExampleBase codeExample = new AddAdGroups();
      Console.WriteLine(codeExample.Description);
      codeExample.Run(new AdWordsUser(), codeExample.GetParameters(), Console.Out);
    }

    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This code example illustrates how to create ad groups. To create campaigns, " +
            "run AddCampaigns.cs";
      }
    }

    /// <summary>
    /// Gets the list of parameter names required to run this code example.
    /// </summary>
    /// <returns>
    /// A list of parameter names for this code example.
    /// </returns>
    public override string[] GetParameterNames() {
      return new string[] {"CAMPAIGN_ID"};
    }

    /// <summary>
    /// Runs the code example.
    /// </summary>
    /// <param name="user">The AdWords user.</param>
    /// <param name="parameters">The parameters for running the code
    /// example.</param>
    /// <param name="writer">The stream writer to which script output should be
    /// written.</param>
    public override void Run(AdWordsUser user, Dictionary<string, string> parameters,
        TextWriter writer) {
      // Get the AdGroupService.
      AdGroupService adGroupService =
          (AdGroupService) user.GetService(AdWordsService.v201109_1.AdGroupService);

      long campaignId = long.Parse(parameters["CAMPAIGN_ID"]);

      // Create the ad group.
      AdGroup adGroup1 = new AdGroup();
      adGroup1.name = string.Format("Earth to Mars Cruises #{0}", ExampleUtilities.GetTimeStamp());
      adGroup1.status = AdGroupStatus.ENABLED;
      adGroup1.campaignId = campaignId;

      // Set the ad group bids.
      ManualCPMAdGroupBids bid1 = new ManualCPMAdGroupBids();

      Bid maxCpm1 = new Bid();
      maxCpm1.amount = new Money();
      maxCpm1.amount.microAmount = 10000000;
      bid1.maxCpm = maxCpm1;

      adGroup1.bids = bid1;

      // Create the operation.
      AdGroupOperation operation1 = new AdGroupOperation();
      operation1.@operator = Operator.ADD;
      operation1.operand = adGroup1;

      // Create the ad group.
      AdGroup adGroup2 = new AdGroup();
      adGroup2.name = string.Format("Earth to Venus Cruises #{0}", ExampleUtilities.GetTimeStamp());
      adGroup2.status = AdGroupStatus.ENABLED;
      adGroup2.campaignId = campaignId;

      // Set the ad group bids.
      ManualCPMAdGroupBids bid2 = new ManualCPMAdGroupBids();

      Bid maxCpm2 = new Bid();
      maxCpm2.amount = new Money();
      maxCpm2.amount.microAmount = 20000000;
      bid2.maxCpm = maxCpm2;

      adGroup2.bids = bid2;

      // Create the operation.
      AdGroupOperation operation2 = new AdGroupOperation();
      operation2.@operator = Operator.ADD;
      operation2.operand = adGroup2;

      try {
        // Create the ad group.
        AdGroupReturnValue retVal = adGroupService.mutate(
            new AdGroupOperation[] {operation1, operation2});

        // Display the results.
        if (retVal != null && retVal.value != null && retVal.value.Length > 0) {
          foreach (AdGroup newAdGroup in retVal.value) {
            writer.WriteLine("Ad group with id = '{0}' and name = '{1}' was created.",
                newAdGroup.id, newAdGroup.name);
          }
        } else {
          writer.WriteLine("No ad groups were created.");
        }
      } catch (Exception ex) {
        writer.WriteLine("Failed to create ad groups. Exception says \"{0}\"", ex.Message);
      }
    }
  }
}