﻿// Copyright 2012, Google Inc. All Rights Reserved.
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

using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using CSharpExamples = Google.Api.Ads.AdWords.Examples.CSharp.v201109_1;
using VBExamples = Google.Api.Ads.AdWords.Examples.VB.v201109_1;

namespace Google.Api.Ads.AdWords.Tests.v201109_1 {
  /// <summary>
  /// Test cases for all the code examples under v201109_1\AccountManagement.
  /// </summary>
  class AccountManagementTest : ExampleBaseTests {
    /// <summary>
    /// Inits this instance.
    /// </summary>
    [SetUp]
    public void Init() {
      parameters = new Dictionary<string, string>();

      parameters["CLIENT_EMAIL_ADDRESS"] = "client_1+" + (user.Config as AdWordsAppConfig).Email;
    }
    /// <summary>
    /// Tests the CreateAccount VB.NET code example.
    /// </summary>
    [Test]
    public void TestCreateAccountVBExample() {
      RunExample(new VBExamples.CreateAccount());
    }

    /// <summary>
    /// Tests the CreateAccount C# code example.
    /// </summary>
    [Test]
    public void TestCreateAccountCSharpExample() {
      RunExample(new CSharpExamples.CreateAccount());
    }

    /// <summary>
    /// Tests the GetAccountAlerts VB.NET code example.
    /// </summary>
    [Test]
    public void TestGetAccountAlertsVBExample() {
      RunExample(new VBExamples.GetAccountAlerts());
    }

    /// <summary>
    /// Tests the GetAccountAlerts C# code example.
    /// </summary>
    [Test]
    public void TestGetAccountAlertsCSharpExample() {
      RunExample(new CSharpExamples.GetAccountAlerts());
    }

    /// <summary>
    /// Tests the GetAccountChanges VB.NET code example.
    /// </summary>
    [Test]
    public void TestGetAccountChangesVBExample() {
      RunExample(new VBExamples.GetAccountChanges());
    }

    /// <summary>
    /// Tests the GetAccountChanges C# code example.
    /// </summary>
    [Test]
    public void TestGetAccountChangesCSharpExample() {
      RunExample(new CSharpExamples.GetAccountChanges());
    }

    /// <summary>
    /// Tests the GetAccountHierarchy VB.NET code example.
    /// </summary>
    [Test]
    public void TestGetAccountHierarchyVBExample() {
      RunExample(new VBExamples.GetAccountHierarchy());
    }

    /// <summary>
    /// Tests the GetAccountHierarchy C# code example.
    /// </summary>
    [Test]
    public void TestGetAccountHierarchyCSharpExample() {
      RunExample(new CSharpExamples.GetAccountHierarchy());
    }

    /// <summary>
    /// Tests the GetClientCustomerId VB.NET code example.
    /// </summary>
    [Test]
    public void TestGetClientCustomerIdVBExample() {
      RunExample(new VBExamples.GetClientCustomerId());
    }

    /// <summary>
    /// Tests the GetClientCustomerId C# code example.
    /// </summary>
    [Test]
    public void TestGetClientCustomerIdCSharpExample() {
      RunExample(new CSharpExamples.GetClientCustomerId());
    }

    /// <summary>
    /// Tests the GetClientUnitUsage VB.NET code example.
    /// </summary>
    [Test]
    public void TestGetClientUnitUsageVBExample() {
      RunExample(new VBExamples.GetClientUnitUsage());
    }

    /// <summary>
    /// Tests the GetClientUnitUsage C# code example.
    /// </summary>
    [Test]
    public void TestGetClientUnitUsageCSharpExample() {
      RunExample(new CSharpExamples.GetClientUnitUsage());
    }
  }
}