using CrossOver.RIBA.Contracts.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrossOver.RIBA.Api.Services
{
    public interface IUserService
    {
		UserResult Login(string username, string password);

	}
}
