using System;
using System.Text;


namespace Demo_UserDefined_Attribute
{
    [Author_Attributes("Busireddy Sneha")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User defined attribute..");
            Author_Attributes A1 = new Author_Attributes("Busireddy");
            Console.WriteLine("Author name is: Dale Charnige ");
            Console.WriteLine("By default version of author is:\t{0}", A1.Version_name);

        }

    }
    [System.AttributeUsage(System.AttributeTargets.Class|System.AttributeTargets.Method)]
    public class Author_Attributes: System.Attribute
    {
        private string AuthorName;
        public Double Version_name;
        public Author_Attributes(string name)
        {
            this.AuthorName = name;
            Version_name = 8.0;
        }
    }
}
