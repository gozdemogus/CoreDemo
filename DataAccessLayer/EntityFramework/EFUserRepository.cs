using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EFUserRepository:GenericRepository<AppUser>,IUserDal
	{
		public EFUserRepository()
		{
		}
	}
}

