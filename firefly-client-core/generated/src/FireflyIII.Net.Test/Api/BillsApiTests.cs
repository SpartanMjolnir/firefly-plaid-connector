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
    ///  Class for testing BillsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BillsApiTests : IDisposable
    {
        private BillsApi instance;

        public BillsApiTests()
        {
            instance = new BillsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BillsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillsApi
            //Assert.IsType(typeof(BillsApi), instance, "instance is a BillsApi");
        }

        
        /// <summary>
        /// Test DeleteBill
        /// </summary>
        [Fact]
        public void DeleteBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteBill(id);
            
        }
        
        /// <summary>
        /// Test GetBill
        /// </summary>
        [Fact]
        public void GetBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //var response = instance.GetBill(id, start, end);
            //Assert.IsType<BillSingle> (response, "response is BillSingle");
        }
        
        /// <summary>
        /// Test ListAttachmentByBill
        /// </summary>
        [Fact]
        public void ListAttachmentByBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //var response = instance.ListAttachmentByBill(id, page);
            //Assert.IsType<AttachmentArray> (response, "response is AttachmentArray");
        }
        
        /// <summary>
        /// Test ListBill
        /// </summary>
        [Fact]
        public void ListBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //var response = instance.ListBill(page, start, end);
            //Assert.IsType<BillArray> (response, "response is BillArray");
        }
        
        /// <summary>
        /// Test ListRuleByBill
        /// </summary>
        [Fact]
        public void ListRuleByBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ListRuleByBill(id);
            //Assert.IsType<RuleArray> (response, "response is RuleArray");
        }
        
        /// <summary>
        /// Test ListTransactionByBill
        /// </summary>
        [Fact]
        public void ListTransactionByBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //TransactionTypeFilter type = null;
            //var response = instance.ListTransactionByBill(id, start, end, type);
            //Assert.IsType<TransactionArray> (response, "response is TransactionArray");
        }
        
        /// <summary>
        /// Test StoreBill
        /// </summary>
        [Fact]
        public void StoreBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Bill bill = null;
            //var response = instance.StoreBill(bill);
            //Assert.IsType<BillSingle> (response, "response is BillSingle");
        }
        
        /// <summary>
        /// Test UpdateBill
        /// </summary>
        [Fact]
        public void UpdateBillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Bill bill = null;
            //var response = instance.UpdateBill(id, bill);
            //Assert.IsType<BillSingle> (response, "response is BillSingle");
        }
        
    }

}