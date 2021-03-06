﻿using System;

namespace repository_pattern.domain.Account.Aggregate.Specification
{
	public class UserAccountSpecification
	{
		public static ISpecification<UserAccount> GetAllByCPF(string cpf)
		{
			Specification<UserAccount> spec = new Specification<UserAccount>(x => x.CPF == cpf);

			spec.And(new Specification<UserAccount>(x => !String.IsNullOrWhiteSpace(x.Email)));

			return spec;
		}
	}
}
