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
    ///  Class for testing TagsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TagsApiTests : IDisposable
    {
        private TagsApi instance;

        public TagsApiTests()
        {
            instance = new TagsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TagsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TagsApi
            //Assert.IsType(typeof(TagsApi), instance, "instance is a TagsApi");
        }

        
        /// <summary>
        /// Test DeleteTag
        /// </summary>
        [Fact]
        public void DeleteTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //instance.DeleteTag(tag);
            
        }
        
        /// <summary>
        /// Test GetTag
        /// </summary>
        [Fact]
        public void GetTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //int? page = null;
            //var response = instance.GetTag(tag, page);
            //Assert.IsType<TagSingle> (response, "response is TagSingle");
        }
        
        /// <summary>
        /// Test GetTagCloud
        /// </summary>
        [Fact]
        public void GetTagCloudTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime start = null;
            //DateTime end = null;
            //var response = instance.GetTagCloud(start, end);
            //Assert.IsType<TagCloud> (response, "response is TagCloud");
        }
        
        /// <summary>
        /// Test ListTag
        /// </summary>
        [Fact]
        public void ListTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //var response = instance.ListTag(page);
            //Assert.IsType<TagArray> (response, "response is TagArray");
        }
        
        /// <summary>
        /// Test ListTransactionByTag
        /// </summary>
        [Fact]
        public void ListTransactionByTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //TransactionTypeFilter type = null;
            //var response = instance.ListTransactionByTag(tag, page, start, end, type);
            //Assert.IsType<TransactionArray> (response, "response is TransactionArray");
        }
        
        /// <summary>
        /// Test StoreTag
        /// </summary>
        [Fact]
        public void StoreTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TagModel tagModel = null;
            //var response = instance.StoreTag(tagModel);
            //Assert.IsType<TagSingle> (response, "response is TagSingle");
        }
        
        /// <summary>
        /// Test UpdateTag
        /// </summary>
        [Fact]
        public void UpdateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //TagModel tagModel = null;
            //var response = instance.UpdateTag(tag, tagModel);
            //Assert.IsType<TagSingle> (response, "response is TagSingle");
        }
        
    }

}
