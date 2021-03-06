/*
 * WorkFlow API
 *
 * ## SigniFlow API used to automate esignature workflow creation and management. 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@signiflow.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using SigniFlow.Connect.Client;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Model;

namespace SigniFlow.Connect.Test
{
    /// <summary>
    ///  Class for testing ViewersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewersApiTests
    {
        private ViewersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ViewersApi
            //Assert.IsInstanceOf(typeof(ViewersApi), instance);
        }

        
        /// <summary>
        /// Test PostGetDocLink
        /// </summary>
        [Test]
        public void PostGetDocLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetDocLinkRequest getDocLinkRequest = null;
            //var response = instance.PostGetDocLink(contentType, getDocLinkRequest);
            //Assert.IsInstanceOf(typeof(GetDocLinkResponse), response, "response is GetDocLinkResponse");
        }
        
        /// <summary>
        /// Test PostGetDocumentPrepperLink
        /// </summary>
        [Test]
        public void PostGetDocumentPrepperLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetDocumentPrepperLinkRequest getDocumentPrepperLinkRequest = null;
            //var response = instance.PostGetDocumentPrepperLink(contentType, getDocumentPrepperLinkRequest);
            //Assert.IsInstanceOf(typeof(GetDocumentPrepperLinkResponse), response, "response is GetDocumentPrepperLinkResponse");
        }
        
    }

}
