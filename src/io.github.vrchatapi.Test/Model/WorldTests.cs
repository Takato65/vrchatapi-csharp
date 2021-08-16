/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://raw.githubusercontent.com/vrchatapi/vrchatapi.github.io/master/assets/apibanner.png)  # VRChat API Documentation This project is an [OPEN Open Source Project](https://openopensource.org)  Individuals making significant and valuable contributions are given commit-access to the project to contribute as they see fit. This project is more like an open wiki than a standard guarded open source project.  ## Disclaimer  This is the official response of the VRChat Team (from Tupper more specifically) on the usage of the VRChat API.  > **Use of the API using applications other than the approved methods (website, VRChat application) are not officially supported. You may use the API for your own application, but keep these guidelines in mind:** > * We do not provide documentation or support for the API. > * Do not make queries to the API more than once per 60 seconds. > * Abuse of the API may result in account termination. > * Access to API endpoints may break at any given time, with no warning.  As stated, this documentation was not created with the help of the official VRChat team. Therefore this documentation is not an official documentation of the VRChat API and may not be always up to date with the latest versions. If you find that a page or endpoint is not longer valid please create an issue and tell us so we can fix it.  ## Get in touch with us!  [https://discord.gg/qjZE9C9fkB#vrchat-api](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Model;
using io.github.vrchatapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace io.github.vrchatapi.Test
{
    /// <summary>
    ///  Class for testing World
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WorldTests
    {
        // TODO uncomment below to declare an instance variable for World
        //private World instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of World
            //instance = new World();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of World
        /// </summary>
        [Test]
        public void WorldInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" World
            //Assert.IsInstanceOf(typeof(World), instance);
        }


        /// <summary>
        /// Test the property 'AssetUrl'
        /// </summary>
        [Test]
        public void AssetUrlTest()
        {
            // TODO unit test for the property 'AssetUrl'
        }
        /// <summary>
        /// Test the property 'AssetUrlObject'
        /// </summary>
        [Test]
        public void AssetUrlObjectTest()
        {
            // TODO unit test for the property 'AssetUrlObject'
        }
        /// <summary>
        /// Test the property 'AuthorId'
        /// </summary>
        [Test]
        public void AuthorIdTest()
        {
            // TODO unit test for the property 'AuthorId'
        }
        /// <summary>
        /// Test the property 'AuthorName'
        /// </summary>
        [Test]
        public void AuthorNameTest()
        {
            // TODO unit test for the property 'AuthorName'
        }
        /// <summary>
        /// Test the property 'Capacity'
        /// </summary>
        [Test]
        public void CapacityTest()
        {
            // TODO unit test for the property 'Capacity'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Favorites'
        /// </summary>
        [Test]
        public void FavoritesTest()
        {
            // TODO unit test for the property 'Favorites'
        }
        /// <summary>
        /// Test the property 'Featured'
        /// </summary>
        [Test]
        public void FeaturedTest()
        {
            // TODO unit test for the property 'Featured'
        }
        /// <summary>
        /// Test the property 'Heat'
        /// </summary>
        [Test]
        public void HeatTest()
        {
            // TODO unit test for the property 'Heat'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'ImageUrl'
        /// </summary>
        [Test]
        public void ImageUrlTest()
        {
            // TODO unit test for the property 'ImageUrl'
        }
        /// <summary>
        /// Test the property 'Instances'
        /// </summary>
        [Test]
        public void InstancesTest()
        {
            // TODO unit test for the property 'Instances'
        }
        /// <summary>
        /// Test the property 'LabsPublicationDate'
        /// </summary>
        [Test]
        public void LabsPublicationDateTest()
        {
            // TODO unit test for the property 'LabsPublicationDate'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Namespace'
        /// </summary>
        [Test]
        public void NamespaceTest()
        {
            // TODO unit test for the property 'Namespace'
        }
        /// <summary>
        /// Test the property 'Occupants'
        /// </summary>
        [Test]
        public void OccupantsTest()
        {
            // TODO unit test for the property 'Occupants'
        }
        /// <summary>
        /// Test the property 'Organization'
        /// </summary>
        [Test]
        public void OrganizationTest()
        {
            // TODO unit test for the property 'Organization'
        }
        /// <summary>
        /// Test the property 'PluginUrlObject'
        /// </summary>
        [Test]
        public void PluginUrlObjectTest()
        {
            // TODO unit test for the property 'PluginUrlObject'
        }
        /// <summary>
        /// Test the property 'Popularity'
        /// </summary>
        [Test]
        public void PopularityTest()
        {
            // TODO unit test for the property 'Popularity'
        }
        /// <summary>
        /// Test the property 'PreviewYoutubeId'
        /// </summary>
        [Test]
        public void PreviewYoutubeIdTest()
        {
            // TODO unit test for the property 'PreviewYoutubeId'
        }
        /// <summary>
        /// Test the property 'PrivateOccupants'
        /// </summary>
        [Test]
        public void PrivateOccupantsTest()
        {
            // TODO unit test for the property 'PrivateOccupants'
        }
        /// <summary>
        /// Test the property 'PublicOccupants'
        /// </summary>
        [Test]
        public void PublicOccupantsTest()
        {
            // TODO unit test for the property 'PublicOccupants'
        }
        /// <summary>
        /// Test the property 'PublicationDate'
        /// </summary>
        [Test]
        public void PublicationDateTest()
        {
            // TODO unit test for the property 'PublicationDate'
        }
        /// <summary>
        /// Test the property 'ReleaseStatus'
        /// </summary>
        [Test]
        public void ReleaseStatusTest()
        {
            // TODO unit test for the property 'ReleaseStatus'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'ThumbnailImageUrl'
        /// </summary>
        [Test]
        public void ThumbnailImageUrlTest()
        {
            // TODO unit test for the property 'ThumbnailImageUrl'
        }
        /// <summary>
        /// Test the property 'UnityPackageUrlObject'
        /// </summary>
        [Test]
        public void UnityPackageUrlObjectTest()
        {
            // TODO unit test for the property 'UnityPackageUrlObject'
        }
        /// <summary>
        /// Test the property 'UnityPackages'
        /// </summary>
        [Test]
        public void UnityPackagesTest()
        {
            // TODO unit test for the property 'UnityPackages'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'Visits'
        /// </summary>
        [Test]
        public void VisitsTest()
        {
            // TODO unit test for the property 'Visits'
        }

    }

}