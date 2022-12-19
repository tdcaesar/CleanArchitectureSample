﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Members;
public interface IMemberRepository
{
    Task CreateAsync(Member member, CancellationToken cancellationToken);
    Task<Member?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}