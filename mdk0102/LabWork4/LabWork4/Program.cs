using System;

namespace LabWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Id = 1;
            Console.WriteLine(user.Id);
            try
            {
                user.Id = -4156453;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            user.Login = "123";
            Console.WriteLine(user.Login);
            try
            {
                user.Login = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                user.Login = "hy iru6e5754w7457wbytrbyesgdesdgsdgsdrgyhsegfsdgfdsgdfgdfgdfgdfgdfgd";
            }
            catch (StringArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.ErrorCode);
            }
            user.Password = "123";
            Console.WriteLine(user.Password);
            try
            {
                user.Password = "hgdhgfdhsfhsfgdhdfghsfdfghdfghfdfgdfgdfgdfgdfgdfgdfgdghdfhdfh";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nПодробности: "+ ex.HelpLink);
            }
        }
    }
}
