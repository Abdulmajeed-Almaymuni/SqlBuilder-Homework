using System;

namespace SqlBuilder
{
    class Program
    {
       public class Query
       {
            string query;
            public Query()
            {
                this.query = "SELECT ";
            }

            public Query Fields(string [] array)
            {
                foreach (var item in array)
                {
                    this.query += item + ", ";
                }
                this.query = this.query.Substring(0, this.query.Length - 2);
                    return this;
            }

            public Query Table(string table)
            {
                this.query += " FROM " + table;
                return this;
            }

            public Query Where(string where)
            {
                this.query += "\nWHERE " + where;
                return this;
            }

            public string getQuery()
            {
                return this.query;
            }

       }
        static void Main(string[] args)
        {
            Query query = new Query();
            string[] fields = { "ID", "Name" };
            query.Fields(fields).Table("Tuwaiq").Where("Name = Abdulmajeed Almaymuni");
            Console.WriteLine(query.getQuery());
        }
    }
}
