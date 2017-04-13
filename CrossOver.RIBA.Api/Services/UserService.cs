using CrossOver.RIBA.Contracts.Results;
using CrossOver.RIBA.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrossOver.RIBA.Api.Services
{
	public class UserService : IUserService
	{
		ICrossOverContext _context;

		public UserService(CrossOverContext context)
		{
			this._context = context;
		}

		public UserResult Login(string username, string password)
		{
			var result = this._context.Users
				.SingleOrDefault(p => p.UserName == username && p.Password == password);

			var ret = AutoMapper.Mapper.Map<UserResult>(result);

			return ret;
		}
	}
}
