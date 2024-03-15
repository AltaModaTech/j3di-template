namespace Domain.entity;

using System;


/// <summary>
/// Represents an Individual entity.
/// </summary>
public class Individual : J3DI.Domain.EntityBase<Guid>
{
    // Ctor for new instance (yet to be stored in repo)
    public Individual(string name) : this(Guid.NewGuid(), name, DateTime.UtcNow) {}


    /// <summary>
    /// The unique identity of the Individual.
    /// </summary>
    public new Guid Id 
    {
        get { return base.Id; }
        // Ensure only EntityBase can change Id
        private set { /* no-op */ }
    }

    /// <summary>
    /// The name of the Individual.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Individual's contact information.
    /// </summary>
// TODO:    // public ContactInfo ContactInfo { get; set; }


    // Ctor for factory; do not use
    internal Individual(Guid id, string name, DateTime created) : base(id, created)
    {
        this.Name = name;
    }

}
