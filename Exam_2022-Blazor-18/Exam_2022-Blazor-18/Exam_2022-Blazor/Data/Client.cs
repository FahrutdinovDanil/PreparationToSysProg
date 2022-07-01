using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_2022_Blazor.Data
{
    public class Client
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public static List<Client> st = new List<Client>();

        public Client(string name, string login, string mail)
        {
            this.Name = name;
            this.Login = login;
            this.Mail = mail;
        }
        public Client()
        {
            
        }
        public static void AddClient(string name, string login, string mail)
        {
            Client std = new Client(name, login, mail);
            st.Add(std);
        }
        public static List<Client> GetClient()
        {
            return st;
        }
    }
}
