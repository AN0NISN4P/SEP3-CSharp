using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseAccess.DataRepos.Impl
{
	public class LocationDataRepo : IDataRepo<Location, string>
	{
		private SEP_DBContext _database;

		public LocationDataRepo(DbContext dbContext)
		{
			_database = (SEP_DBContext)dbContext;
		}

		public async Task AddAsync(Location location)
		{
			await _database.Locations.AddAsync(location);
			await _database.SaveChangesAsync();
		}

		public async Task<Location> RemoveAsync(string id)
		{
			Location locationToRemove = await _database.Locations.FindAsync(id);
			if (locationToRemove != null)
			{
				_database.Locations.Remove(locationToRemove);
			}
			return locationToRemove;
		}

		public async Task UpdateAsync(string id, Location obj)
		{
			await AddAsync(obj);
			await RemoveAsync(id);
		}

		public async Task<IList<Location>> GetAllAsync()
		{
			return await _database.Locations.ToListAsync();
		}

		public async Task<Location> GetAsync(string locationId)
		{
			return await _database.Locations.FindAsync((string)locationId);
		}
	}
}