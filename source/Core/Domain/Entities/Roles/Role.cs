﻿using Domain.Entities.Members;
using Domain.Entities.Permissions;
using Domain.Shared;
using Domain.ValueObjects;

namespace Domain.Entities.Roles;
public sealed class Role : Entity
{
    /// <summary>
    /// The title of the Role
    /// </summary>
    public Name Name { get; private set; }
    /// <summary>
    /// A description of the purpose or use
    /// </summary>
    public Description Description { get; private set; }

    /// <summary>
    /// Constructor requires values for all properties
    /// </summary>
    /// <param name="id">the unique identifier</param>
    /// <param name="name">the title of the tag</param>
    /// <param name="description">a description of the use of the role</param>
    private Role(Guid id, Name name, Description description)
        : base(id)
    {
        Name = name;
        Description = description;
    }

    /// <summary>
    /// Creates a new object automatically adding an Id
    /// </summary>
    /// <param name="name">the title of the Role</param>
    /// <param name="description">a description of the Role</param>
    /// <returns>a Role</returns>
    public static Role Create(Name name, Description description)
    {
        Guid id = Guid.NewGuid();
        return new Role(id, name, description);
    }
    /// <summary>
    /// Creates a new object automatically adding an Id
    /// </summary>
    /// <param name="id">the unique identifier to index</param>
    /// <param name="name">the title of the Role</param>
    /// <param name="description">a description of the Role</param>
    /// <returns>a Role</returns>
    public static Role Create(Guid id, Name name, Description description)
    {
        return new Role(id, name, description);
    }
}
//public sealed class RoleEnum : Enumeration<RoleEnum>
//{
//    public static readonly RoleEnum Registered = new(1, "Registered");

//    public ICollection<Permission> Permissions { get; set; }
//    public ICollection<MemberData> Members { get; set; }

//    public RoleEnum(int id, string name)
//        : base(id, name) { }


//}
