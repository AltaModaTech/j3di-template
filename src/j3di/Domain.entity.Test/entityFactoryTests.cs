namespace Domain.entity.Test;


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using Domain.entity;



[TestClass]
[ExcludeFromCodeCoverage]
public class IndividualFactoryTests
{
    private IndividualDataReader _testIndividuals;

    private List<IndividualDataRecord> _indivs = new List<IndividualDataRecord>() {
      new IndividualDataRecord(Guid.Parse("0d33f4e2-8153-4b85-b6d7-508aaed8430f"), "Individual 0", DateTime.Parse("1/1/1970")),
      new IndividualDataRecord(Guid.Parse("236979e3-818d-45d0-b6cd-a9e3e29d2f24"), "Individual 1", DateTime.Parse("12/31/2000")),
      new IndividualDataRecord(Guid.Parse("2890f5e4-a296-459a-97cc-216fdd1f6e22"), "Individual 2", DateTime.Parse("2/28/2025"))
    };


    [TestMethod]
    public void can_create_from_IDataReader()
    {
        _testIndividuals = new IndividualDataReader(_indivs);

        var idx = 0;
        var factory = new IndividualFactory();

        foreach (Individual indiv in factory.BuildEntities(_testIndividuals))
        {
            indiv.Name.Should().NotBeNull();
            // indiv.ContactInfo.Should().NotBeNull();

            ++idx;
        }

        idx.Should().Be(_indivs.Count);
    }


    [TestMethod]
    public void handles_null_IDataReader()
    {
        Action act = () => new IndividualFactory().BuildEntities(null);

        act.Should().Throw<ArgumentNullException>();
    }


    [TestMethod]
    public void handles_null_IDataRecord()
    {
        Action act = () => new IndividualFactory().BuildEntity(null);

        act.Should().Throw<ArgumentNullException>();
    }


}
