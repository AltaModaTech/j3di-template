namespace Domain.entity.Test;

using System;
using System.Diagnostics.CodeAnalysis;

using Domain.entity;


[TestClass]
[ExcludeFromCodeCoverage]
public class IndividualTests
{
    [TestMethod]
    public void can_create_Individual()
    {
        string testname = "foo";
        var i = new Individual(testname);
        i.Name.Should().Be(testname);
        i.Id.Should().NotBe(Guid.Empty);
        // i.ContactInfo = _ci;

        // i.ContactInfo.Should().BeEquivalentTo(_ci);

        // int emails = 0, phones = 0, addr = 0;
        // foreach (var a in i.ContactInfo.EmailAddresses) {
        //     a.Key.Length.Should().BeGreaterThan(0);
        //     a.Value.Address.Length.Should().BeGreaterThan(0);
        //     ++emails;
        // }
        // foreach (var p in i.ContactInfo.PhoneNumbers) {
        //     p.Key.Length.Should().BeGreaterThan(0);
        //     p.Value.Number.Length.Should().BeGreaterThan(0);
        //     ++phones;
        // }
        // foreach (var a in i.ContactInfo.PostalAddresses) {
        //     a.Key.Length.Should().BeGreaterThan(0);
        //     a.Value.Address1.Length.Should().BeGreaterThan(0);
        //     ++addr;
        // }

        // emails.Should().BeGreaterThan(0);
        // phones.Should().BeGreaterThan(0);
        // addr.Should().BeGreaterThan(0);
    }


    [TestInitialize]
    public void test_init()
    {
        // _ci.AddEmailAddress("Other", new EmailAddress("foo@bar.baz"));
        // _ci.AddPhoneNumber("Other", new PhoneNum("123-456-7890"));
        // _ci.AddPostalAddress("Other", new PostalAddress { 
        //     Address1 = "123 someplace blvd"
        //     ,Address2 = "suite 74"
        //     ,ZipCode = "12345"
        // });
    }

    // private ContactInfo _ci = new shared.ContactInfo();
}