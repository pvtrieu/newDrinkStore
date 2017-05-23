using DrinkStore.DAO;
using DrinkStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkStore.BUS
{
    class GenderBUS
    {
        public static List<Gender> getAll()
        {
            return GenderDAO.getAll();
        }
    }
}
