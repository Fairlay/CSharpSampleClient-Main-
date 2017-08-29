﻿using FairlayDotNetClient.Private.Requests;
using FairlayDotNetClient.Private.Requests.Infrastructure;
using NUnit.Framework;

namespace FairlayDotNetClient.Tests.Private.Requests.Infrastructure
{
	public class PrivateApiRequestExtensionsTests
	{
		[Test]
		public void TestFormatIntoSignableString()
		{
			var request = TestData.Request;
			string expectedFormat =
				$"{TestData.Nonce}|{request.UserId}|{request.Header}|{request.Body}";
			Assert.That(request.FormatIntoSignableString(TestData.Nonce), Is.EqualTo(expectedFormat));
		}
	}
}