// Copyright 2011, Google Inc. All Rights Reserved.
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
using Google.Api.Ads.AdWords.v201109;

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Api.Ads.AdWords.Examples.CSharp.v201109 {
  /// <summary>
  /// This code example gets location criteria by name.
  ///
  /// Tags: LocationCriterionService.get
  /// </summary>
  class GetLocationCriteria : SampleBase {
    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This code example gets location criteria by name.";
      }
    }

    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      SampleBase codeExample = new GetLocationCriteria();
      Console.WriteLine(codeExample.Description);
      codeExample.Run(new AdWordsUser());
    }


    /// <summary>
    /// Gets a string representation for a location.
    /// </summary>
    /// <param name="location">The location</param>
    /// <returns>The string representation</returns>
    public string GetLocationString(Location location) {
      return string.Format("{0} ({1})", location.locationName, location.displayType);
    }

    /// <summary>
    /// Run the code example.
    /// </summary>
    /// <param name="user">The AdWords user object running the code example.
    /// </param>
    public override void Run(AdWordsUser user) {
      // Get the LocationCriterionService.
      LocationCriterionService locationCriterionService =
          (LocationCriterionService) user.GetService(AdWordsService.v201109.
              LocationCriterionService);

      string[] locationNames = new string[] {"Paris", "Quebec", "Spain", "Deutschland"};

      Selector selector = new Selector();
      selector.fields = new string[] {"Id", "LocationName", "CanonicalName", "DisplayType",
          "ParentLocations", "Reach"};
      // Location names must match exactly, only EQUALS and IN are supported.
      Predicate predicate1 = new Predicate();
      predicate1.field = "LocationName";
      predicate1.@operator = PredicateOperator.IN;
      predicate1.values = locationNames;

      // Set the locale of the returned location names.
      Predicate predicate2 = new Predicate();
      predicate2.field = "Locale";
      predicate2.@operator = PredicateOperator.EQUALS;
      predicate2.values = new string[] {"en"};

      selector.predicates = new Predicate[] {predicate1, predicate2};

      try {
        // Make the get request.
        LocationCriterion[] locationCriteria = locationCriterionService.get(selector);

        // Display the resulting location criteria.
        foreach (LocationCriterion locationCriterion in locationCriteria) {
          string parentLocations = "";
          if (locationCriterion.location != null &&
              locationCriterion.location.parentLocations != null) {
            foreach (Location location in locationCriterion.location.parentLocations) {
              parentLocations += GetLocationString(location) + ", ";
            }
            parentLocations.TrimEnd(',', ' ');
          } else {
            parentLocations = "N/A";
          }
          Console.WriteLine("The search term '{0}' returned the location '{1}' of type '{2}' " +
              "with parent locations '{3}' and reach '{4}'.", locationCriterion.searchTerm,
              locationCriterion.location.locationName, locationCriterion.location.displayType,
              parentLocations, locationCriterion.reach);
        }
      } catch (Exception ex) {
        Console.WriteLine("Failed to get location criteria. Exception says \"{0}\"", ex.Message);
      }
    }
  }
}
