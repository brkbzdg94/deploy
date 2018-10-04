// <copyright file="GetCustomerTest.cs">Copyright ©  2018</copyright>

using System;
using CustomerServiceTest;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerServiceTest.Tests
{
    [TestClass]
    [PexClass(typeof(GetCustomer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GetCustomerTest
    {

        [PexMethod]
        public void Can_GetCustomer([PexAssumeUnderTest]GetCustomer target)
        {
            target.Can_GetCustomer();
            // TODO: add assertions to method GetCustomerTest.Can_GetCustomer(GetCustomer)
        }
    }
}
