/*
 * SigniFlow OpenAPI Spec v1
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
using Xunit;

using SigniFlow.Connect.Client;
using SigniFlow.Connect.Api;
// uncomment below to import models
//using SigniFlow.Connect.Model;

namespace SigniFlow.Connect.Test.Api
{
    /// <summary>
    ///  Class for testing SigningCeremonyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SigningCeremonyApiTests : IDisposable
    {
        private SigningCeremonyApi instance;

        public SigningCeremonyApiTests()
        {
            instance = new SigningCeremonyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SigningCeremonyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SigningCeremonyApi
            //Assert.IsType<SigningCeremonyApi>(instance);
        }

        /// <summary>
        /// Test PostMultipleSignersSigningCeremony
        /// </summary>
        [Fact]
        public void PostMultipleSignersSigningCeremonyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = null;
            //var response = instance.PostMultipleSignersSigningCeremony(contentType, multipleSignersSigningCeremonyRequest);
            //Assert.IsType<MultipleSignersSigningCeremonyResponse>(response);
        }

        /// <summary>
        /// Test PostSigningCeremonyV2
        /// </summary>
        [Fact]
        public void PostSigningCeremonyV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //SigningCeremonyV2Request signingCeremonyV2Request = null;
            //var response = instance.PostSigningCeremonyV2(contentType, signingCeremonyV2Request);
            //Assert.IsType<SigningCeremonyV2Response>(response);
        }
    }
}
