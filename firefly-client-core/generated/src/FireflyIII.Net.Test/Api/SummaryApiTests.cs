/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FireflyIII.Net.Client;
using FireflyIII.Net.Api;
using FireflyIII.Net.Model;

namespace FireflyIII.Net.Test
{
    /// <summary>
    ///  Class for testing SummaryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SummaryApiTests : IDisposable
    {
        private SummaryApi instance;

        public SummaryApiTests()
        {
            instance = new SummaryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SummaryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SummaryApi
            //Assert.IsType(typeof(SummaryApi), instance, "instance is a SummaryApi");
        }

        
        /// <summary>
        /// Test GetBasicSummary
        /// </summary>
        [Fact]
        public void GetBasicSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime start = null;
            //DateTime end = null;
            //string currencyCode = null;
            //var response = instance.GetBasicSummary(start, end, currencyCode);
            //Assert.IsType<List<BasicSummaryEntry>> (response, "response is List<BasicSummaryEntry>");
        }
        
    }

}
