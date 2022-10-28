using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Magazine.Entities;
using Magazine.Persistence;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

            CreateSampleDB(dal);
        }

        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();
            Console.WriteLine("Creando los datos y almacenándolos en la BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE UNA REVISTA Y SU EDITOR EN JEFE");
            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(u1);
            dal.Commit();

            User u2 = new User("56", "Juan", "TheEditor", false, "ninguna", "jdiaz@gmail.com", "theeditor", "1234");
            dal.Insert<User>(u2);
            dal.Commit();

            User u3 = new User("78", "Alejandra", "TheResponsible", false, "ninguna", "alejmor@gmail.com", "theresponsible", "1234");
            dal.Insert<User>(u3);
            dal.Commit();

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            u1.Magazine = m;
            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("  Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            Magazine.Entities.Issue i = new Magazine.Entities.Issue(1, m);
            m.Issues.Add(i);
            dal.Insert<Magazine.Entities.Issue>(i);
            dal.Commit();

            Magazine.Entities.Area area = new Magazine.Entities.Area("Animals", u2, m);
            m.Areas.Add(area);
            u2.Area = area;
            dal.Insert<Magazine.Entities.Area>(area);
            dal.Commit();

            Magazine.Entities.Paper p = new Magazine.Entities.Paper("Wild Animals", DateTime.Now, area, u3);
            u3.MainAuthoredPapers.Add(p);
            p.EvaluationPendingArea = area;
            area.EvaluationPending.Add(p);
            area.Papers.Add(p);
            dal.Insert<Magazine.Entities.Paper>(p);
            dal.Commit();

            Console.WriteLine("Finished");
        }

    }

}
