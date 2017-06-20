using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetSupHelp.Models
{
    public class DbInitializer<T> : DropCreateDatabaseIfModelChanges<SupHelpDbContext>
    {
        protected override void Seed(SupHelpDbContext context)
        {
            context.Courses.Add(new Course() { Id = 1, Label = "1ADS", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 2, Label = "1ARI", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 3, Label = "1CNA", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 4, Label = "1CPA", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 5, Label = "1ENG", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 6, Label = "1GCC", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 7, Label = "1JWB", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 8, Label = "1LAL", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 9, Label = "1LAW", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 10, Label = "1LIN", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 11, Label = "1MER", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 12, Label = "1MGT", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 13, Label = "1MSA", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 14, Label = "1ORC", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 15, Label = "1OSS", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 16, Label = "1SEC", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 17, Label = "1SET", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 18, Label = "1WEB", Description = "none", Year = Course.SupinfoYear.ASc1 });
            context.Courses.Add(new Course() { Id = 19, Label = "2ADS", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 20, Label = "2CMP", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 21, Label = "2CNB", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 22, Label = "2CPP", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 23, Label = "2ENG", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 24, Label = "2GRA", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 25, Label = "2JVA", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 26, Label = "2JWB", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 27, Label = "2LAW", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 28, Label = "2LIN", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 29, Label = "2MGT", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 30, Label = "2MSA", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 31, Label = "2NET", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 32, Label = "2OOP", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 33, Label = "2ORC", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 34, Label = "2PBS", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 35, Label = "2UML", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 36, Label = "2WEB", Description = "none", Year = Course.SupinfoYear.ASc2 });
            context.Courses.Add(new Course() { Id = 37, Label = "3AIT", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 38, Label = "3AND", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 39, Label = "3APL", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 40, Label = "3ASP", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 41, Label = "3CNS", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 42, Label = "3ENG", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 43, Label = "3JVA", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 44, Label = "3LAW", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 45, Label = "3LIN", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 46, Label = "3MET", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 47, Label = "3MGT", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 48, Label = "3MSA", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 49, Label = "3ORC", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 50, Label = "3WEB", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 51, Label = "3WIN", Description = "none", Year = Course.SupinfoYear.BSc3 });
            context.Courses.Add(new Course() { Id = 52, Label = "4AIT", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 53, Label = "4BIS", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 54, Label = "4CLD", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 55, Label = "4ENG", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 56, Label = "4EPS", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 57, Label = "4ERP", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 58, Label = "4JVA", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 59, Label = "4LAW", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 60, Label = "4MET", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 61, Label = "4MGT", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 62, Label = "4MOS", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 63, Label = "4MSE", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 64, Label = "4NET", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 65, Label = "4VIP", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 66, Label = "4VTZ", Description = "none", Year = Course.SupinfoYear.MSc1 });
            context.Courses.Add(new Course() { Id = 67, Label = "5BCP", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 68, Label = "5BIS", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 69, Label = "5CLD", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 70, Label = "5DAT", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 71, Label = "5EBP", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 72, Label = "5EMI", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 73, Label = "5ENG", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 74, Label = "5LAW", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 75, Label = "5MET", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 76, Label = "5MGT", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 77, Label = "5ORC", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 78, Label = "5TGF", Description = "none", Year = Course.SupinfoYear.MSc2 });
            context.Courses.Add(new Course() { Id = 79, Label = "5VTZ", Description = "none", Year = Course.SupinfoYear.MSc2 });

            //Seed SupInfo campus in localDb
            context.Campus.Add(new Campus() { ID = 1, City = " Paris", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 2, City = " Bordeaux", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 3, City = " Caen", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 4, City = " Clermont-Ferrand", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 5, City = " Grenoble", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 6, City = " Lille", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 7, City = " Lyon", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 8, City = " Marseille", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 9, City = " Metz", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 10, City = " Montpellier", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 11, City = " Nantes", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 12, City = " Nice", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 13, City = " Orléans", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 14, City = " Reims", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 15, City = " Rennes", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 16, City = " Strasbourg", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 17, City = " Toulouse", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 18, City = " Tours", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 19, City = " Troyes", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 20, City = " Valenciennes", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 21, City = " Martinique", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 22, City = " Guadeloupe", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 23, City = " Réunion", Continent = "France et Outre-Mer" });
            context.Campus.Add(new Campus() { ID = 24, City = " Bruxelles", Continent = "Europe" });
            context.Campus.Add(new Campus() { ID = 25, City = " Londres", Continent = "Europe" });
            context.Campus.Add(new Campus() { ID = 26, City = " Luxembourg", Continent = "Europe" });
            context.Campus.Add(new Campus() { ID = 27, City = " Rome", Continent = "Europe" });
            context.Campus.Add(new Campus() { ID = 28, City = " Suisse", Continent = "Europe" });
            context.Campus.Add(new Campus() { ID = 29, City = " Trapani", Continent = "Europe" });
            context.Campus.Add(new Campus() { ID = 30, City = " Montréal", Continent = "Amérique" });
            context.Campus.Add(new Campus() { ID = 31, City = " San Francisco", Continent = "Amérique" });
            context.Campus.Add(new Campus() { ID = 32, City = " Rio de Janeiro", Continent = "Amérique" });
            context.Campus.Add(new Campus() { ID = 33, City = " Casablanca", Continent = "Afrique" });
            context.Campus.Add(new Campus() { ID = 34, City = " Île-Maurice", Continent = "Afrique" });
            context.Campus.Add(new Campus() { ID = 35, City = " Sénégal", Continent = "Afrique" });
            context.Campus.Add(new Campus() { ID = 36, City = " Rabat", Continent = "Afrique" });
            context.Campus.Add(new Campus() { ID = 37, City = " Hong Kong", Continent = "Asie" });
            context.Campus.Add(new Campus() { ID = 38, City = " Tianjin", Continent = "Asie" });
            context.Campus.Add(new Campus() { ID = 39, City = " Beijing", Continent = "Asie" });
            context.Campus.Add(new Campus() { ID = 40, City = " Zhenjiang", Continent = "Asie" });

            base.Seed(context);
        }
    }
}