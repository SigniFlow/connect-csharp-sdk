/*

 * Certify Ceremony API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

 *
 * The version of the OpenAPI document: 1.0.0
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
    ///  Class for testing CeremonyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CeremonyApiTests : IDisposable
    {
        private CeremonyApi instance;

        public CeremonyApiTests()
        {
            instance = new CeremonyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CeremonyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CeremonyApi
            //Assert.IsType<CeremonyApi>(instance);
        }

        /// <summary>

        /// Test CertifyCeremonyWithToken
        /// </summary>
        [Fact]
        public void CertifyCeremonyWithTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CertifyCeremonyWithTokenRequest certifyCeremonyWithTokenRequest = null;
            //var response = instance.CertifyCeremonyWithToken(certifyCeremonyWithTokenRequest);
            //Assert.IsType<CertifyCeremonyWithTokenResponse>(response);

        }
    }
}