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
    ///  Class for testing TemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TemplatesApiTests
    {
        private TemplatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TemplatesApi
            //Assert.IsInstanceOf(typeof(TemplatesApi), instance);
        }

        
        /// <summary>
        /// Test PostApplyPrepperTemplate
        /// </summary>
        [Test]
        public void PostApplyPrepperTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //ApplyPrepperTemplateRequest applyPrepperTemplateRequest = null;
            //var response = instance.PostApplyPrepperTemplate(contentType, applyPrepperTemplateRequest);
            //Assert.IsInstanceOf(typeof(ApplyPrepperTemplateResponse), response, "response is ApplyPrepperTemplateResponse");
        }
        
        /// <summary>
        /// Test PostGetDocumentTagFieldBoxPosition
        /// </summary>
        [Test]
        public void PostGetDocumentTagFieldBoxPositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetDocumentTagFieldBoxPositionRequest getDocumentTagFieldBoxPositionRequest = null;
            //var response = instance.PostGetDocumentTagFieldBoxPosition(contentType, getDocumentTagFieldBoxPositionRequest);
            //Assert.IsInstanceOf(typeof(GetDocumentTagFieldBoxPositionResponse), response, "response is GetDocumentTagFieldBoxPositionResponse");
        }
        
        /// <summary>
        /// Test PostGetDocumentTagFieldPosition
        /// </summary>
        [Test]
        public void PostGetDocumentTagFieldPositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetDocumentTagFieldPositionRequest getDocumentTagFieldPositionRequest = null;
            //var response = instance.PostGetDocumentTagFieldPosition(contentType, getDocumentTagFieldPositionRequest);
            //Assert.IsInstanceOf(typeof(GetDocumentTagFieldPositionResponse), response, "response is GetDocumentTagFieldPositionResponse");
        }
        
        /// <summary>
        /// Test PostGetPrepperTemplate
        /// </summary>
        [Test]
        public void PostGetPrepperTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetPrepperTemplateRequest getPrepperTemplateRequest = null;
            //var response = instance.PostGetPrepperTemplate(contentType, getPrepperTemplateRequest);
            //Assert.IsInstanceOf(typeof(GetPrepperTemplateResponse), response, "response is GetPrepperTemplateResponse");
        }
        
        /// <summary>
        /// Test PostGetPrepperTemplateList
        /// </summary>
        [Test]
        public void PostGetPrepperTemplateListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetPrepperTemplateListRequest getPrepperTemplateListRequest = null;
            //var response = instance.PostGetPrepperTemplateList(contentType, getPrepperTemplateListRequest);
            //Assert.IsInstanceOf(typeof(GetPrepperTemplateListResponse), response, "response is GetPrepperTemplateListResponse");
        }
        
    }

}
