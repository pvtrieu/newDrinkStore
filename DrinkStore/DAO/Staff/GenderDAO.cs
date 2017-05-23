using System.Collections.Generic;
using System.Linq;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class GenderDAO
    {
        public static List<Gender> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Genders.ToList();
            }
        }
    }
}
