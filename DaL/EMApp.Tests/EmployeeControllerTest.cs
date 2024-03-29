// <copyright file="EmployeeControllerTest.cs">Copyright ©  2017</copyright>
using System;
using System.Web.Mvc;
using EMApp.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EMApp.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for EmployeeController</summary>
    [PexClass(typeof(EmployeeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class EmployeeControllerTest
    {
        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]EmployeeController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method EmployeeControllerTest.IndexTest(EmployeeController)
        }
    }
}
