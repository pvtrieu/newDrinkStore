using System.Collections.Generic;
using System.Linq;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class PositionDAO
    {
        public static List<Position> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Positions.ToList();
            }
        }
    }
}
