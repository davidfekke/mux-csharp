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
    ///  Class for testing VideoViewsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VideoViewsApiTests : IDisposable
    {
        private VideoViewsApi instance;

        public VideoViewsApiTests()
        {
            instance = new VideoViewsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VideoViewsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VideoViewsApi
            //Assert.IsType<VideoViewsApi>(instance);
        }

        /// <summary>
        /// Test GetVideoView
        /// </summary>
        [Fact]
        public void GetVideoViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string VIDEO_VIEW_ID = null;
            //var response = instance.GetVideoView(VIDEO_VIEW_ID);
            //Assert.IsType<VideoViewResponse>(response);
        }

        /// <summary>
        /// Test ListVideoViews
        /// </summary>
        [Fact]
        public void ListVideoViewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? page = null;
            //string viewerId = null;
            //int? errorId = null;
            //string orderDirection = null;
            //List<string> filters = null;
            //List<string> timeframe = null;
            //var response = instance.ListVideoViews(limit, page, viewerId, errorId, orderDirection, filters, timeframe);
            //Assert.IsType<ListVideoViewsResponse>(response);
        }
    }
}