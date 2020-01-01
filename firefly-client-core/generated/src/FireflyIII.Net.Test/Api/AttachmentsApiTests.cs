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
    ///  Class for testing AttachmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AttachmentsApiTests : IDisposable
    {
        private AttachmentsApi instance;

        public AttachmentsApiTests()
        {
            instance = new AttachmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AttachmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AttachmentsApi
            //Assert.IsType(typeof(AttachmentsApi), instance, "instance is a AttachmentsApi");
        }

        
        /// <summary>
        /// Test DeleteAttachment
        /// </summary>
        [Fact]
        public void DeleteAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteAttachment(id);
            
        }
        
        /// <summary>
        /// Test DownloadAttachment
        /// </summary>
        [Fact]
        public void DownloadAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DownloadAttachment(id);
            //Assert.IsType<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetAttachment
        /// </summary>
        [Fact]
        public void GetAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetAttachment(id);
            //Assert.IsType<AttachmentSingle> (response, "response is AttachmentSingle");
        }
        
        /// <summary>
        /// Test ListAttachment
        /// </summary>
        [Fact]
        public void ListAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //var response = instance.ListAttachment(page);
            //Assert.IsType<AttachmentArray> (response, "response is AttachmentArray");
        }
        
        /// <summary>
        /// Test StoreAttachment
        /// </summary>
        [Fact]
        public void StoreAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Attachment attachment = null;
            //var response = instance.StoreAttachment(attachment);
            //Assert.IsType<AttachmentSingle> (response, "response is AttachmentSingle");
        }
        
        /// <summary>
        /// Test UpdateAttachment
        /// </summary>
        [Fact]
        public void UpdateAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Attachment attachment = null;
            //var response = instance.UpdateAttachment(id, attachment);
            //Assert.IsType<AttachmentSingle> (response, "response is AttachmentSingle");
        }
        
        /// <summary>
        /// Test UploadAttachment
        /// </summary>
        [Fact]
        public void UploadAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //System.IO.Stream body = null;
            //instance.UploadAttachment(id, body);
            
        }
        
    }

}
