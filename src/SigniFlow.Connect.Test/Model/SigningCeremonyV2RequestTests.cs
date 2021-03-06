/*
 * WorkFlow API
 *
 * ## SigniFlow API used to automate esignature workflow creation and management. 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@signiflow.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SigniFlow.Connect.Api;
using SigniFlow.Connect.Model;
using SigniFlow.Connect.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SigniFlow.Connect.Test
{
    /// <summary>
    ///  Class for testing SigningCeremonyV2Request
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SigningCeremonyV2RequestTests
    {
        // TODO uncomment below to declare an instance variable for SigningCeremonyV2Request
        //private SigningCeremonyV2Request instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SigningCeremonyV2Request
            //instance = new SigningCeremonyV2Request();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SigningCeremonyV2Request
        /// </summary>
        [Test]
        public void SigningCeremonyV2RequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SigningCeremonyV2Request
            //Assert.IsInstanceOf(typeof(SigningCeremonyV2Request), instance);
        }


        /// <summary>
        /// Test the property 'CheckboxFieldsListField'
        /// </summary>
        [Test]
        public void CheckboxFieldsListFieldTest()
        {
            // TODO unit test for the property 'CheckboxFieldsListField'
        }
        /// <summary>
        /// Test the property 'DocField'
        /// </summary>
        [Test]
        public void DocFieldTest()
        {
            // TODO unit test for the property 'DocField'
        }
        /// <summary>
        /// Test the property 'DocNameField'
        /// </summary>
        [Test]
        public void DocNameFieldTest()
        {
            // TODO unit test for the property 'DocNameField'
        }
        /// <summary>
        /// Test the property 'InitialFieldsListField'
        /// </summary>
        [Test]
        public void InitialFieldsListFieldTest()
        {
            // TODO unit test for the property 'InitialFieldsListField'
        }
        /// <summary>
        /// Test the property 'LoginPasswordField'
        /// </summary>
        [Test]
        public void LoginPasswordFieldTest()
        {
            // TODO unit test for the property 'LoginPasswordField'
        }
        /// <summary>
        /// Test the property 'LoginUserNameField'
        /// </summary>
        [Test]
        public void LoginUserNameFieldTest()
        {
            // TODO unit test for the property 'LoginUserNameField'
        }
        /// <summary>
        /// Test the property 'SignatureHField'
        /// </summary>
        [Test]
        public void SignatureHFieldTest()
        {
            // TODO unit test for the property 'SignatureHField'
        }
        /// <summary>
        /// Test the property 'SignatureImageField'
        /// </summary>
        [Test]
        public void SignatureImageFieldTest()
        {
            // TODO unit test for the property 'SignatureImageField'
        }
        /// <summary>
        /// Test the property 'SignatureImageIncludeBorderField'
        /// </summary>
        [Test]
        public void SignatureImageIncludeBorderFieldTest()
        {
            // TODO unit test for the property 'SignatureImageIncludeBorderField'
        }
        /// <summary>
        /// Test the property 'SignatureImageIncludeReasonField'
        /// </summary>
        [Test]
        public void SignatureImageIncludeReasonFieldTest()
        {
            // TODO unit test for the property 'SignatureImageIncludeReasonField'
        }
        /// <summary>
        /// Test the property 'SignatureImageIncludeSignedByField'
        /// </summary>
        [Test]
        public void SignatureImageIncludeSignedByFieldTest()
        {
            // TODO unit test for the property 'SignatureImageIncludeSignedByField'
        }
        /// <summary>
        /// Test the property 'SignatureImageIncludeSignedDateField'
        /// </summary>
        [Test]
        public void SignatureImageIncludeSignedDateFieldTest()
        {
            // TODO unit test for the property 'SignatureImageIncludeSignedDateField'
        }
        /// <summary>
        /// Test the property 'SignatureImageTypeField'
        /// </summary>
        [Test]
        public void SignatureImageTypeFieldTest()
        {
            // TODO unit test for the property 'SignatureImageTypeField'
        }
        /// <summary>
        /// Test the property 'SignaturePageField'
        /// </summary>
        [Test]
        public void SignaturePageFieldTest()
        {
            // TODO unit test for the property 'SignaturePageField'
        }
        /// <summary>
        /// Test the property 'SignatureWField'
        /// </summary>
        [Test]
        public void SignatureWFieldTest()
        {
            // TODO unit test for the property 'SignatureWField'
        }
        /// <summary>
        /// Test the property 'SignatureXField'
        /// </summary>
        [Test]
        public void SignatureXFieldTest()
        {
            // TODO unit test for the property 'SignatureXField'
        }
        /// <summary>
        /// Test the property 'SignatureYField'
        /// </summary>
        [Test]
        public void SignatureYFieldTest()
        {
            // TODO unit test for the property 'SignatureYField'
        }
        /// <summary>
        /// Test the property 'SignerEmailField'
        /// </summary>
        [Test]
        public void SignerEmailFieldTest()
        {
            // TODO unit test for the property 'SignerEmailField'
        }
        /// <summary>
        /// Test the property 'SignerFullNameField'
        /// </summary>
        [Test]
        public void SignerFullNameFieldTest()
        {
            // TODO unit test for the property 'SignerFullNameField'
        }
        /// <summary>
        /// Test the property 'SignerIdentificationNumberField'
        /// </summary>
        [Test]
        public void SignerIdentificationNumberFieldTest()
        {
            // TODO unit test for the property 'SignerIdentificationNumberField'
        }
        /// <summary>
        /// Test the property 'SignerLocationField'
        /// </summary>
        [Test]
        public void SignerLocationFieldTest()
        {
            // TODO unit test for the property 'SignerLocationField'
        }
        /// <summary>
        /// Test the property 'SignerMobileNumberField'
        /// </summary>
        [Test]
        public void SignerMobileNumberFieldTest()
        {
            // TODO unit test for the property 'SignerMobileNumberField'
        }
        /// <summary>
        /// Test the property 'SignerReasonField'
        /// </summary>
        [Test]
        public void SignerReasonFieldTest()
        {
            // TODO unit test for the property 'SignerReasonField'
        }
        /// <summary>
        /// Test the property 'SignerTrustOriginField'
        /// </summary>
        [Test]
        public void SignerTrustOriginFieldTest()
        {
            // TODO unit test for the property 'SignerTrustOriginField'
        }
        /// <summary>
        /// Test the property 'SignerTrustReferenceField'
        /// </summary>
        [Test]
        public void SignerTrustReferenceFieldTest()
        {
            // TODO unit test for the property 'SignerTrustReferenceField'
        }
        /// <summary>
        /// Test the property 'TextFieldsListField'
        /// </summary>
        [Test]
        public void TextFieldsListFieldTest()
        {
            // TODO unit test for the property 'TextFieldsListField'
        }

    }

}
