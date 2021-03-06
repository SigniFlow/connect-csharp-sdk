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
    ///  Class for testing WorkFlowApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkFlowApiTests
    {
        private WorkFlowApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkFlowApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkFlowApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' WorkFlowApi
            //Assert.IsInstanceOf(typeof(WorkFlowApi), instance);
        }

        
        /// <summary>
        /// Test CreateWorkflow
        /// </summary>
        [Test]
        public void CreateWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //CreateWorkflowRequest createWorkflowRequest = null;
            //var response = instance.CreateWorkflow(contentType, createWorkflowRequest);
            //Assert.IsInstanceOf(typeof(CreateWorkflowResponse), response, "response is CreateWorkflowResponse");
        }
        
        /// <summary>
        /// Test GetDocument
        /// </summary>
        [Test]
        public void GetDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetDocumentRequest getDocumentRequest = null;
            //var response = instance.GetDocument(contentType, getDocumentRequest);
            //Assert.IsInstanceOf(typeof(GetDocumentResponse), response, "response is GetDocumentResponse");
        }
        
        /// <summary>
        /// Test PostAddWorkflowStep
        /// </summary>
        [Test]
        public void PostAddWorkflowStepTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //AddWorkflowStepV2Request addWorkflowStepV2Request = null;
            //var response = instance.PostAddWorkflowStep(contentType, addWorkflowStepV2Request);
            //Assert.IsInstanceOf(typeof(AddWokflowStepV2Response), response, "response is AddWokflowStepV2Response");
        }
        
        /// <summary>
        /// Test PostCancelFlow
        /// </summary>
        [Test]
        public void PostCancelFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //CancelFlowRequest cancelFlowRequest = null;
            //var response = instance.PostCancelFlow(contentType, cancelFlowRequest);
            //Assert.IsInstanceOf(typeof(CancelFlowResponse), response, "response is CancelFlowResponse");
        }
        
        /// <summary>
        /// Test PostDeleteDoc
        /// </summary>
        [Test]
        public void PostDeleteDocTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //DeleteDocRequest deleteDocRequest = null;
            //var response = instance.PostDeleteDoc(contentType, deleteDocRequest);
            //Assert.IsInstanceOf(typeof(DeleteDocResponse), response, "response is DeleteDocResponse");
        }
        
        /// <summary>
        /// Test PostDocPrepperAddField
        /// </summary>
        [Test]
        public void PostDocPrepperAddFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //DocPrepperAddFieldsFlowIDRequest docPrepperAddFieldsFlowIDRequest = null;
            //var response = instance.PostDocPrepperAddField(contentType, docPrepperAddFieldsFlowIDRequest);
            //Assert.IsInstanceOf(typeof(DocPrepperAddFieldsFlowIDResponse), response, "response is DocPrepperAddFieldsFlowIDResponse");
        }
        
        /// <summary>
        /// Test PostDocPrepperAdvancedFields
        /// </summary>
        [Test]
        public void PostDocPrepperAdvancedFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //DocPrepperAddAdvancedFieldsRequest docPrepperAddAdvancedFieldsRequest = null;
            //var response = instance.PostDocPrepperAdvancedFields(contentType, docPrepperAddAdvancedFieldsRequest);
            //Assert.IsInstanceOf(typeof(DocPrepperAddAdvancedFieldsResponse), response, "response is DocPrepperAddAdvancedFieldsResponse");
        }
        
        /// <summary>
        /// Test PostFullWorkflow
        /// </summary>
        [Test]
        public void PostFullWorkflowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //FullWorkflowRequest fullWorkflowRequest = null;
            //var response = instance.PostFullWorkflow(contentType, fullWorkflowRequest);
            //Assert.IsInstanceOf(typeof(FullWorkflowResponse), response, "response is FullWorkflowResponse");
        }
        
        /// <summary>
        /// Test PostGetDocStatus
        /// </summary>
        [Test]
        public void PostGetDocStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //GetDocStatusRequest getDocStatusRequest = null;
            //var response = instance.PostGetDocStatus(contentType, getDocStatusRequest);
            //Assert.IsInstanceOf(typeof(GetDocStatusResponse), response, "response is GetDocStatusResponse");
        }
        
        /// <summary>
        /// Test PostInitiateFlow
        /// </summary>
        [Test]
        public void PostInitiateFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //InitiateFlowRequest initiateFlowRequest = null;
            //var response = instance.PostInitiateFlow(contentType, initiateFlowRequest);
            //Assert.IsInstanceOf(typeof(InitiateFlowResponse), response, "response is InitiateFlowResponse");
        }
        
        /// <summary>
        /// Test PostInitiateFlowNoEmail
        /// </summary>
        [Test]
        public void PostInitiateFlowNoEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //InitiateFlowNoEmailRequest initiateFlowNoEmailRequest = null;
            //var response = instance.PostInitiateFlowNoEmail(contentType, initiateFlowNoEmailRequest);
            //Assert.IsInstanceOf(typeof(InitiateFlowNoEmailResponse), response, "response is InitiateFlowNoEmailResponse");
        }
        
        /// <summary>
        /// Test PostInitiateFlowNoInitialEmail
        /// </summary>
        [Test]
        public void PostInitiateFlowNoInitialEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //InitiateFlowNoInitialEmailRequest initiateFlowNoInitialEmailRequest = null;
            //var response = instance.PostInitiateFlowNoInitialEmail(contentType, initiateFlowNoInitialEmailRequest);
            //Assert.IsInstanceOf(typeof(InitiateFlowNoInitialEmailResponse), response, "response is InitiateFlowNoInitialEmailResponse");
        }
        
        /// <summary>
        /// Test PostWorkflowSign
        /// </summary>
        [Test]
        public void PostWorkflowSignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //WorkflowSignRequest workflowSignRequest = null;
            //var response = instance.PostWorkflowSign(contentType, workflowSignRequest);
            //Assert.IsInstanceOf(typeof(WorkflowSignResponse), response, "response is WorkflowSignResponse");
        }
        
    }

}
