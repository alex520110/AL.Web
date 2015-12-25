using System;

namespace AL.Data
{
	public interface IEntityFactory
	{
		object Create(Type type);
	}
}
