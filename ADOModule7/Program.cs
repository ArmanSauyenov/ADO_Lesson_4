using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOModule7
{
    public class Programe
    {
        private static DataContext dataContext;
        static void Main(string[] args)
        {
            dataContext = new DataContext("Data Source=192.168.110.195; Initial Catalog=CRCMS_new; User ID=sa; Password=Ev4865");
            Task1();
        }
        public static void Task1()
        {
            Table<Area> areas = dataContext.GetTable<Area>();
            //foreach (Area item in areas.Where(w => w.WorkinPeople > 2))
            //{
            //    Console.WriteLine(item.Name);
            //}

            //DataLoadOptions options = new DataLoadOptions();
            //options.AssociateWith<Area>(c => c.WorkingPeople > 2);
            //dataContext.LoadOptions = options;
            //Table<Area> areas2 = dataContext.GetTable<Area>();
            //foreach (Area item in areas2)
            //{
            //    Console.WriteLine(item.Name);
            //}

            List<Area> temparea = areas.Where(w=>w.AssemblyArea !=null).Where(w=> (bool)w.AssemblyArea).ToList();
            foreach (Area item in temparea)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
