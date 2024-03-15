namespace Domain.entity;

using J3DI.Domain;
using J3DI.Infrastructure.EntityFactoryFx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;


/// <summary>
/// A factory for creating instances of an Individual.
/// </summary>
public class IndividualFactory : EntityFactoryBase<Individual, Guid>
{

    /// <summary>
    /// Copies an Individual instance to another instance.
    /// </summary>
    /// <param name="indiv">The source Individual.</param>
    /// <returns>A copy of the source Individual.</returns>
    public static Individual Copy(Individual indiv)
    {
        return IndividualFactory.Create(indiv.Id, indiv.Name, indiv.Created);
    }


    /// <summary>
    /// Creates an instance of an Individual.
    /// </summary>
    /// <param name="id">The unique id for the Individial instance.</param>
    /// <param name="name">The Individual's name.</param>
    /// <param name="created">When the Individual was created (UTC).</param>
    /// <returns>The Individual instance.</returns>
    public static Individual Create(Guid id, string name, DateTime created)
    {
        return new Individual(id, name, created);
    }


    /// <summary>
    /// Builds Individuals from an IDataReader.
    /// </summary>
    /// <param name="reader">An IDataReader for IDataRecords of Individual data.</param>
    /// <returns>An enumerable collection of Individuals.</returns>
    public override IEnumerable<EntityBase<Guid>> BuildEntities(IDataReader reader)
    {
        if (null == reader) { throw new ArgumentNullException("reader"); }

        List<Individual> indivs = new List<Individual>();
        while (reader.Read())
        {
            Individual t = BuildEntity(reader) as Individual;
            Trace.Assert(null != t, "BuildEntity failed creating Individual");
            indivs.Add(t);
        }

        return indivs;
    }


    /// <summary>
    /// Builds an Identity instance from an IDataRecord.
    /// </summary>
    /// <param name="record">An IDataRecord of data for an Individual.</param>
    /// <returns>An instance of Individual.</returns>
    public override EntityBase<Guid> BuildEntity(IDataRecord record)
    {
        if (null == record) { throw new ArgumentNullException("record"); }

        // TODO: this impl is too tied to the IDataReader of IndividualsDataReader             
        return IndividualFactory.Create((Guid)record[0], record[1] as string, (DateTime)record[2]);
    }

}
