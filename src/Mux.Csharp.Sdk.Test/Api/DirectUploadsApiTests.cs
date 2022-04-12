/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
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

using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Api;
// uncomment below to import models
//using Mux.Csharp.Sdk.Model;

namespace Mux.Csharp.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing DirectUploadsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DirectUploadsApiTests : IDisposable
    {
        private DirectUploadsApi instance;

        public DirectUploadsApiTests()
        {
            instance = new DirectUploadsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DirectUploadsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DirectUploadsApi
            //Assert.IsType<DirectUploadsApi>(instance);
        }

        /// <summary>
        /// Test CancelDirectUpload
        /// </summary>
        [Fact]
        public void CancelDirectUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UPLOAD_ID = null;
            //var response = instance.CancelDirectUpload(UPLOAD_ID);
            //Assert.IsType<UploadResponse>(response);
        }

        /// <summary>
        /// Test CreateDirectUpload
        /// </summary>
        [Fact]
        public void CreateDirectUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUploadRequest createUploadRequest = null;
            //var response = instance.CreateDirectUpload(createUploadRequest);
            //Assert.IsType<UploadResponse>(response);
        }

        /// <summary>
        /// Test GetDirectUpload
        /// </summary>
        [Fact]
        public void GetDirectUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UPLOAD_ID = null;
            //var response = instance.GetDirectUpload(UPLOAD_ID);
            //Assert.IsType<UploadResponse>(response);
        }

        /// <summary>
        /// Test ListDirectUploads
        /// </summary>
        [Fact]
        public void ListDirectUploadsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? page = null;
            //var response = instance.ListDirectUploads(limit, page);
            //Assert.IsType<ListUploadsResponse>(response);
        }
    }
}