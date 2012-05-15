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
using Google.Api.Ads.AdWords.Util;
using Google.Api.Ads.AdWords.v201109_1;

using System;
using System.Collections.Generic;
using System.IO;

namespace Google.Api.Ads.AdWords.Examples.CSharp.v201109_1 {
  /// <summary>
  /// This code example demonstrates how to handle partial failures.
  ///
  /// Tags: AdGroupCriterionService.mutate
  /// </summary>
  public class HandlePartialFailures : ExampleBase {
    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      ExampleBase codeExample = new HandlePartialFailures();
      Console.WriteLine(codeExample.Description);
      codeExample.Run(new AdWordsUser(), codeExample.GetParameters(), Console.Out);
    }

    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This code example demonstrates how to handle partial failures.";
      }
    }

    /// <summary>
    /// Gets the list of parameter names required to run this code example.
    /// </summary>
    /// <returns>
    /// A list of parameter names for this code example.
    /// </returns>
    public override string[] GetParameterNames() {
      return new string[] {"ADGROUP_ID"};
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
      // Get the AdGroupCriterionService.
      AdGroupCriterionService adGroupCriterionService =
          (AdGroupCriterionService) user.GetService(AdWordsService.v201109_1.AdGroupCriterionService);

      // Set partial failure mode for the service.
      adGroupCriterionService.RequestHeader.partialFailure = true;

      long adGroupId = long.Parse(parameters["ADGROUP_ID"]);

      List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();

      // Create the placements.
      string[] urls = new String[] {"http://mars.google.com", "http:/mars.google.com",
          "mars.google.com"};

      foreach (String url in urls) {
        Placement placement = new Placement();
        placement.url = url;

        // Create biddable ad group criterion.
        BiddableAdGroupCriterion placementBiddableAdGroupCriterion = new BiddableAdGroupCriterion();
        placementBiddableAdGroupCriterion.adGroupId = adGroupId;
        placementBiddableAdGroupCriterion.criterion = placement;

        // Create the operation.
        AdGroupCriterionOperation placementAdGroupCriterionOperation =
            new AdGroupCriterionOperation();
        placementAdGroupCriterionOperation.operand = placementBiddableAdGroupCriterion;
        placementAdGroupCriterionOperation.@operator = Operator.ADD;
        operations.Add(placementAdGroupCriterionOperation);
      }

      try {
        // Create the placements.
        AdGroupCriterionReturnValue result = adGroupCriterionService.mutate(operations.ToArray());

        // Display the results.
        if (result != null && result.value != null) {
          foreach (AdGroupCriterion adGroupCriterionResult in result.value) {
            if (adGroupCriterionResult.criterion != null) {
              writer.WriteLine("Placement with ad group id '{0}', and criterion " +
                  "id '{1}', and url '{2}' was added.\n", adGroupCriterionResult.adGroupId,
                  adGroupCriterionResult.criterion.id,
                  ((Placement) adGroupCriterionResult.criterion).url);
            }
          }
        } else {
          writer.WriteLine("No placements were added.");
        }

        // Display the partial failure errors.
        if (result != null && result.partialFailureErrors != null) {
          foreach (ApiError apiError in result.partialFailureErrors) {
            int operationIndex = ErrorUtilities.GetOperationIndex(apiError.fieldPath);
            if (operationIndex != -1) {
              AdGroupCriterion adGroupCriterion = operations[operationIndex].operand;
              writer.WriteLine("Placement with ad group id '{0}' and url '{1}' "
                  + "triggered a failure for the following reason: '{2}'.\n",
                  adGroupCriterion.adGroupId, ((Placement) adGroupCriterion.criterion).url,
                  apiError.errorString);
            } else {
              writer.WriteLine("A failure for the following reason: '{0}' has occurred.\n",
                  apiError.errorString);
            }
          }
        }
      } catch (Exception e) {
        writer.WriteLine("Failed to add placement(s) in partial failure mode. Exception says " +
            "\"{0}\"", e.Message);
      }
    }
  }
}
