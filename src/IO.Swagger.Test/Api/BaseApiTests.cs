/* 
 * Synacta
 *
 * WebApi
 *
 * OpenAPI spec version: v1
 * Contact: bhofmann@agile-is.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing BaseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BaseApiTests
    {
        private BaseApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BaseApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BaseApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BaseApi
            //Assert.IsInstanceOfType(typeof(BaseApi), instance, "instance is a BaseApi");
        }

        
        /// <summary>
        /// Test ApiBaseByTypeByIdAddByNewContainerTypeGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdAddByNewContainerTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string newContainerType = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdAddByNewContainerTypeGet(type, id, newContainerType, authorization);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdAddPut
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdAddPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //Container newContainer = null;
            //var response = instance.ApiBaseByTypeByIdAddPut(type, id, authorization, newContainer);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdCheckinPut
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdCheckinPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //Container container = null;
            //var response = instance.ApiBaseByTypeByIdCheckinPut(type, id, authorization, container);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdCheckoutPut
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdCheckoutPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //Container container = null;
            //var response = instance.ApiBaseByTypeByIdCheckoutPut(type, id, authorization, container);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdChildrenGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdChildrenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdChildrenGet(type, id, authorization);
            //Assert.IsInstanceOf<List<Container>> (response, "response is List<Container>");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdChildrenTypesGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdChildrenTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdChildrenTypesGet(type, id, authorization);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdDelete
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdDelete(type, id, authorization);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdDocumentsGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdDocumentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdDocumentsGet(type, id, authorization);
            //Assert.IsInstanceOf<List<Container>> (response, "response is List<Container>");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdDocumentsTypesGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdDocumentsTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdDocumentsTypesGet(type, id, authorization);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdGet(type, id, authorization);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdGetFileGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdGetFileGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //instance.ApiBaseByTypeByIdGetFileGet(type, id, authorization);
            
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdLookupListByLookupListNameGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdLookupListByLookupListNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string lookupListName = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdLookupListByLookupListNameGet(type, id, lookupListName, authorization);
            //Assert.IsInstanceOf<List<KeyValuePairStringString>> (response, "response is List<KeyValuePairStringString>");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdMovePost
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdMovePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //Container container = null;
            //var response = instance.ApiBaseByTypeByIdMovePost(type, id, authorization, container);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdPost
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //Container newContainer = null;
            //var response = instance.ApiBaseByTypeByIdPost(type, id, authorization, newContainer);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdUploadFilePost
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdUploadFilePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //instance.ApiBaseByTypeByIdUploadFilePost(type, id, authorization);
            
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdVersionsByVersionIdGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdVersionsByVersionIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string versionId = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdVersionsByVersionIdGet(type, id, versionId, authorization);
            //Assert.IsInstanceOf<DocumentVersion> (response, "response is DocumentVersion");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdVersionsByVersionIdGetFileGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdVersionsByVersionIdGetFileGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string versionId = null;
            //string authorization = null;
            //instance.ApiBaseByTypeByIdVersionsByVersionIdGetFileGet(type, id, versionId, authorization);
            
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdVersionsByVersionIdRestorePost
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdVersionsByVersionIdRestorePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string versionId = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdVersionsByVersionIdRestorePost(type, id, versionId, authorization);
            //Assert.IsInstanceOf<Container> (response, "response is Container");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeByIdVersionsGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeByIdVersionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeByIdVersionsGet(type, id, authorization);
            //Assert.IsInstanceOf<List<DocumentVersion>> (response, "response is List<DocumentVersion>");
        }
        
        /// <summary>
        /// Test ApiBaseByTypeGet
        /// </summary>
        [Test]
        public void ApiBaseByTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string authorization = null;
            //var response = instance.ApiBaseByTypeGet(type, authorization);
            //Assert.IsInstanceOf<List<Container>> (response, "response is List<Container>");
        }
        
        /// <summary>
        /// Test ApiBaseRootGet
        /// </summary>
        [Test]
        public void ApiBaseRootGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.ApiBaseRootGet(authorization);
            //Assert.IsInstanceOf<List<Container>> (response, "response is List<Container>");
        }
        
        /// <summary>
        /// Test ApiBaseTypesGet
        /// </summary>
        [Test]
        public void ApiBaseTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.ApiBaseTypesGet(authorization);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
    }

}
